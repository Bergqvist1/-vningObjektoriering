using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _vningObjektoriering
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Character> list = new List<Character>();
            list.Add(new Barbarian(10,100, "KebabTurken"));
            list.Add(new Paladin("Jebemti Matir", 200, 1));
            list.Add(new Sorcerer(50, 100, "Freddy"));

            foreach(Character character in list)
            {
                character.Print();
            }
        }
    }
}