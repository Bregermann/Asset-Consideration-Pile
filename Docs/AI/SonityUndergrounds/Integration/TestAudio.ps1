param(
    [Parameter(Mandatory)] [string] $Player,
    [Parameter(Mandatory)] [string] $EvidenceDirectory,
    [ValidateRange(30, 600)] [int] $TimeoutSeconds = 120
)

$ErrorActionPreference = 'Stop'
$playerPath = (Resolve-Path -LiteralPath $Player).Path
$evidencePath = (New-Item -ItemType Directory -Path $EvidenceDirectory -Force).FullName

foreach ($test in '--audio-smoke', '--verify-volume') {
    $log = Join-Path $evidencePath ($test.TrimStart('-') + '.log')
    $options = @($test, '-screen-fullscreen', '0', '-screen-width', '960',
        '-screen-height', '540', '-logFile', ('"' + $log + '"'))
    $folder = Split-Path $playerPath
    $process = Start-Process -FilePath $playerPath -WorkingDirectory $folder -ArgumentList $options -WindowStyle Hidden -PassThru
    if (!$process.WaitForExit($TimeoutSeconds * 1000)) {
        $process.Kill()
        throw "Audio validation timed out for $test."
    }
    $result = Select-String -LiteralPath $log -Pattern 'MOVING_VIOLATION_AUDIO_(PASS|FAIL)' | Select-Object -Last 1
    if ($process.ExitCode -ne 0 -or $result.Line -notmatch 'MOVING_VIOLATION_AUDIO_PASS') {
        throw "Audio validation failed for $test with exit $($process.ExitCode). $($result.Line)"
    }
    $result.Line
}
