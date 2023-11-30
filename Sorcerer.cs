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

        public override void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.hp);
            Console.WriteLine(this.Mana);
        }

        public override void TakeDamage(int damage)
        {
            this.Mana += damage;
            this.hp -= damage/2;
        }
    }
}