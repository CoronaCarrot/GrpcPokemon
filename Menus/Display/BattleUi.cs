using GrpcPokemon.Menus.Display;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GrpcPokemon.Menus.Display
{
  public class BattleUi
  {
    public IPokemon player1;

    public BattleUi(IPokemon player1)
    {
      this.player1 = player1;
    }

    public ConsoleKeyInfo BattleSelect()
    {
      int numLinesP1 = player1.FightSpriteB.Split('\n').Length;

      Console.WriteLine($@"╭──────────────────────────────╮
│ NAME       ╭───────────────╮ │
│ LV 25      │HP             │ │
│            ╰───────────────╯ │
╰──────────────────────────────╯");
      Console.Write( new String('\n', numLinesP1-5));
      Console.WriteLine($@"{ new String(' ', Console.BufferWidth - 33)} ╭──────────────────────────────╮
{new String(' ', Console.BufferWidth - 33)} │             ╭──────────────╮ │
{new String(' ', Console.BufferWidth - 33)} │ LV 25       │HP ########## │ │
{new String(' ', Console.BufferWidth - 33)}╭╯             ╰───╮ 100/100  │ │
{new String(' ', Console.BufferWidth - 33)}└╮                 ╰──────────╯ │
╭{new String('─', Console.BufferWidth - 33)}┴──────────────────────────────┤
│ ╭{new String('─', Console.BufferWidth - 38)}╮  ╭─────────────╮ ╭────────────╮ │
│ │{new String(' ', Console.BufferWidth - 38)}│  │ (1)  FIGHT  │ │ (2)  BAG   │ │
│ │{new String(' ', Console.BufferWidth - 38)}│  ╰─────────────╯ ╰────────────╯ │
│ │{new String(' ', Console.BufferWidth - 38)}│  ╭─────────────╮ ╭────────────╮ │
│ │{new String(' ', Console.BufferWidth - 38)}│  │ (3) POKEMON │ │ (4)  RUN   │ │
│ ╰{new String('─', Console.BufferWidth - 38)}╯  ╰─────────────╯ ╰────────────╯ │
╰{new String('─', Console.BufferWidth - 2)}╯
(?) Press a key to choose!
      ");
      Console.SetCursorPosition(1, 5);
      Console.Write($"{player1.FightSpriteB}");
      Console.SetCursorPosition(Console.BufferWidth - player1.FightSpriteB.Split('\n').First().Count(), 0);
      Console.Write($"{player1.FightSpriteB}");

      ConsoleKeyInfo pressedKey = Console.ReadKey(true);
      Console.Write(pressedKey.ToString());
      return pressedKey;
    }
  }
}
