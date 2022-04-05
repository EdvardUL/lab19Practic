using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class HeaL:Spell
    {
        public override string ToString()
        {
            return "Восстановление хп";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            while (a.CurrentHP < a.MaxHP) { a.CurrentHP++; }
            a.HbState = "Здоров";
            a.HbState = "Здоров";
            minMana -= 20;
        }
    }
}
