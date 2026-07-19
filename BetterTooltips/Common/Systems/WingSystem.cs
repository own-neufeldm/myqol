using System.Collections.Generic;
using BetterTooltips.Common.Stats;
using Terraria.ModLoader;

namespace BetterTooltips.Common.Systems
{
  public class WingSystem : ModSystem
  {
    public static Dictionary<int, WingStats> Cache { get; } = [];

    public override void PostSetupContent()
    {
      AddVanilla();
      AddCalamityMod();
      AddThoriumMod();
    }

    private static void AddVanilla()
    {
      Cache.Add(4978, new(0.42f, 18, 0.0f)); // Fledgling Wings
      Cache.Add(493, new(1.67f, 53, 0.0f)); // Angel Wings
      Cache.Add(492, new(1.67f, 53, 0.0f)); // Demon Wings
      Cache.Add(761, new(2.17f, 67, 0.0f)); // Fairy Wings
      Cache.Add(2494, new(2.17f, 67, 0.0f)); // Fin Wings
      Cache.Add(822, new(2.17f, 67, 0.0f)); // Frozen Wings
      Cache.Add(785, new(2.17f, 67, 0.0f)); // Harpy Wings
      Cache.Add(748, new(2.5f, 77, 0.0f)); // Jetpack
      Cache.Add(5627, new(2.5f, 77, 0.0f)); // Chippy's Cloak
      Cache.Add(5659, new(2.5f, 77, 0.0f)); // Heroicis' Wings
      Cache.Add(665, new(2.5f, 77, 0.0f)); // Red's Wings
      Cache.Add(1583, new(2.5f, 77, 0.0f)); // D-Town's Wings
      Cache.Add(1584, new(2.5f, 77, 0.0f)); // Will's Wings
      Cache.Add(1585, new(2.5f, 77, 0.0f)); // Crowno's Wings
      Cache.Add(1586, new(2.5f, 77, 0.0f)); // Cenx's Wings
      Cache.Add(3228, new(2.5f, 77, 0.0f)); // Lazure's Barrier Platform
      Cache.Add(3580, new(2.5f, 77, 0.0f)); // Yoraiz0r's Spell
      Cache.Add(3582, new(2.5f, 77, 0.0f)); // Jim's Wings
      Cache.Add(3588, new(2.5f, 77, 0.0f)); // Skiphs' Paws
      Cache.Add(3592, new(2.5f, 77, 0.0f)); // Loki's Wings
      Cache.Add(3924, new(2.5f, 77, 0.0f)); // Arkhalis' Lightwings
      Cache.Add(3928, new(2.5f, 77, 0.0f)); // Leinfors' Prehensile Cloak
      Cache.Add(4730, new(2.5f, 77, 0.0f)); // Ghostar's Infinity Eight
      Cache.Add(4746, new(2.5f, 77, 0.0f)); // Safeman's Blanket Cape
      Cache.Add(4750, new(2.5f, 77, 0.0f)); // FoodBarbarian's Tattered Dragon Wings
      Cache.Add(4754, new(2.5f, 77, 0.0f)); // Grox The Great's Wings
      Cache.Add(6140, new(2.5f, 77, 0.0f)); // Luna's Runic Pixie Wings
      Cache.Add(5686, new(2.5f, 77, 0.0f)); // Kazzymodus' Wings
      Cache.Add(5586, new(2.5f, 77, 0.0f)); // Chicken Bones' Wings
      Cache.Add(1162, new(2.67f, 81, 0.0f)); // Leaf Wings
      Cache.Add(1165, new(2.67f, 81, 0.0f)); // Bat Wings
      Cache.Add(1515, new(2.67f, 81, 0.0f)); // Bee Wings
      Cache.Add(749, new(2.67f, 81, 0.0f)); // Butterfly Wings
      Cache.Add(821, new(2.67f, 81, 0.0f)); // Flame Wings
      Cache.Add(1866, new(2.83f, 94, 0.0f)); // Hoverboard
      Cache.Add(786, new(2.83f, 94, 0.0f)); // Bone Wings
      Cache.Add(2770, new(2.83f, 94, 0.0f)); // Mothron Wings
      Cache.Add(823, new(2.83f, 94, 0.0f)); // Spectre Wings
      Cache.Add(2280, new(2.83f, 94, 0.0f)); // Beetle Wings
      Cache.Add(1871, new(3.0f, 107, 0.0f)); // Festive Wings
      Cache.Add(1830, new(3.0f, 107, 0.0f)); // Spooky Wings
      Cache.Add(1797, new(3.0f, 107, 0.0f)); // Tattered Fairy Wings
      Cache.Add(948, new(3.0f, 107, 0.0f)); // Steampunk Wings
      Cache.Add(3883, new(2.5f, 119, 1.5f)); // Betsy's Wings
      Cache.Add(4823, new(2.5f, 128, 1.0f)); // Empress Wings
      Cache.Add(2609, new(3.0f, 143, 1.0f)); // Fishron Wings
      Cache.Add(3470, new(3.0f, 143, 0.5f)); // Nebula Mantle
      Cache.Add(3469, new(3.0f, 143, 0.5f)); // Vortex Booster
      Cache.Add(3468, new(3.0f, 167, 1.5f)); // Solar Wings
      Cache.Add(3471, new(3.0f, 167, 1.5f)); // Stardust Wings
      Cache.Add(4954, new(3.0f, 201, 3.5f)); // Celestial Starboard
    }

    private static void AddCalamityMod()
    {
      if (!ModLoader.TryGetMod("CalamityMod", out Mod mod)) return;

      if (mod.TryFind("SkylineWings", out ModItem item)) // Skyline Wings
        Cache.Add(item.Type, new(1.33f, 60, 0.0f));
      if (mod.TryFind("StarlightWings", out item)) // Starlight Wings
        Cache.Add(item.Type, new(2.83f, 117, 0.5f));
      if (mod.TryFind("AureateBooster", out item)) // Aureate Booster
        Cache.Add(item.Type, new(2.0f, 128, 0.5f));
      if (mod.TryFind("HadarianWings", out item)) // Hadarian Wings
        Cache.Add(item.Type, new(1.8f, 100, 1.0f));
      if (mod.TryFind("HadalMantle", out item)) // Hadal Mantle
        Cache.Add(item.Type, new(2.17f, 108, 1.0f));
      if (mod.TryFind("ExodusWings", out item)) // Exodus Wings
        Cache.Add(item.Type, new(3.0f, 222, 1.5f));
      if (mod.TryFind("TarragonWings", out item)) // Tarragon Wings
        Cache.Add(item.Type, new(4.5f, 335, 1.5f));
      if (mod.TryFind("ElysianWings", out item)) // Elysian Wings
        Cache.Add(item.Type, new(4.0f, 305, 2.0f));
      if (mod.TryFind("SilvaWings", out item)) // Silva Wings
        Cache.Add(item.Type, new(4.5f, 359, 1.8f));
      if (mod.TryFind("WingsofRebirth", out item)) // Wings of Rebirth
        Cache.Add(item.Type, new(6.0f, 490, 1.9f));
      if (mod.TryFind("SoulofCryogen", out item)) // Soul of Cryogen
        Cache.Add(item.Type, new(2.67f, 111, 0.0f));
      if (mod.TryFind("MOAB", out item)) // MOAB
        Cache.Add(item.Type, new(1.25f, 159, 0.0f));
      if (mod.TryFind("MoonWalkers", out item)) // Moon Walkers
        Cache.Add(item.Type, new(2.67f, 170, 1.6f));
      if (mod.TryFind("VoidStriders", out item)) // Void Striders
        Cache.Add(item.Type, new(3.33f, 229, 1.7f));
      if (mod.TryFind("SeraphTracers", out item)) // Seraph Tracers
        Cache.Add(item.Type, new(4.17f, 308, 1.8f));
    }

    private static void AddThoriumMod()
    {
      if (!ModLoader.TryGetMod("ThoriumMod", out Mod mod)) return;

      if (mod.TryFind("ChampionsWings", out ModItem item)) // Champion's Wings
        Cache.Add(item.Type, new(1.0f, 34, 0.0f));
      if (mod.TryFind("DridersGrace", out item)) // Drider's Grace
        Cache.Add(item.Type, new(0.0f, 28, 0.0f));
      if (mod.TryFind("DragonsWings", out item)) // Dragon's Wings
        Cache.Add(item.Type, new(2.0f, 72, 1.33f));
      if (mod.TryFind("FleshWings", out item)) // Flesh Wings
        Cache.Add(item.Type, new(2.0f, 72, 1.33f));
      if (mod.TryFind("PhonicWings", out item)) // Phonic Wings
        Cache.Add(item.Type, new(2.0f, 77, 1.33f));
      if (mod.TryFind("TitanWings", out item)) // Titan Wings
        Cache.Add(item.Type, new(2.0f, 72, 1.33f));
      if (mod.TryFind("SubspaceWings", out item)) // Subspace Wings
        Cache.Add(item.Type, new(2.0f, 72, 1.33f));
      if (mod.TryFind("DreadWings", out item)) // Dread Wings
        Cache.Add(item.Type, new(2.0f, 72, 1.5f));
      if (mod.TryFind("DemonBloodWings", out item)) // Demon Blood Wings
        Cache.Add(item.Type, new(2.0f, 72, 1.5f));
      if (mod.TryFind("TerrariumWings", out item)) // Terrarium Wings
        Cache.Add(item.Type, new(3.0f, 187, 1.67f));
      if (mod.TryFind("ShootingStarTurboTuba", out item)) // Shooting Star Turbo Tuba
        Cache.Add(item.Type, new(2.0f, 151, 1.17f));
      if (mod.TryFind("CelestialCarrier", out item)) // Celestial Carrier
        Cache.Add(item.Type, new(2.0f, 151, 1.17f));
      if (mod.TryFind("WhiteDwarfThrusters", out item)) // White Dwarf Thrusters
        Cache.Add(item.Type, new(2.0f, 151, 2.33f));
    }
  }
}
