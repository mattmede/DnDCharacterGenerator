using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    class Character
    {
        int total_level;
        string name;
        Race race;
        List<DnDClass> character_class;

        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;

        public Character()
        {
            rollStats();
        }

        public void rollStats()
        {
            Random rolls = new Random();

            while (true)
            {
                strength = DiceRolls.rollStat();
                dexterity = DiceRolls.rollStat();
                constitution = DiceRolls.rollStat();
                intelligence = DiceRolls.rollStat();
                wisdom = DiceRolls.rollStat();
                charisma = DiceRolls.rollStat();

                if (strength >= 15) { break; }
                if (dexterity >= 15) { break; }
                if (constitution>= 15) { break; }
                if (intelligence >= 15) { break; }
                if (wisdom >= 15) { break; }
                if (charisma >= 15) { break; }

            }
        }

        public void printStats()
        {
            Console.WriteLine("Strength: " + MiscFunctions.generateModifier(strength));
            Console.WriteLine("Dexterity: " + MiscFunctions.generateModifier(dexterity));
            Console.WriteLine("Constitution: " + MiscFunctions.generateModifier(constitution));
            Console.WriteLine("Intelligence: " + MiscFunctions.generateModifier(intelligence));
            Console.WriteLine("Wisdom: " + MiscFunctions.generateModifier(wisdom));
            Console.WriteLine("Charisma: " + MiscFunctions.generateModifier(charisma));
        }

    }
}
