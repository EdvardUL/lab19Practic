using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Antidote:Spell
    {
        public override string ToString()
        {
            return "Противоядие";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            a.HbState = "Здоров";
            a.HbState = "Здоров";
            minMana -= 30;
        }
    }
}
