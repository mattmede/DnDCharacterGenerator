using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    class DiceRolls
    {
        private static Random rolls = new Random();

        public static int rollStat()
        {
            var result = 0;

            List<int> values = new List<int>();

            values.Add(rolls.Next(1, 7));
            values.Add(rolls.Next(1, 7));
            values.Add(rolls.Next(1, 7));
            values.Add(rolls.Next(1, 7));

            values.Remove(values.Min());

            result = values.Sum();

            return result;
        }
    }
}
