using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    abstract class Artifact
    {
        public int strength = 200;
        public bool IsReusable;
        public abstract void Use(object p);
    }
}
