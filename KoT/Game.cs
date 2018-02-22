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
                P = Players[i];
                win = Move();
                if (alive == 1)
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
        bool Move()
        {
            if(P.points >= 20)
            {
                winner = P;
                return true;
            }
            return false;
        }

        Player P;
        Player winner;
        bool unwin;
        int alive;
        int PlayerCount;
        Player[] Players;
    }
}
