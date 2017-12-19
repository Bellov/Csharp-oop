using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game
{
    class Warrior
    {
        // Warrior props

        public string Name { get; set; }
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double AttackBlock { get; set; } = 0;

        // Always create a single Random instance and reuse  it or you will get the same value over and over

        Random rnd = new Random();

        // Construct

        public Warrior(string name = "Ragnar",
            double health = 0,
            double attackMax = 0,
            double attackBlock = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            AttackBlock = attackBlock;
        }

        // Generate attack with value 2 
        public double Attack()
        {
            return rnd.Next(3, (int)AttackMax);
        }

        //Generate random block
        public double Block()
        {
            return rnd.Next(1, (int)AttackBlock);
        }
    }
}
