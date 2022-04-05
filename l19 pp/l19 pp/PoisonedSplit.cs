using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class PoisonedSplit : Artifact
    {
        public PoisonedSplit():base()
        {
            IsReusable = true;
        }
        public override string ToString()
        {
            return "Ядовитая слюна";
        }
        public override void Use(object p)
        {
            Console.WriteLine("Введите можность артифакта");
            strength = Convert.ToInt32(Console.ReadLine());
            Character a = p as Character;
            if (a.HbState != "Мертв")
            {
                a.HbState = "Отравлен";
                a.CurrentHP -= strength;
                if(a.currentHp<=0)
                {
                    a.HbState = "Мертв";
                }
            }
            else
            {
                Console.WriteLine("Артефакт не может быть использован");
            }
        }
    }
}
