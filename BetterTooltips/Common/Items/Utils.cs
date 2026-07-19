using System.Numerics;
using Terraria;

namespace BetterTooltips.Common.Items
{
  public static class Utils
  {
    public static bool IsHoveringSocialSlot()
    {
      return Main.HoverItem.social;
    }

    public static string GetComparisonText(float hoveredValue, float equippedValue)
    {
      return $"[c/{GetComparisonColorHex(hoveredValue, equippedValue)}:{equippedValue:0.##}]";
    }

    public static string GetComparisonColorHex<T>(T hoveredValue, T equippedValue)
      where T : IComparisonOperators<T, T, bool>
    {
      if (hoveredValue < equippedValue) return "FF0000"; // red
      if (hoveredValue > equippedValue) return "00FF00"; // green
      return "FFFF00";                                   // yellow
    }
  }
}
