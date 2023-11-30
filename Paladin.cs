using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{
    class Paladin: Character
    {
        private int HolyPower;

        public Paladin(string Name, int hp, int HolyPower)
        {
            this.HolyPower = HolyPower;
            this.hp = hp;
            this.name = Name;
        }
    }
}