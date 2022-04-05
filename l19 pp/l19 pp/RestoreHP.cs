using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class RestoreHP : Spell
    {
        public override string ToString()
        {
            return "Добавить хп";
        }
        public override void Use(object p)
        {
            Wizard a = p as Wizard;
            Console.WriteLine("Введите колличество хп");
            int countofHP = Convert.ToInt32(Console.ReadLine());
            a.CurrentHP = a.CurrentHP + countofHP;
            
        }
    }
}
