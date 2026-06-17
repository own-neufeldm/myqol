using Microsoft.Xna.Framework;
using Terraria;
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
        default:
          ShowHelp();
          break;
      }
    }

    private static void ShowHelp()
    {
      Print("Usage: myqol <command> [args]", Color.Yellow);
      Print("help   Show this help message.");
    }

    private static void Print(string text, Color? color = null)
    {
      Main.NewText(text, color);
    }

    private static void Log(string level, string message, Color color)
    {
      Print($"[{level}] myqol: {message}", color);
    }

    private static void LogError(string message)
    {
      Log("ERROR", message, Color.OrangeRed);
    }

    private static void LogInfo(string message)
    {
      Log("INFO", message, Color.Green);
    }
  }
}