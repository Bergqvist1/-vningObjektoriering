using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{
    class Barbarian: Character
    {
        private int RageLevel;

        public Barbarian(int ragelevel, int HP, string Name)
        {
            this.RageLevel = ragelevel;
            this.hp = HP;
            this.name = Name;
        }

        public override void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.hp);
            Console.WriteLine(this.RageLevel);
        }

        public override void TakeDamage(int damage)
        {
            this.hp -= damage;
            this.RageLevel += damage;
        }
    }
}