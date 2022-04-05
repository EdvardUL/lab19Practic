using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class EyeOfBasilisk : Artifact
    {
        public EyeOfBasilisk():base()
        {
            IsReusable = false;
        }
        public override string ToString()
        {
            return "Глаз василиска";
        }
        public override void Use(object p)
        {
            Character a = p as Character;
            if(a.HbState!="Мертв")
            {
                a.HbState = "Парализован";
            }
            else
            {
                Console.WriteLine("Артефакт не может быть использован");
            }
        }
    }
}
