using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{
    class Paladin: Character
    {
        private int HolyPower;

        public Paladin(string Name, int HP, int holypower)
        {
            this.HolyPower = holypower;
            this.hp = HP;
            this.name = Name;
        }

        public override void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.hp);
            Console.WriteLine(this.HolyPower);
        }

        public override void TakeDamage(int damage)
        {
            this.HolyPower -= damage;
            this.hp -= damage*2;
        }
    }
}