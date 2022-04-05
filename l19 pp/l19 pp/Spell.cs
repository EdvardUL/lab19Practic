using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    abstract class Spell:Magix
    {
        static public int minMana=200;
        public string TextOfSpell;
        public string SpellMotions;
        public void DoMagic(object p)
        {
            Console.WriteLine("");
        }
        public abstract void Use(object p);
    }
}
