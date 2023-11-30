using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{
     class Sorcerer: Character
    {
        private int Mana;

        public Sorcerer(int Mana, int hp, string Name)
        {
            this.Mana = Mana;
            this.hp = hp;
            this.name = Name;
        }
    }
}