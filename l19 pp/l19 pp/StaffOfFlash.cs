using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class StaffOfFlash : Artifact
    {
        public StaffOfFlash() : base()
        {
            if(strength>0)
            {
                IsReusable = true;
            }
            else
            {
                IsReusable = false;
            }
            
        }
        public override string ToString()
        {
            return "Посох молния";
        }
        public override void Use(object p)
        {
            Console.WriteLine("Введите можность артифакта");
            strength = Convert.ToInt32(Console.ReadLine());
            Character a = p as Character;
            a.CurrentHP-=strength;
        }
    }
}
