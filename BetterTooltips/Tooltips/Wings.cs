using System.Collections.Generic;
using System.Numerics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace BetterTooltips.Tooltips
{
  public class Wings : GlobalItem
  {
    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
      if (!IsWing(item) || Utils.IsHoveringSocialSlot()) return;

      Player player = Main.LocalPlayer;
      WingStats hoveredStats = player.GetWingStats(item.wingSlot);

      WingStats? equippedStats =
        player.equippedWings != null && player.equippedWings.type != item.type
        ? player.GetWingStats(player.equippedWings.wingSlot)
        : null;

      tooltips.Add(GetFlightTimeLine(hoveredStats, equippedStats));
      tooltips.Add(GetHorizontalAccelerationLine(hoveredStats, equippedStats));
    }

    private static bool IsWing(Item item)
    {
      return item.wingSlot > 0;
    }

    private static float GetFlightTimeInSeconds(WingStats stats)
    {
      return stats.FlyTime / 60f;
    }

    private static int GetHorizontalAccelerationBonusInPercent(WingStats stats)
    {
      return (int)((stats.AccRunAccelerationMult - 1f) * 100);
    }

    private TooltipLine GetFlightTimeLine(WingStats hoveredStats, WingStats? equippedStats)
    {
      float hoveredValue = GetFlightTimeInSeconds(hoveredStats);
      string text = $"Flight time: {hoveredValue:0.##} seconds";

      if (equippedStats.HasValue)
      {
        float equippedValue = GetFlightTimeInSeconds(equippedStats.Value);
        text += $" ({Utils.GetComparisonText(hoveredValue, equippedValue)})";
      }

      return new TooltipLine(Mod, "WingFlightTime", text);
    }

    private TooltipLine GetHorizontalAccelerationLine(WingStats hoveredStats, WingStats? equippedStats)
    {
      float hoveredValue = GetHorizontalAccelerationBonusInPercent(hoveredStats);
      string text = $"Horizontal acceleration: +{hoveredValue}%";

      if (equippedStats.HasValue)
      {
        float equippedValue = GetHorizontalAccelerationBonusInPercent(equippedStats.Value);
        text += $" ({Utils.GetComparisonText(hoveredValue, equippedValue)})";
      }

      return new TooltipLine(Mod, "WingHorizontalAcceleration", text);
    }
  }

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
