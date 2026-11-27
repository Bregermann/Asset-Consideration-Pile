# Mall Sweet Mall selective transfer handoff

Use [the availability manifest](MALL_SWEET_MALL_ACP_ASSET_AVAILABILITY.csv) to choose a package and [the component directory](MALL_SWEET_MALL_COMPONENT_DIRECTORY.csv) to locate individual prefabs and FBX files. Paths starting with Assets are relative to the existing ACP Unity project. Source-only dependencies need a Unity dependency check before export. The [store coverage matrix](MALL_SWEET_MALL_STORE_COVERAGE_MATRIX.csv) preserves all 79 area proposals and their outstanding needs.

## Architecture first

- Start with **Mall Environment** at Assets/Nimikko_Mall. Search for SM_StoreFront_Glass_500, SM_StoreFront_Glass_2000, SM_StoreFront_Atrium_01, SM_Shutter_01, SM_Escalator_01 and SM_ElevatorDoor_01. The source contains 123 FBX, 144 prefabs, 48 materials, 81 PNG textures and one sample scene. These are shells and visual pieces. Author transport, shutter motion, accessibility routes and two-player behavior with TidyCore's systems.
- For the storefront test, transfer one narrow and one wide bay with their mesh, material and texture closures. Make title-owned prefab variants. Duplicate each selected Built-in material into title-owned storage and map its albedo/color, normal and metallic/smoothness values to URP Lit. Check texture color space, transparency, render queues and glass from both sides. Inspect UV tiling and normal orientation. Preserve source materials and metadata. Bake lighting and add colliders and navigation in TidyCore.
- Use **Sundown** for shelves and counters. The URP edition is Assets/Hivemind/ShopStore/URP/ShopStore_URP.unitypackage. Review SM_Shelf_A, SM_Shelf_Unit_Reg, SM_Counter_1 and SM_TV_Counter. Keep the vendor editions separate by GUID. Substitute 1998 graphics, use fiction-only displays and skip vendor scene settings.

## Four-area vertical slice

| Area | Select first | Leave for title authoring |
| --- | --- | --- |
| Toy store | Plush Toys Low-Poly Big Pack and Sundown shelving. Pick a few distinct silhouettes and inspect the stamped collider meshes. | Action figures, dolls, pegboard hooks and licensed fictional package art. Avoid variants that repeat existing Queen silhouettes. |
| Arcade | Compare Arcade Machines PolyPack with Packs 01 and 02. Keep one upright and any visibly distinct cabinet/control silhouettes. Pair with independent intact CRT art where useful. | Cabinet marquees, coin faces, attract screens, multiplayer interactions and redemption machines. |
| Bookstore | Sundown shelving, School Assets items whose scale reads as retail, and a suitable desk or counter. | Procedural books, sleeves, labels, section signs and placement rules. Avoid child-sized classroom fixtures in customer aisles. |
| Food court | Modular Burger Shop and Mixall appliances as primary sources. Use Fast Food Restaurant Kit and CoffeeShop Starter Pack where an appliance or fixture is missing. Use selective Adorable Foods, Bakery Object, KayKit and Kenney meshes after style review. | Unbranded 1998 food packaging, unified plastics/metal, historically consistent restaurant fronts and scale checks. |

## Later areas

- Search **Toilet Props Set**, Warehouse, Road Props, and industrial packs for fixtures, aisle racks, service carts, wayfinding hardware and maintenance props. Limit Advanced Foliage to indoor-compatible silhouettes.
- For payphones, inspect **Midnight Downtown** artwork and remove horror-specific scripts, lighting and weathering in title-owned copies. Use the existing CRT packs and **Vintage Computer Keyboard** for selected intact screens and peripherals.
- Treat **Super Level Optimizer 2** and **Perfect Culling** as optional benchmarks against native room visibility. Preserve dynamic shutters, authoritatively simulated item meshes and independent cameras. Scene streaming, tweening, weather and Sonity remain optional production evaluations. TidyCore's existing controller, sorting, progression, saves, companion, mixer and networking are the baseline.

## Selective export

1. In [the component directory](MALL_SWEET_MALL_COMPONENT_DIRECTORY.csv), filter by area and prefab name. Export the exact selected prefab via Unity or resolve the listed asset paths and same-name .meta files by GUID. Check Unity's recursive dependencies in the source context if the row flags unresolved GUIDs. For Sundown use its URP archive and [tested shelf and counter closure](SUNDOWN_URP_TRANSFER_CLOSURE.csv). Exclude demo scripts, settings, controllers and lighting profiles unless specifically required.
2. Reuse any dependency GUID already present in TidyCore. Bring over missing mesh, material, texture and shader files once, keeping their metadata. Check for same-path and different-GUID collisions before import.
3. In a TidyCore-authorized staging context, verify render and scale, colliders, missing scripts, and LOD and memory behavior. Add title interaction through TidyCore's own components. Keep vendor packages and restricted raw assets in licensed storage.

## Additional existing library options

- The owned **Ultimate Sound FX Bundle**, Asset Store 151756, has Cash register 1–5.wav under Assets/Ultimate SFX Bundle - HD Remaster/Ui & Item Sounds - HD Remake. Audition these for fiction-only point of sale sounds before sourcing another audio archive.
- The November 24 record also names **Low Poly Kitchen Furniture** by vUv. Ownership is recorded under exact title and publisher. Treat it as a fallback until its Unity ID, local package and material compatibility can be verified.
