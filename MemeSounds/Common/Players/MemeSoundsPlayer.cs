using System.Collections.Generic;
using MemeSounds.Common.Configs;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MemeSounds.Common.Players
{
  public class MemeSoundsPlayer : ModPlayer
  {
    public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.DeathSounds);
    }

    public override void OnEnterWorld()
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.SpawnSounds);
    }

    public override void OnRespawn()
    {
      var config = ModContent.GetInstance<MemeSoundsClientConfig>();
      PlayRandomSound(config.SpawnSounds);
    }

    public static void PlayRandomSound(List<SoundStyle> sounds)
    {
      if (sounds.Count == 0) return;
      var sound = sounds[Main.rand.Next(sounds.Count)];
      SoundEngine.PlaySound(sound);
    }
  }
}
