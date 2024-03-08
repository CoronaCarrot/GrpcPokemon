using System.Collections.Generic;
using System.Security.Cryptography;

namespace GrpcPokemon.Menus.Display
{
    public class BattleUi
    {
        public IPokemon player1;
        public IPokemon player2 = new Charmander();

        public BattleUi(IPokemon player1)
        {
            this.player1 = player1;
        }

        public static void DrawPokemon(int left, int top, string[] sprite)
        {
            for (int i = 0 ; i < sprite.Length; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write(sprite[i]);
            }
        }
        public static string BuildHP(int health)
        {
            return $"{new string('█', health / 10)}{(health % 10 != 0 ? (health % 10 <= 3 ? '░' : (health % 10 > 3 && health % 10 <= 6 ? '▒' : '▓')) : "")}".PadRight(10);
        }

        public void PrintBattle(string[] P1, string[] P2)
        {
            Console.WriteLine($@"╭──────────────────────────────╮{new String(' ', Console.BufferWidth - 32)}
│ {(player2.Name.Length <= 11 ? player2.Name.PadRight(11) : $"{player2.Name.Substring(0, 5)}...")} ╭──────────────╮ │{new String(' ', Console.BufferWidth - 32)}
│ LV {player2.Level.ToString().PadRight(8)} │HP {BuildHP(player2.Health)} │ ╰╮{new String(' ', Console.BufferWidth - 33)}
│             ╰──────────────╯ ╭┘{new String(' ', Console.BufferWidth - 33)}
╰──────────────────────────────╯{new String(' ', Console.BufferWidth - 32)}");
            Console.Write(string.Join("", Enumerable.Repeat($"{new String(' ', Console.BufferWidth)}\n", (P1.Length > P2.Length ? P1.Length : P2.Length) - 5)));
            Console.Write($@"{new String(' ', Console.BufferWidth - 33)} ╭──────────────────────────────╮
{new String(' ', Console.BufferWidth - 33)} │ {(player1.Name.Length <= 11 ? player1.Name.PadRight(11) : $"{player1.Name.Substring(0, 7)}...")} ╭──────────────╮ │
{new String(' ', Console.BufferWidth - 33)} │ LV {player1.Level.ToString().PadRight(8)} │HP {BuildHP(player1.Health)} │ │
{new String(' ', Console.BufferWidth - 33)}╭╯             ╰───╮ {player1.Health.ToString().PadLeft(3)}/100  │ │
{new String(' ', Console.BufferWidth - 33)}└╮                 ╰──────────╯ │
╭{new String('─', Console.BufferWidth - 33)}┴──────────────────────────────┤
");
        }

        public ConsoleKeyInfo BattleSelect()
        {
            Console.SetCursorPosition(0, 0);
            string[] P1 = player1.FightSpriteB.Split('\n');
            string[] P2 = player2.FightSpriteF.Split('\n');
            string PMax = P2.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);

            PrintBattle(P1, P2);
            Console.Write($@"│ ╭{new String('─', Console.BufferWidth - 38)}╮  ╭─────────────╮ ╭────────────╮ │
│ │{new String(' ', Console.BufferWidth - 38)}│  │ (1)  FIGHT  │ │ (2)  BAG   │ │
│ │{new String(' ', Console.BufferWidth - 38)}│  ╰─────────────╯ ╰────────────╯ │
│ │{new String(' ', Console.BufferWidth - 38)}│  ╭─────────────╮ ╭────────────╮ │
│ │{new String(' ', Console.BufferWidth - 38)}│  │ (3) POKEMON │ │ (4)  RUN   │ │
│ ╰{new String('─', Console.BufferWidth - 38)}╯  ╰─────────────╯ ╰────────────╯ │
╰{new String('─', Console.BufferWidth - 2)}╯
(?) Press a key to choose!{new String(' ', Console.BufferWidth - 28)}
      ");
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(string.Join("", Enumerable.Repeat($"{new String(' ', Console.BufferWidth)}\n", 50)));
            int temp = new Random().Next(1, 3);
            DrawPokemon(2 + temp, 5 + (P1.Length > P2.Length ? P1.Length - P2.Length : P2.Length - P1.Length), P1);
            DrawPokemon(Console.BufferWidth - PMax.Length - 2, 0, P2);

            ConsoleKeyInfo pressedKey = Console.ReadKey(true);
            player1.Health -= new Random().Next(0, 3);
            player2.Health -= new Random().Next(0, 3);
            return pressedKey;
        }
    }
}
