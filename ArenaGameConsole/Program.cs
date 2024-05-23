using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rogue rogue = new Rogue("Slim Shady");
            //Priest priest = new Priest("Rudolph");
            //Knight knight = new Knight("Sir John");
            DragonSlayer dragonSlayer = new DragonSlayer("Garuda");
            Arena arena = new Arena(rogue, dragonSlayer); 
            arena.EventListener = new ConsoleGameEventListener();

            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended. Winner is: {winner.Name}");
            Console.ReadLine();
        }
    }
}
