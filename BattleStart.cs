using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Game
{
    class BattleStart
    {
        static void Main(string[] args)
        {

            Warrior ragnar = new Warrior("Ragnar", 1000, 180, 40);
            Warrior kingAelle = new Warrior("King Aelle", 1200, 160, 30);

            Battle.TheBattle(ragnar, kingAelle);
            Console.ReadLine();
           
        }
    }
}
