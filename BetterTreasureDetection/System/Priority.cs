using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BetterTreasureDetection.System
{
  public class Priority : ModSystem
  {
    public override void PostSetupContent()
    {
      Apply(ModContent.GetInstance<Configuration.Client.Vanilla>());
      Apply(ModContent.GetInstance<Configuration.Client.CalamityMod>());
    }

    public static void Apply(Configuration.Client.Vanilla config)
    {
      if (config == null) return;

      // Ores (pre-hardmode)
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

      // Ores (hardmode)
      Main.tileOreFinderPriority[TileID.Cobalt] = (short)config.CobaltOre;
      Main.tileOreFinderPriority[TileID.Palladium] = (short)config.PalladiumOre;
      Main.tileOreFinderPriority[TileID.Mythril] = (short)config.MythrilOre;
      Main.tileOreFinderPriority[TileID.Orichalcum] = (short)config.OrichalcumOre;
      Main.tileOreFinderPriority[TileID.Adamantite] = (short)config.AdamantiteOre;
      Main.tileOreFinderPriority[TileID.Titanium] = (short)config.TitaniumOre;
      Main.tileOreFinderPriority[TileID.Chlorophyte] = (short)config.ChlorophyteOre;

      // Treasures (pre-hardmode)
      Main.tileOreFinderPriority[TileID.Pots] = (short)config.Pot;
      Main.tileOreFinderPriority[TileID.Containers] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.Containers2] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.FakeContainers] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.FakeContainers2] = (short)config.Chest;
      Main.tileOreFinderPriority[TileID.Heart] = (short)config.LifeCrystal;
      Main.tileOreFinderPriority[TileID.LifeCrystalBoulder] = (short)config.LifeCrystal;
      Main.tileOreFinderPriority[TileID.ManaCrystal] = (short)config.ManaCrystal;
      Main.tileOreFinderPriority[TileID.DyePlants] = (short)config.StrangePlant;
      Main.tileOreFinderPriority[TileID.GlowTulip] = (short)config.GlowTulip;

      // Treasures (hardmode)
      Main.tileOreFinderPriority[TileID.Crystals] = (short)config.GelatinCrystal;
      Main.tileOreFinderPriority[TileID.LifeFruit] = (short)config.LifeFruit;
    }

    public static void Apply(Configuration.Client.CalamityMod config)
    {
      if (config == null || !ModLoader.TryGetMod("CalamityMod", out Mod mod)) return;

      // Ores (pre-hardmode)
      if (mod.TryFind("AerialiteOre", out ModTile aerialite)) Main.tileOreFinderPriority[aerialite.Type] = (short)config.AerialiteOre;
      
      // Ores (hardmode)
      if (mod.TryFind("CryonicOre", out ModTile cryonic)) Main.tileOreFinderPriority[cryonic.Type] = (short)config.CryonicOre;
      if (mod.TryFind("InfernalSuevite", out ModTile suevite)) Main.tileOreFinderPriority[suevite.Type] = (short)config.InfernalSuevite;
      if (mod.TryFind("HallowedOre", out ModTile hallowed)) Main.tileOreFinderPriority[hallowed.Type] = (short)config.HallowedOre;
      if (mod.TryFind("PerennialOre", out ModTile perennial)) Main.tileOreFinderPriority[perennial.Type] = (short)config.PerennialOre;
      if (mod.TryFind("ScoriaOre", out ModTile scoria)) Main.tileOreFinderPriority[scoria.Type] = (short)config.ScoriaOre;
      if (mod.TryFind("AstralOre", out ModTile astral)) Main.tileOreFinderPriority[astral.Type] = (short)config.AstralOre;
      
      // Ores (post-moonlord)
      if (mod.TryFind("ExodiumOre", out ModTile exodium)) Main.tileOreFinderPriority[exodium.Type] = (short)config.ExodiumOre;
      Main.tileOreFinderPriority[TileID.LunarOre] = (short)config.LunarOre;
      if (mod.TryFind("UelibloomOre", out ModTile uelibloom)) Main.tileOreFinderPriority[uelibloom.Type] = (short)config.UelibloomOre;
      if (mod.TryFind("AuricOre", out ModTile auric)) Main.tileOreFinderPriority[auric.Type] = (short)config.AuricOre;

      // Treasures
      if (mod.TryFind("AbyssalPots", out ModTile abyssalPots)) Main.tileOreFinderPriority[abyssalPots.Type] = (short)config.Pot;
      if (mod.TryFind("SulphurousPots", out ModTile sulphurousPots)) Main.tileOreFinderPriority[sulphurousPots.Type] = (short)config.Pot;
      if (mod.TryFind("AbyssChest", out ModTile abyssChest)) Main.tileOreFinderPriority[abyssChest.Type] = (short)config.Chest;
      if (mod.TryFind("AbyssTreasureChest", out ModTile abyssTreasureChest)) Main.tileOreFinderPriority[abyssTreasureChest.Type] = (short)config.Chest;
      if (mod.TryFind("AcidwoodChestTile", out ModTile acidwoodChestTile)) Main.tileOreFinderPriority[acidwoodChestTile.Type] = (short)config.Chest;
      if (mod.TryFind("AgedSecurityChestTile", out ModTile agedSecurityChestTile)) Main.tileOreFinderPriority[agedSecurityChestTile.Type] = (short)config.Chest;
      if (mod.TryFind("AncientNavystoneChest", out ModTile ancientNavystoneChest)) Main.tileOreFinderPriority[ancientNavystoneChest.Type] = (short)config.Chest;
      if (mod.TryFind("AnodizedWulfrumChest", out ModTile anodizedWulfrumChest)) Main.tileOreFinderPriority[anodizedWulfrumChest.Type] = (short)config.Chest;
      if (mod.TryFind("AshenChest", out ModTile ashenChest)) Main.tileOreFinderPriority[ashenChest.Type] = (short)config.Chest;
      if (mod.TryFind("AstralChestLocked", out ModTile astralChestLocked)) Main.tileOreFinderPriority[astralChestLocked.Type] = (short)config.Chest;
      if (mod.TryFind("BotanicChest", out ModTile botanicChest)) Main.tileOreFinderPriority[botanicChest.Type] = (short)config.Chest;
      if (mod.TryFind("CosmiliteChest", out ModTile cosmiliteChest)) Main.tileOreFinderPriority[cosmiliteChest.Type] = (short)config.Chest;
      if (mod.TryFind("DriftwoodChest", out ModTile driftwoodChest)) Main.tileOreFinderPriority[driftwoodChest.Type] = (short)config.Chest;
      if (mod.TryFind("ExoChestTile", out ModTile exoChestTile)) Main.tileOreFinderPriority[exoChestTile.Type] = (short)config.Chest;
      if (mod.TryFind("MarniteChest", out ModTile marniteChest)) Main.tileOreFinderPriority[marniteChest.Type] = (short)config.Chest;
      if (mod.TryFind("MonolithChest", out ModTile monolithChest)) Main.tileOreFinderPriority[monolithChest.Type] = (short)config.Chest;
      if (mod.TryFind("NavystoneChest", out ModTile navystoneChest)) Main.tileOreFinderPriority[navystoneChest.Type] = (short)config.Chest;
      if (mod.TryFind("OtherworldlyChest", out ModTile otherworldlyChest)) Main.tileOreFinderPriority[otherworldlyChest.Type] = (short)config.Chest;
      if (mod.TryFind("PlaguedPlateChest", out ModTile plaguedPlateChest)) Main.tileOreFinderPriority[plaguedPlateChest.Type] = (short)config.Chest;
      if (mod.TryFind("ProfanedChest", out ModTile profanedChest)) Main.tileOreFinderPriority[profanedChest.Type] = (short)config.Chest;
      if (mod.TryFind("RustyChestTile", out ModTile rustyChestTile)) Main.tileOreFinderPriority[rustyChestTile.Type] = (short)config.Chest;
      if (mod.TryFind("SacrilegiousChestTile", out ModTile sacrilegiousChestTile)) Main.tileOreFinderPriority[sacrilegiousChestTile.Type] = (short)config.Chest;
      if (mod.TryFind("SecurityChestTile", out ModTile securityChestTile)) Main.tileOreFinderPriority[securityChestTile.Type] = (short)config.Chest;
      if (mod.TryFind("SilvaChest", out ModTile silvaChest)) Main.tileOreFinderPriority[silvaChest.Type] = (short)config.Chest;
      if (mod.TryFind("StatigelChest", out ModTile statigelChest)) Main.tileOreFinderPriority[statigelChest.Type] = (short)config.Chest;
      if (mod.TryFind("StratusChest", out ModTile stratusChest)) Main.tileOreFinderPriority[stratusChest.Type] = (short)config.Chest;
      if (mod.TryFind("VoidChest", out ModTile voidChest)) Main.tileOreFinderPriority[voidChest.Type] = (short)config.Chest;
      if (mod.TryFind("IronBallPlaced", out ModTile ironBall)) Main.tileOreFinderPriority[ironBall.Type] = (short)config.IronBall;
      if (mod.TryFind("RoxTile", out ModTile rox)) Main.tileOreFinderPriority[rox.Type] = (short)config.Roxcalibur;
    }
  }
}
