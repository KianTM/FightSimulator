using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimulator.Entities
{
    /// <summary>
    /// An object of class Battle.
    /// </summary>
    public class Battle
    {
        private byte attacker = 1;
        private string[] openingQuotes = new string[]
        {
            "prepare for a bloodbath!",
            "it's a beautiful day for a slaughter!"
        };

        /// <summary>
        /// Starts a new battle, pitting two warriors against each other in a battle to the death.
        /// </summary>
        /// <param name="w1">The first warrior.</param>
        /// <param name="w2">The second warrior.</param>
        public void StartBattle(Warrior warrior1, Warrior warrior2)
        {
            Random rng = new Random();
            int quoteToUse = rng.Next(0, openingQuotes.Length);

            Console.WriteLine("Ladies and gentlemen, " + openingQuotes[quoteToUse]);
            Console.WriteLine("Today's contestants are...");
            Console.WriteLine("\n" + warrior1.ToString());
            Console.WriteLine("\nVS");
            Console.WriteLine("\n" + warrior2.ToString());
            Console.WriteLine("\nThe battle has begun!");
            Console.ReadLine();

            while (warrior1.Health > 0 && warrior2.Health > 0)
            {
                switch (attacker)
                {
                    case 1:
                        GetAttackResult(warrior1, warrior2);
                        attacker = 2;
                        Console.ReadLine();
                        break;
                    case 2:
                        GetAttackResult(warrior2, warrior1);
                        attacker = 1;
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("\nGame Over");
            Console.ReadLine();
            Environment.Exit(0);
        }


        /// <summary>
        /// Gets the result of two warriors attacking and blocking.
        /// </summary>
        /// <param name="warriorA">
        /// The attacking warrior.
        /// </param>
        /// <param name="warriorB">
        /// The blocking warrior.
        /// </param>
        private void GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            int attack = warriorA.Attack();
            int block = warriorB.Block();
            int damage = attack - block;

            if (damage < 0)
            {
                damage = 0;
            }

            Console.WriteLine($"\n{warriorA.Name} attacks {warriorB.Name} for {attack} damage! {warriorB.Name} blocked {block}.");

            if (damage > 0)
            {
                warriorB.Health -= damage;
            }

            if (warriorB.Health <= 0)
            {
                Console.WriteLine($"{warriorB.Name} has been defeated! {warriorA.Name} wins!");
            }
            else if (warriorB.Health <= warriorB.HealthMax * 0.1)
            {
                Console.WriteLine($"{warriorB.Name} is still standing with just {warriorB.Health} health left!");
            }
            else
            {
                Console.WriteLine($"{warriorB.Name} has {warriorB.Health} health left!");
            }
        }
    }
}
