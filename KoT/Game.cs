using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoT
{
    class Game
    {
        public Game(int i)
        {
            PlayerCount = i;
            alive = PlayerCount;
            Players = new Player[i];
        }
        public bool Round()
        {
            bool win = false;
            for(int i = 0; i < PlayerCount; i++)
            {
                win = Move(Players[i]);
                else if (alive == 1)
                {
                    for (int j = 0; j < PlayerCount; j++)
                    {
                        if (Players[j].health > 0)
                        {
                            winner = Players[j]; //the alive one
                            win = true;
                            break;
                        }
                    }
                }
                if (win)
                {
                    break;
                }
            }
            return win;
        }
        bool Move(Player P)
        {
            if(P.points >= 20)
            {
                return true;
            }
            return false;
        }

        Player winner;
        bool unwin;
        int alive;
        int PlayerCount;
        Player[] Players;
    }
}
