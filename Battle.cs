using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Game
{
    class Battle
    {
        public static void TheBattle(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        // Accept 2 Warriors

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)

        {
            // Warrior A attack Warrior B
            // Warrior B block the attack from warrior A
            double warriorAttackAnother = warriorA.Attack();
            double warriorBlockAnother = warriorB.Block();


            // calculate block from attack
            double dmgFromBlock = warriorAttackAnother - warriorBlockAnother;

            if (dmgFromBlock > 0)

            {
                warriorB.Health = warriorB.Health - dmgFromBlock;
                Thread.Sleep(2000);
                System.Media.SystemSounds.Hand.Play();
            }
            else dmgFromBlock = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                    warriorA.Name,
                    warriorB.Name,
                    dmgFromBlock
                );


            Console.WriteLine("{0} has {1} Health\n",
                    warriorB.Name,
                    warriorB.Health
                );


            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} is DEAD and {1} is THE WINNER!\n",
                    warriorB.Name,
                    warriorA.Name);

                return "Game Over";

            }
            else return "Fight Again";
        }
    }
}
