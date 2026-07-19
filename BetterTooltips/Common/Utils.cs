using System.Numerics;
using Terraria;
using Terraria.ModLoader;

namespace BetterTooltips.Common
{
  public static class Utils
  {
    public static bool IsHoveringSocialSlot()
    {
      return Main.HoverItem.social;
    }

    public static string GetComparisonText(float hovered, float equipped)
    {
      return $"[c/{GetComparisonColorHex(hovered, equipped)}:{equipped:0.##}]";
    }

    public static string GetComparisonColorHex<T>(T hovered, T equipped)
      where T : IComparisonOperators<T, T, bool>
    {
      if (hovered < equipped) return "FF0000"; // red
      if (hovered > equipped) return "00FF00"; // green
      return "FFFF00";                         // yellow
    }

    public static ModItem FindItemByDisplayName(Mod mod, string name)
    {
      foreach (ILoadable loadable in mod.GetContent())
      {
        if (loadable is not ModItem item) continue;
        if (item.DisplayName.ToString().Equals(name)) return item;
      }
      throw new System.Exception($"Unable to find '{name}' item.");
    }
  }
}
