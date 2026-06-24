using System.ComponentModel;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace BetterMetalDetector
{
  public class BetterMetalDetector : Mod { }

  public class System : ModSystem
  {
    public override void PostSetupContent()
    {
      ApplyCustomPriorities(ModContent.GetInstance<Config>());
    }

    public static void ApplyCustomPriorities(Config config)
    {
      if (config == null) return;
      Main.tileOreFinderPriority[TileID.Adamantite] = (short)config.AdamantiteOre;
      Main.tileOreFinderPriority[TileID.Chlorophyte] = (short)config.ChlorophyteOre;
      Main.tileOreFinderPriority[TileID.Cobalt] = (short)config.CobaltOre;
      Main.tileOreFinderPriority[TileID.Containers] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.Containers2] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.Copper] = (short)config.CopperOre;
      Main.tileOreFinderPriority[TileID.Crimtane] = (short)config.CrimtaneOre;
      Main.tileOreFinderPriority[TileID.Crystals] = (short)config.GelatinCrystal;
      Main.tileOreFinderPriority[TileID.Demonite] = (short)config.DemoniteOre;
      Main.tileOreFinderPriority[TileID.DesertFossil] = (short)config.FossilOre;
      Main.tileOreFinderPriority[TileID.DyePlants] = (short)config.StrangePlant;
      Main.tileOreFinderPriority[TileID.FakeContainers] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.FakeContainers2] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.FossilOre] = (short)config.FossilOre;
      Main.tileOreFinderPriority[TileID.GlowTulip] = (short)config.GlowTulip;
      Main.tileOreFinderPriority[TileID.Gold] = (short)config.GoldOre;
      Main.tileOreFinderPriority[TileID.Heart] = (short)config.LifeCrystal;
      Main.tileOreFinderPriority[TileID.Iron] = (short)config.IronOre;
      Main.tileOreFinderPriority[TileID.Lead] = (short)config.LeadOre;
      Main.tileOreFinderPriority[TileID.LifeCrystalBoulder] = (short)config.LifeCrystal;
      Main.tileOreFinderPriority[TileID.LifeFruit] = (short)config.LifeFruit;
      Main.tileOreFinderPriority[TileID.ManaCrystal] = (short)config.ManaCrystal;
      Main.tileOreFinderPriority[TileID.Meteorite] = (short)config.MeteoriteOre;
      Main.tileOreFinderPriority[TileID.Mythril] = (short)config.MythrilOre;
      Main.tileOreFinderPriority[TileID.Orichalcum] = (short)config.OrichalcumOre;
      Main.tileOreFinderPriority[TileID.Palladium] = (short)config.PalladiumOre;
      Main.tileOreFinderPriority[TileID.Platinum] = (short)config.PlatinumOre;
      Main.tileOreFinderPriority[TileID.Pots] = (short)config.Pot;
      Main.tileOreFinderPriority[TileID.Silver] = (short)config.SilverOre;
      Main.tileOreFinderPriority[TileID.Tin] = (short)config.TinOre;
      Main.tileOreFinderPriority[TileID.Titanium] = (short)config.TitaniumOre;
      Main.tileOreFinderPriority[TileID.Tungsten] = (short)config.TungstenOre;
    }
  }

  public class Config : ModConfig
  {
    public override ConfigScope Mode => ConfigScope.ClientSide;

    // Main.tileOreFinderPriority[TileID.Adamantite] = 640;
    // Main.tileOreFinderPriority[TileID.Chlorophyte] = 700;
    // Main.tileOreFinderPriority[TileID.Cobalt] = 600;
    // Main.tileOreFinderPriority[TileID.Containers] = 500;
    // Main.tileOreFinderPriority[TileID.Containers2] = 500;
    // Main.tileOreFinderPriority[TileID.Copper] = 200;
    // Main.tileOreFinderPriority[TileID.Crimtane] = 310;
    // Main.tileOreFinderPriority[TileID.Crystals] = 675;
    // Main.tileOreFinderPriority[TileID.Demonite] = 300;
    // Main.tileOreFinderPriority[TileID.DesertFossil] = 150;
    // Main.tileOreFinderPriority[TileID.DyePlants] = 750;
    // Main.tileOreFinderPriority[TileID.FakeContainers] = 500;
    // Main.tileOreFinderPriority[TileID.FakeContainers2] = 500;
    // Main.tileOreFinderPriority[TileID.FossilOre] = 150;
    // Main.tileOreFinderPriority[TileID.GlowTulip] = 760;
    // Main.tileOreFinderPriority[TileID.Gold] = 260;
    // Main.tileOreFinderPriority[TileID.Heart] = 550;
    // Main.tileOreFinderPriority[TileID.Iron] = 220;
    // Main.tileOreFinderPriority[TileID.Lead] = 230;
    // Main.tileOreFinderPriority[TileID.LifeCrystalBoulder] = 550;
    // Main.tileOreFinderPriority[TileID.LifeFruit] = 810;
    // Main.tileOreFinderPriority[TileID.ManaCrystal] = 550;
    // Main.tileOreFinderPriority[TileID.Meteorite] = 400;
    // Main.tileOreFinderPriority[TileID.Mythril] = 620;
    // Main.tileOreFinderPriority[TileID.Orichalcum] = 630;
    // Main.tileOreFinderPriority[TileID.Palladium] = 610;
    // Main.tileOreFinderPriority[TileID.Platinum] = 270;
    // Main.tileOreFinderPriority[TileID.Pots] = 100;
    // Main.tileOreFinderPriority[TileID.Silver] = 240;
    // Main.tileOreFinderPriority[TileID.Tin] = 210;
    // Main.tileOreFinderPriority[TileID.Titanium] = 650;
    // Main.tileOreFinderPriority[TileID.Tungsten] = 250;

    [DefaultValue(640)]
    [Range(0, 32000)]
    public int AdamantiteOre;

    [DefaultValue(500)]
    [Range(0, 32000)]
    public int Chest; // Containers, Containers2, FakeContainers, FakeContainers2

    [DefaultValue(700)]
    [Range(0, 32000)]
    public int ChlorophyteOre;

    [DefaultValue(600)]
    [Range(0, 32000)]
    public int CobaltOre;

    [DefaultValue(200)]
    [Range(0, 32000)]
    public int CopperOre;

    [DefaultValue(310)]
    [Range(0, 32000)]
    public int CrimtaneOre;

    [DefaultValue(300)]
    [Range(0, 32000)]
    public int DemoniteOre;

    [DefaultValue(150)]
    [Range(0, 32000)]
    public int FossilOre;

    [DefaultValue(675)]
    [Range(0, 32000)]
    public int GelatinCrystal;

    [DefaultValue(760)]
    [Range(0, 32000)]
    public int GlowTulip;

    [DefaultValue(260)]
    [Range(0, 32000)]
    public int GoldOre;

    [DefaultValue(220)]
    [Range(0, 32000)]
    public int IronOre;

    [DefaultValue(230)]
    [Range(0, 32000)]
    public int LeadOre;

    [DefaultValue(550)]
    [Range(0, 32000)]
    public int LifeCrystal; // Heart, LifeCrystalBoulder

    [DefaultValue(810)]
    [Range(0, 32000)]
    public int LifeFruit;

    [DefaultValue(550)]
    [Range(0, 32000)]
    public int ManaCrystal;

    [DefaultValue(400)]
    [Range(0, 32000)]
    public int MeteoriteOre;

    [DefaultValue(620)]
    [Range(0, 32000)]
    public int MythrilOre;

    [DefaultValue(630)]
    [Range(0, 32000)]
    public int OrichalcumOre;

    [DefaultValue(610)]
    [Range(0, 32000)]
    public int PalladiumOre;

    [DefaultValue(270)]
    [Range(0, 32000)]
    public int PlatinumOre;

    [DefaultValue(100)]
    [Range(0, 32000)]
    public int Pot;

    [DefaultValue(240)]
    [Range(0, 32000)]
    public int SilverOre;

    [DefaultValue(750)]
    [Range(0, 32000)]
    public int StrangePlant;

    [DefaultValue(210)]
    [Range(0, 32000)]
    public int TinOre;

    [DefaultValue(650)]
    [Range(0, 32000)]
    public int TitaniumOre;

    [DefaultValue(250)]
    [Range(0, 32000)]
    public int TungstenOre;

    public override void OnChanged()
    {
      System.ApplyCustomPriorities(this);
    }
  }
}
