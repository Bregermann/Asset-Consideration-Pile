"""Restore local licensed assets for the Windows audio validation slice."""
import argparse
import gzip
import hashlib
from pathlib import Path, PurePosixPath
import re
import shutil
import tarfile
from tempfile import TemporaryDirectory

parser = argparse.ArgumentParser()
parser.add_argument('project', type=Path)
parser.add_argument('depot', type=Path)
parser.add_argument('sonity', type=Path)
parser.add_argument('--dressing-package', type=Path)
parser.add_argument('--keep-installed-sonity', action='store_true')
args = parser.parse_args()
project, depot = args.project.resolve(), args.depot.resolve()
assert (project / 'ProjectSettings/ProjectVersion.txt').is_file()
with args.sonity.open('rb') as stream:
    assert hashlib.file_digest(stream, 'sha256').hexdigest() == (
        'b0d983e82f1c05a8b20b94244e2aac4382f6e7819a25c5b9fc5a93d52a19fa56')

def restore_unitypackage(source_package):
    groups = {}
    with TemporaryDirectory() as spool, gzip.open(source_package, 'rb') as compressed, \
            tarfile.open(fileobj=compressed, mode='r|') as archive:
        for member in archive:
            match = re.fullmatch(r'([0-9a-f]{32})/(asset|asset\.meta|pathname)', member.name)
            if not member.isfile() or not match:
                continue
            guid, kind = match.groups()
            local = Path(spool) / f'{guid}-{kind}'
            with local.open('xb') as output:
                shutil.copyfileobj(archive.extractfile(member), output)
            groups.setdefault(guid, {})[kind] = local
        for group in groups.values():
            if 'pathname' not in group:
                continue
            path = PurePosixPath(group['pathname'].read_text(encoding='utf-8-sig').splitlines()[0])
            if path.is_absolute() or '..' in path.parts or '\\' in str(path) or ':' in str(path):
                raise ValueError(path)
            if path.parts[0] != 'Assets':
                raise ValueError(f'Unexpected vendor archive root: {path}')
            target = project.joinpath(*path.parts)
            target.resolve().relative_to(project / 'Assets')
            if 'asset' in group:
                target.parent.mkdir(parents=True, exist_ok=True)
                with group['asset'].open('rb') as source, target.open('wb') as output:
                    shutil.copyfileobj(source, output)
            else:
                target.mkdir(parents=True, exist_ok=True)
            if 'asset.meta' in group:
                target.with_name(target.name + '.meta').write_bytes(group['asset.meta'].read_bytes())


if not args.keep_installed_sonity:
    restore_unitypackage(args.sonity)
elif not (project / 'Assets/Plugins/Sonity/Scripts/Public/Components/SoundManager.cs').is_file():
    raise FileNotFoundError('Restore the paid Sonity archive first.')
if args.dressing_package:
    restore_unitypackage(args.dressing_package)

sidearm = 'Assets/Ultimate SFX Bundle - HD Remaster/'
tps = 'Assets/Julhiecio TPS Controller/Audio/Footstep/'
cues = {
    'WetAsphalt': tps + 'Concrete/WAV Alternatives/Footstep on Concrete 01 WAV.wav',
    'Snow': sidearm + 'Survival Sound Kit - HD Remake/Footsteps Snow (Running) 10.wav',
    'Tile': tps + 'Tiles/WAV Footsteps Tiles Alternatives/Footstep-on-tiles01.wav',
    'Gravel': tps + 'Stones/WAV Stone Footsteps Alternative/Footsteps-on-stone02.wav',
    'Impact': sidearm + 'Fight sounds - HD Remake/Game Punch (1).wav',
    'Gunshot': sidearm + 'Gun Sounds Pro - HD Remake/Pistol Shot 10.wav',
    'Siren': sidearm + 'Real Recorded Cars/Car Alarm Loop.wav',
    'Radio': sidearm + 'Hero Voice Amy - HD Remake/1ST_LIEUTENANT.wav',
    'Voice': sidearm + 'Hero Voice Amy - HD Remake/ARE_YOU_READY.wav',
    'Engine': sidearm + 'Real Recorded Cars/Car Engine Loop.wav',
    'EngineStop': sidearm + 'Real Recorded Cars/Car Engine Stop.wav',
    'Collision': 'Packages/com.nwh.vehiclephysics/Samples~/BaseSample/Sound/Crash/Crash-01.wav',
    'Rain': sidearm + 'Ultimate Water Sounds/Rain Loop Inside Car 1.wav',
    'Wind': sidearm + 'Nature ambiances VOL 2 - HD Remake/Light wind 2.wav',
    'Underground': sidearm + 'Ultimate Water Sounds/Water Dripping 1.wav',
    'Club': 'Assets/Outlaw Loops - Modern Western Music/Another Dust Lullaby 122 BPM Loop.wav',
    'Menu': sidearm + 'Modern UI Sounds - HD Remake/Clicks Sound (button hover) 1.wav',
    'QuestWon': sidearm + 'Modern UI Sounds - HD Remake/Success 1.wav',
    'QuestLost': sidearm + 'Modern UI Sounds - HD Remake/Error 1.wav',
}
destination = project / 'Assets/MovingViolation/Resources/TrialCues'
destination.mkdir(parents=True, exist_ok=True)
for cue, path in cues.items():
    with (depot / path).open('rb') as source, (destination / f'{cue}.wav').open('wb') as output:
        shutil.copyfileobj(source, output)
print(f'Restored full Sonity archive and {len(cues)} cue bindings.')
