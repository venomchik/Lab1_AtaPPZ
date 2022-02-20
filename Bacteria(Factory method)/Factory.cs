using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacteria_Factory_method_
{
    internal class Factory
    {
        public Bacteria Reproduction(Bacteria bacteria,int num)
        {
            
            return new Bacteria(num,bacteria.ID(),false,0);
        }


        public void Death(Bacteria bacteria)
        {
            bacteria.Set_Deat(false);
        }
    }
}
