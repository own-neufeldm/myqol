using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Terraria.Audio;
using Terraria.ModLoader.Config;

namespace MemeSounds.Common.Configs
{
  public class MemeSoundsClientConfig : ModConfig
  {
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [JsonIgnore]
    public List<SoundStyle> DeathSounds { get; } = [];
    [Header("DeathSounds")]

    [SoundName("Ack")]
    [OnEvent(MemeSoundsEvent.Death)]
    [DefaultValue(true)]
    public bool Ack;

    [SoundName("FortniteKnocked")]
    [OnEvent(MemeSoundsEvent.Death)]
    [DefaultValue(true)]
    public bool FortniteKnocked;

    [SoundName("MetalPipe")]
    [OnEvent(MemeSoundsEvent.Death)]
    [DefaultValue(true)]
    public bool MetalPipe;

    [SoundName("ReverbFart")]
    [OnEvent(MemeSoundsEvent.Death)]
    [DefaultValue(true)]
    public bool ReverbFart;

    [SoundName("TheUndertakerBell")]
    [OnEvent(MemeSoundsEvent.Death)]
    [DefaultValue(true)]
    public bool TheUndertakerBell;

    [SoundName("WindowsXPShutdown")]
    [OnEvent(MemeSoundsEvent.Death)]
    [DefaultValue(true)]
    public bool WindowsXPShutdown;

    [JsonIgnore]
    public List<SoundStyle> SpawnSounds { get; } = [];
    [Header("SpawnSounds")]

    [SoundName("WindowsXPStartup")]
    [OnEvent(MemeSoundsEvent.Spawn)]
    [DefaultValue(true)]
    public bool WindowsXPStartup;

    public override void OnChanged()
    {
      DeathSounds.Clear();
      SpawnSounds.Clear();

      foreach (var field in GetType().GetFields())
      {
        if (Attribute.GetCustomAttribute(field, typeof(SoundNameAttribute)) is not SoundNameAttribute soundName)
          continue;
        if (Attribute.GetCustomAttribute(field, typeof(OnEventAttribute)) is not OnEventAttribute onEvent)
          continue;
        if (!(bool)field.GetValue(this))
          continue;

        SoundStyle sound = new($"MemeSounds/Assets/Sounds/{soundName.Value}");
        if (onEvent.Value == MemeSoundsEvent.Death) DeathSounds.Add(sound);
        if (onEvent.Value == MemeSoundsEvent.Spawn) SpawnSounds.Add(sound);
      }
    }
  }
}
