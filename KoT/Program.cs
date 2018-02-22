using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoT
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Gameplay = new Game(6);
            while (!Gameplay.Round()) ;
            //announce winner
        }

        static Random r = new Random();
    }
}
