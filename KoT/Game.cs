using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoT
{
    class Game
    {
        Game()
        {

        }
        bool Round()
        {
            for(int i = 0; i < PlayerCount; i++)
            {
                unwin = Move(Players[i]);
                if(PlayerCount - dead == 1)
                {
                    winner = //the alive one
                    return false;
                } else if(Players[i].points >= 20)
                {
                    winner = Players[i];
                    return false;
                }
            }
        }
        bool Move(Player P)
        {
            return true;
        }

        Player winner;
        bool unwin;
        int dead;
        int PlayerCount;
        Player[] Players;
    }
}
