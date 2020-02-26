using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSimulator.Entities
{
    /// <summary>
    /// An object of class Warrior.
    /// </summary>
    public class Warrior
    {
        /// <summary>
        /// The warrior's name which will be displayed when battling. 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The warrior's health which determines how much damage they can take before being defeated.
        /// </summary>
        public int HealthMax { get; }
        /// <summary>
        /// The warrior's max attack, which determines the max damage their attacks can deal.
        /// </summary>
        public int AttackMax { get; set; }
        /// <summary>
        /// The warrior's max block, which determines the max damage they can block.
        /// </summary>
        public int BlockMax { get; set; }
        /// <summary>
        /// The warrior's current health.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Instantiates a new warrior object.
        /// </summary>
        /// <param name="name">
        /// The warrior's name which will be displayed when battling.
        /// </param>
        /// <param name="health">
        /// The warrior's health which determines how much damage they can take before being defeated.
        /// </param>
        /// <param name="attackMax">
        /// The warrior's max attack, which determines the max damage their attacks can deal.
        /// </param>
        /// <param name="blockMax">
        /// The warrior's max block, which determines the max damage they can block.
        /// </param>
        public Warrior(string name, int healthMax, int attackMax, int blockMax)
        {
            Name = name;
            HealthMax = healthMax;
            AttackMax = attackMax;
            BlockMax = blockMax;
            Health = healthMax;
        }

        /// <summary>
        /// Generates a number between 1 and the "max" value.
        /// </summary>
        /// <param name="max">
        /// The max value to generate.
        /// </param>
        /// <returns>
        /// A randomly generated number between 1 and the "max" value"
        /// </returns>
        private int RNG(int max)
        {
            Random rng = new Random();
            int output = rng.Next(1, max + 1);
            return output;
        }

        /// <summary>
        /// Generates an attack based on the warrior's AttackMax stat.
        /// </summary>
        /// <returns>
        /// An attack generated based on the warrior's AttackMax stat.
        /// </returns>
        public int Attack() => RNG(AttackMax);

        /// <summary>
        /// Generates a block based on the warrior's BlockMax stat.
        /// </summary>
        /// <returns>
        /// A block generated based on the warrior's BlockMax stat.
        /// </returns>
        public int Block() => RNG(BlockMax);

        public override string ToString() =>
            $"Name:\t{this.Name}" +
            $"\nHealth:\t{this.HealthMax}" +
            $"\nAttack:\t{this.AttackMax}" +
            $"\nBlock:\t{this.BlockMax}";
    }
}
