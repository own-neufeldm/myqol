using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace MyQualityOfLife
{
  public class MyQualityOfLife : Mod { }

  public class ChatCommand : ModCommand
  {
    public override string Command => "myqol";
    public override CommandType Type => CommandType.Chat;
    public override string Description => "A command-line tool for quality of life features.";

    public override void Action(CommandCaller caller, string input, string[] args)
    {
      if (args.Length == 0)
      {
        ShowHelp();
        return;
      }

      switch (args[0])
      {
        case "angler":
          Main.AnglerQuestSwap();
          break;

        case "freeze":
          var power = CreativePowerManager.Instance.GetPower<CreativePowers.FreezeTime>();
          power.SetPowerInfo(!power.Enabled);
          break;

        default:
          Print("Unknown command.", Color.OrangeRed);
          break;
      }
    }

    private static void ShowHelp()
    {
      Print("Usage: myqol <command>", Color.Yellow);
      Print("angler   Reset the angler quest.");
      Print("freeze   Freeze or unfreeze time.");
    }

    private static void Print(string text, Color? color = null)
    {
      Main.NewText(text, color);
    }
  }
}