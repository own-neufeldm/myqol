using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Terraria.Audio;
using Terraria.ModLoader.Config;

namespace MemeSounds.Configuration
{
  public class Client : ModConfig
  {
    public override ConfigScope Mode => ConfigScope.ClientSide;

    [JsonIgnore]
    public List<SoundStyle> DeathSounds { get; } = [];

    [JsonIgnore]
    public List<SoundStyle> SpawnSounds { get; } = [];

    [Header("DeathSounds")]

    [SoundName("Ack")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool Ack;

    [SoundName("Amogus")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool Amogus;

    [SoundName("AmongUsRoleReveal")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool AmongUsRoleReveal;

    [SoundName("AnimeWow")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool AnimeWow;

    [SoundName("CatLaugh")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool CatLaugh;

    [SoundName("Fah")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool Fah;

    [SoundName("MetalPipeClang")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool MetalPipeClang;

    [SoundName("ReverbFart")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool ReverbFart;

    [SoundName("SadViolin")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool SadViolin;

    [SoundName("SpongebobFail")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool SpongebobFail;

    [SoundName("TheUndertakerBell")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool TheUndertakerBell;

    [SoundName("VineBoom")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool VineBoom;

    [SoundName("WindowsXPError")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool WindowsXPError;

    [SoundName("WindowsXPShutdown")]
    [OnEvent(Event.Death)]
    [DefaultValue(true)]
    public bool WindowsXPShutdown;

    [Header("SpawnSounds")]

    [SoundName("WindowsXPStartup")]
    [OnEvent(Event.Spawn)]
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

        SoundStyle sound = new($"MemeSounds/Sounds/{soundName.Value}");
        if (onEvent.Value == Event.Death) DeathSounds.Add(sound);
        if (onEvent.Value == Event.Spawn) SpawnSounds.Add(sound);
      }
    }
  }
}
