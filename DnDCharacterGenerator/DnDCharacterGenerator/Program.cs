using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.printStats();
            Console.Read();
        }
    }
}
