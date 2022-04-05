using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class DecoctOfFrogLegs : Artifact
    {
        public DecoctOfFrogLegs() : base()
        {
            IsReusable = false;
        }
        public override string ToString()
        {
            return "Декокт из лягушачьих лапок";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            if (a.HbState == "Отравлен")
            {
                if (a.CurrentHP < (a.MaxHP / 10)) { a.HbState = "Ослаблен"; }
                if (a.CurrentHP == 0) { a.HbState = "Мертв"; }
                else { a.HbState = "Здоров"; }
            }
            else
            {
                Console.WriteLine("ничего не произошло");
            }
        }
    }
}
