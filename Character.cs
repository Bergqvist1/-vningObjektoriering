using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{


    abstract class Character
        {
            public string name;

             public int hp;

             abstract public void Print();
             abstract public void TakeDamage(int damage);

            
        }
}    

