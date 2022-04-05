using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class DeadBottle : Artifact
    {
        public DeadBottle() : base()
        {
            IsReusable = false;
        }
        public override string ToString()
        {
            return "Бутылка с мертвой водой";
        }

        public override void Use(object p)
        {
            Wizard a = p as Wizard;
            while (a.currentMana < a.maxMana)
            {
                a.currentMana++;
            }
        }
    }
}
