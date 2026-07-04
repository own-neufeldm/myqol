using System;
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

      // Ores
      Main.tileOreFinderPriority[TileID.DesertFossil] = (short)config.FossilOre;
      Main.tileOreFinderPriority[TileID.FossilOre] = (short)config.FossilOre;
      Main.tileOreFinderPriority[TileID.Copper] = (short)config.CopperOre;
      Main.tileOreFinderPriority[TileID.Tin] = (short)config.TinOre;
      Main.tileOreFinderPriority[TileID.Iron] = (short)config.IronOre;
      Main.tileOreFinderPriority[TileID.Lead] = (short)config.LeadOre;
      Main.tileOreFinderPriority[TileID.Silver] = (short)config.SilverOre;
      Main.tileOreFinderPriority[TileID.Tungsten] = (short)config.TungstenOre;
      Main.tileOreFinderPriority[TileID.Gold] = (short)config.GoldOre;
      Main.tileOreFinderPriority[TileID.Platinum] = (short)config.PlatinumOre;
      Main.tileOreFinderPriority[TileID.Demonite] = (short)config.DemoniteOre;
      Main.tileOreFinderPriority[TileID.Crimtane] = (short)config.CrimtaneOre;
      Main.tileOreFinderPriority[TileID.Meteorite] = (short)config.MeteoriteOre;
      Main.tileOreFinderPriority[TileID.Cobalt] = (short)config.CobaltOre;
      Main.tileOreFinderPriority[TileID.Palladium] = (short)config.PalladiumOre;
      Main.tileOreFinderPriority[TileID.Mythril] = (short)config.MythrilOre;
      Main.tileOreFinderPriority[TileID.Orichalcum] = (short)config.OrichalcumOre;
      Main.tileOreFinderPriority[TileID.Adamantite] = (short)config.AdamantiteOre;
      Main.tileOreFinderPriority[TileID.Titanium] = (short)config.TitaniumOre;
      Main.tileOreFinderPriority[TileID.Chlorophyte] = (short)config.ChlorophyteOre;

      // Treasures
      Main.tileOreFinderPriority[TileID.Pots] = (short)config.Pot;
      Main.tileOreFinderPriority[TileID.Containers] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.Containers2] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.FakeContainers] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.FakeContainers2] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.Heart] = (short)config.LifeCrystal;
      Main.tileOreFinderPriority[TileID.LifeCrystalBoulder] = (short)config.LifeCrystal;
      Main.tileOreFinderPriority[TileID.ManaCrystal] = (short)config.ManaCrystal;
      Main.tileOreFinderPriority[TileID.Crystals] = (short)config.GelatinCrystal;
      Main.tileOreFinderPriority[TileID.DyePlants] = (short)config.StrangePlant;
      Main.tileOreFinderPriority[TileID.GlowTulip] = (short)config.GlowTulip;
      Main.tileOreFinderPriority[TileID.LifeFruit] = (short)config.LifeFruit;
    }
  }

  public class Config : ModConfig
  {
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [Header("Ores")]

    [DefaultValue(150)]
    [Range(0, 2000)]
    public int FossilOre;

    [DefaultValue(200)]
    [Range(0, 2000)]
    public int CopperOre;

    [DefaultValue(210)]
    [Range(0, 2000)]
    public int TinOre;

    [DefaultValue(220)]
    [Range(0, 2000)]
    public int IronOre;

    [DefaultValue(230)]
    [Range(0, 2000)]
    public int LeadOre;

    [DefaultValue(240)]
    [Range(0, 2000)]
    public int SilverOre;

    [DefaultValue(250)]
    [Range(0, 2000)]
    public int TungstenOre;

    [DefaultValue(260)]
    [Range(0, 2000)]
    public int GoldOre;

    [DefaultValue(270)]
    [Range(0, 2000)]
    public int PlatinumOre;

    [DefaultValue(300)]
    [Range(0, 2000)]
    public int DemoniteOre;

    [DefaultValue(310)]
    [Range(0, 2000)]
    public int CrimtaneOre;

    [DefaultValue(400)]
    [Range(0, 2000)]
    public int MeteoriteOre;

    [DefaultValue(600)]
    [Range(0, 2000)]
    public int CobaltOre;

    [DefaultValue(610)]
    [Range(0, 2000)]
    public int PalladiumOre;

    [DefaultValue(620)]
    [Range(0, 2000)]
    public int MythrilOre;

    [DefaultValue(630)]
    [Range(0, 2000)]
    public int OrichalcumOre;

    [DefaultValue(640)]
    [Range(0, 2000)]
    public int AdamantiteOre;

    [DefaultValue(650)]
    [Range(0, 2000)]
    public int TitaniumOre;

    [DefaultValue(700)]
    [Range(0, 2000)]
    public int ChlorophyteOre;

    [Header("Treasures")]

    [DefaultValue(100)]
    [Range(0, 2000)]
    public int Pot;

    [DefaultValue(500)]
    [Range(0, 2000)]
    public int Chest;

    [DefaultValue(550)]
    [Range(0, 2000)]
    public int LifeCrystal;

    [DefaultValue(550)]
    [Range(0, 2000)]
    public int ManaCrystal;

    [DefaultValue(675)]
    [Range(0, 2000)]
    public int GelatinCrystal;

    [DefaultValue(750)]
    [Range(0, 2000)]
    public int StrangePlant;

    [DefaultValue(760)]
    [Range(0, 2000)]
    public int GlowTulip;

    [DefaultValue(810)]
    [Range(0, 2000)]
    public int LifeFruit;

    public override void OnChanged()
    {
      System.ApplyCustomPriorities(this);
    }
  }
}
