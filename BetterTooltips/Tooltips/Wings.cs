using System.Collections.Generic;
using System.Numerics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace BetterTooltips.Tooltips
{
  public class Wings : GlobalItem
  {
    // todo: abstract
    private static bool IsTarget(Item item)
    {
      return item.wingSlot > 0;
    }

    // todo: abstract
    private static bool PlayerIsHoveringSocialSlot()
    {
      return Main.HoverItem.social;
    }

    // todo: abstract
    private static string GetComparisonText(float hoveredValue, float equippedValue)
    {
      return $"[c/{GetComparisonColorHex(hoveredValue, equippedValue)}:{equippedValue:0.##}]";
    }

    // todo: abstract
    private static string GetComparisonColorHex<T>(T hoveredValue, T equippedValue)
      where T : IComparisonOperators<T, T, bool>
    {
      if (hoveredValue < equippedValue) return "FF0000"; // red
      if (hoveredValue > equippedValue) return "00FF00"; // green
      return "FFFF00";                                   // yellow
    }

    public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
    {
      if (!IsTarget(item) || PlayerIsHoveringSocialSlot()) return;

      var player = Main.LocalPlayer;
      var hoveredStats = player.GetWingStats(item.wingSlot);

      WingStats? equippedStats =
        player.equippedWings != null && player.equippedWings.type != item.type
        ? player.GetWingStats(player.equippedWings.wingSlot)
        : null;

      tooltips.Add(GetFlightTimeLine(hoveredStats, equippedStats));
      tooltips.Add(GetHorizontalAccelerationLine(hoveredStats, equippedStats));
    }

    private TooltipLine GetFlightTimeLine(WingStats hoveredStats, WingStats? equippedStats)
    {
      float hoveredValue = GetFlightTimeInSeconds(hoveredStats);
      string text = $"Flight time: {hoveredValue:0.##} seconds";
      if (equippedStats != null)
      {
        float equippedValue = GetFlightTimeInSeconds((WingStats)equippedStats);
        text += $" ({GetComparisonText(hoveredValue, equippedValue)})";
      }
      return new(Mod, "WingFlightTime", text);
    }

    private TooltipLine GetHorizontalAccelerationLine(WingStats hoveredStats, WingStats? equippedStats)
    {
      float hoveredValue = GetHorizontalAccelerationInPercent(hoveredStats);
      string text = $"Horizontal acceleration: +{hoveredValue}%";
      if (equippedStats != null)
      {
        float equippedValue = GetHorizontalAccelerationInPercent((WingStats)equippedStats);
        text += $" ({GetComparisonText(hoveredValue, equippedValue)})";
      }
      return new(Mod, "WingHorizontalAcceleration", text);
    }

    private static float GetFlightTimeInSeconds(WingStats stats)
    {
      return stats.FlyTime / 60f;
    }

    private static int GetHorizontalAccelerationInPercent(WingStats stats)
    {
      return (int)(stats.AccRunAccelerationMult - 1f) * 100;
    }
  }
}