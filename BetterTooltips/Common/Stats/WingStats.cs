namespace BetterTooltips.Common.Stats
{
  public class WingStats(float flightTime, int height, float speedBonus)
  {
    public float FlightTime = flightTime;
    public int Height = height;
    public float SpeedBonus = speedBonus;
    public static WingStats Empty() => new(0.0f, 0, 0.0f);
  }
}
