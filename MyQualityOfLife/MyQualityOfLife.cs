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
        case "freeze":
          ToggleTimeFreeze();
          break;

        case "quest":
          RotateAnglerQuest();
          break;

        default:
          Print("Unknown command.", Color.OrangeRed);
          break;
      }
    }

    private static void ShowHelp()
    {
      Print("Usage: myqol <command>", Color.Yellow);
      Print("freeze   Freeze or unfreeze time.");
      Print("quest   Rotate the angler quest.");
    }

    private static void Print(string text, Color? color = null)
    {
      Main.NewText(text, color);
    }

    // Rotate the angler quest.
    //
    // The code below has been copied from Terraria.Main.AnglerQuestSwap() and
    // modified accordingly so it can be used in multiplayer by any player to
    // rotate the angler quest for all players.
    //
    // TODO: confirm functionality in multiplayer with another player.
    private static void RotateAnglerQuest()
    {
      Main.anglerWhoFinishedToday.Clear();
      Main.anglerQuestFinished = false;
      bool flag = NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3 || Main.hardMode || NPC.downedSlimeKing || NPC.downedQueenBee;
      bool flag2 = true;
      int tryCount = 0;
      while (flag2)
      {
        // Defining a new angler quest may fail if another mod has bad logic,
        // i.e. another mod tries to add an angler quest that is impossible.
        if (++tryCount > 1000)
        {
          Main.anglerQuest = 0;
          break;
        }
        flag2 = false;
        Main.anglerQuest = Main.rand.Next(Main.anglerQuestItemNetIDs.Length);
        int num = Main.anglerQuestItemNetIDs[Main.anglerQuest];
        if (num == 2454 && (!Main.hardMode || WorldGen.crimson))
          flag2 = true;

        if (num == 2457 && WorldGen.crimson)
          flag2 = true;

        if (num == 2462 && !Main.hardMode)
          flag2 = true;

        if (num == 2463 && (!Main.hardMode || !WorldGen.crimson))
          flag2 = true;

        if (num == 2465 && !Main.hardMode)
          flag2 = true;

        if (num == 2468 && !Main.hardMode)
          flag2 = true;

        if (num == 2471 && !Main.hardMode)
          flag2 = true;

        if (num == 2473 && !Main.hardMode)
          flag2 = true;

        if (num == 2477 && !WorldGen.crimson)
          flag2 = true;

        if (num == 2480 && !Main.hardMode)
          flag2 = true;

        if (num == 2483 && !Main.hardMode)
          flag2 = true;

        if (num == 2484 && !Main.hardMode)
          flag2 = true;

        if (num == 2485 && WorldGen.crimson)
          flag2 = true;

        if ((num == 2476 || num == 2453 || num == 2473) && !flag)
          flag2 = true;

        ItemLoader.IsAnglerQuestAvailable(num, ref flag2);
      }

      NetMessage.SendAnglerQuest(-1);
    }

    // Freeze or unfreeze time.
    //
    // TODO: confirm functionality in multiplayer with another player.
    private static void ToggleTimeFreeze()
    {
      var power = CreativePowerManager.Instance.GetPower<CreativePowers.FreezeTime>();
      power.SetPowerInfo(!power.Enabled);
    }
  }
}
