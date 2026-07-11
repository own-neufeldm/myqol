using System;

namespace MemeSounds.Common
{
  public enum MemeSoundsEvent
  {
    Death,
    Spawn,
  }

  [AttributeUsage(AttributeTargets.Field)]
  public class OnEventAttribute(MemeSoundsEvent value) : Attribute
  {
    public MemeSoundsEvent Value { get; } = value;
  }

  [AttributeUsage(AttributeTargets.Field)]
  public class SoundNameAttribute(string value) : Attribute
  {
    public string Value { get; } = value;
  }
}
