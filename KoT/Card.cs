using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoT
{
    abstract class Card
    {
        public abstract void OnBuy(Game g);

        public int cost;
        public int test;
        public string name;
        public string desc;
    }
    abstract class Keeper : Card
    {
        public abstract void WhileHave();
        public abstract void OnDiscard();
    }

    class Frz: Card
    {
        Frz()
        {
            name = "Frenzy";
            cost = 7;
            desc = "When you purchase this card, take another turn immediately after this one.";
        }

        public override void OnBuy(Game G)
        {
            
        }
    }
}
