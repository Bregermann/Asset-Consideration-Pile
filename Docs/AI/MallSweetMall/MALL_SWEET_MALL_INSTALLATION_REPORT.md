# Mall Sweet Mall installation report

The intake reconciles all 105 master-audit rows and the 79-area coverage matrix. No money was spent. TidyCore was read-only.

| State | Rows |
| --- | ---: |
| Already installed | 16 |
| Archive only | 2 |
| Deferred free alternative | 4 |
| Newly installed | 27 |
| Optional deferred | 9 |
| Ownership hold | 1 |
| Packages with Unity visuals | 11 |
| Paid review | 7 |
| TidyCore authoring | 35 |
| TidyCore baseline | 4 |
| Verified new Unity cache downloads | 20 |

The [availability manifest](MALL_SWEET_MALL_ACP_ASSET_AVAILABILITY.csv) gives evidence by package. The [component directory](MALL_SWEET_MALL_COMPONENT_DIRECTORY.csv) indexes individual FBX and prefab paths and source GUIDs. A source-only dependency row lists additional GUIDs that still need resolution in Unity. The [visual index](Visuals/capture-index.tsv) separates native materials and temporary URP material previews. No TidyCore runtime or optimization benchmark was run.

## Download and validation results

The 25 new downloads comprise 20 authenticated Unity packages, four Kenney archives and one Poly Haven texture family. ACP has 16 pre-existing and 27 newly installed package or resource families from the audit. Fifteen alternatives remain archived or deferred, and the Pizza Doggy pack remains on its rights hold. Six paid Unity listings lacked entitlements in the queried account. The seventh paid candidate needs a separate itch.io entitlement.

The isolated Unity 6.4 inspection checked 3,647 assets across all 27 newly installed families. Twenty-two of those families had no missing loaded asset, script or material slot at the scope tested. Four pre-existing families received representative renders, bringing the total to 31 Unity-checked families. The 115 flagged items are concentrated in five packages.

| Package | Flagged items | Transfer treatment |
| --- | ---: | --- |
| School Assets | 48 | Select clean models or prefabs for retail props. Rebuild scene-specific components only when needed. |
| CoffeeShop Starter Pack | 48 | Select standalone art. Leave order logic and demo effects out of the transfer. |
| Fast Food Restaurant Kit | 17 | Select clean appliance models. Review the flagged door and entrance fixtures. |
| Destroyable Retro CRT Monitor Prop | 1 | Select intact FBX artwork and supply TidyCore behavior independently. |
| Ball Pack | 1 | Leave the flagged EyeBall 2 model out of the retail stock pass. |

The [Unity import checks](UNITY_IMPORT_CHECKS.tsv) identify each affected file and its resolved dependencies. The [visual catalogue](Visuals/README.md) contains 44 renders across 11 families. Prefab import checks do not establish shader support or title runtime readiness.

## Essential assets

**Mall Environment.** Compared 406 archive entries against ACP. All paths exist. The sample Plane.prefab has a different installed GUID and was left in place. The narrow and wide storefronts, shutter, escalator and elevator components rendered with temporary URP material copies. The original Built-in assignments were preserved.

**Sundown.** The nested URP archive contains 1,100 paths. Four native URP fixtures rendered with no missing scripts. The [transfer closure](SUNDOWN_URP_TRANSFER_CLOSURE.csv) lists the tested shelves, counters and dependencies.

**Optimization.** Perfect Culling imports in the isolated Unity 6.4 editor. It and Super Level Optimizer 2 remain optional. Performance, additive scenes and behavior with 10,000 items still need a title-specific benchmark.

**Ownership.** The November 24 ownership record confirms Vintage Computer Keyboard and PrimeTween by name and publisher. The corresponding IDs resolved in the authenticated Unity account. The newer Polyquest ownership and installation records remain intact.
