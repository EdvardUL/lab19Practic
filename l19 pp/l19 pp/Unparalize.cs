using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Unparalize:Spell
    {
        public override string ToString()
        {
            return "Отомри";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            minMana -= 85;
            a.CurrentHP = 1;
            a.CurrentHP = 1;
        }
    }
}
