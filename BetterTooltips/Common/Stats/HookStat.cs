namespace BetterTooltips.Common.Stats
{
  public class HookStat(int reach, int velocity, int hooks)
  {
    public int Reach = reach;
    public int Velocity = velocity;
    public int Hooks = hooks;
    public static HookStat Empty() => new(0, 0, 0);
  }
}
