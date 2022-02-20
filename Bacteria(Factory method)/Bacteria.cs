using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacteria_Factory_method_
{
    class Bacteria
    {
        private int id;
        private int ancestor;
        private bool dead;
        private int age;

        public Bacteria(int _id,int _ancestor, bool _dead,int _age )
        {
            id = _id;
            ancestor = _ancestor;
            dead = _dead;
            age = _age;

        }


        public int ID(){return id;}
        public int Ancestor() {return ancestor;}
        public bool Dead(){return dead;}
        public int Age(){return age;}



        public void Set_ID(int num) { id = num;}
        public void Set_Ancestor(int num) { ancestor = num;}
        public void Set_Deat(bool T_F) { dead = T_F;}
        public void Set_Age(int num) { age = num;}
    }
}
