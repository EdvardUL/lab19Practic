using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Armor:Spell
    {
        public override string ToString()
        {
            return "Броня";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            a.HbState = "неуязвим";
            minMana -= 30;
        }
    }
}
