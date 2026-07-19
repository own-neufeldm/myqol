using System.Collections.Generic;
using MemeSounds.Common.Configs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MemeSounds.Common.Players
{
  public class MemeSoundsPlayer : ModPlayer
  {
    public override void Kill(
      double damage,
      int hitDirection,
      bool pvp,
      PlayerDeathReason damageSource
    )
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.DeathSounds, LastPosition(Player));
    }

    public override void PlayerDisconnect()
    {
      if (Main.myPlayer == Player.whoAmI) return;
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.DeathSounds, LastPosition(Player));
    }

    public override void PreSavePlayer()
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.DeathSounds, LastPosition(Player));
    }

    public override void OnEnterWorld()
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.SpawnSounds, SpawnPosition(Player));
    }

    public override void OnRespawn()
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.SpawnSounds, SpawnPosition(Player));
    }

    public override void PlayerConnect()
    {
      if (Main.myPlayer == Player.whoAmI) return;
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.SpawnSounds, SpawnPosition(Player));
    }

    public static Vector2 LastPosition(Player player)
    {
      return player.Center;
    }

    public static Vector2 SpawnPosition(Player player)
    {
      var x = player.SpawnX != -1 ? player.SpawnX : Main.spawnTileX;
      var y = player.SpawnX != -1 ? player.SpawnY : Main.spawnTileY;
      return new Point(x, y).ToWorldCoordinates();
    }

    public static void PlayRandomSound(List<SoundStyle> sounds, Vector2 position)
    {
      if (sounds.Count == 0) return;
      var sound = sounds[Main.rand.Next(sounds.Count)];
      SoundEngine.PlaySound(sound, position);
    }
  }
}
