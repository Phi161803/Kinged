using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoT
{
    class Player
    {
        Player()
        {
            health = 10;
        }
        

        public int[] status; //list of all status conditions
        /*  0 = poison
            1 = smoke

        */
        

        public string name;
        public int health;
        public int points;
    }
}
