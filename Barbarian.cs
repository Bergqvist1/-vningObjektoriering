using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{
    class Barbarian: Character
    {
        private int RageLevel;

        public Barbarian(int RageLevel, int hp, string Name)
        {
            this.RageLevel = RageLevel;
            this.hp = hp;
            this.name = Name;
        }
    }
}