using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    class MiscFunctions
    {
        public static string generateModifier(int stat)
        {
            //if(stat == 1) { return "-5";  }
            //else if (stat < 4) { return "-4"; }
            //else if (stat < 6) { return "-3"; }
            //else if (stat < 8) { return "-2"; }
            //else if (stat < 10) { return "-1"; }
            //else if (stat < 12) { return "+0"; }
            //else if (stat < 14) { return "+1"; }
            //else if (stat < 16) { return "+2"; }
            //else if (stat < 18) { return "+3"; }
            //else if (stat < 20) { return "+4"; }
            //else if (stat < 22) { return "+5"; }
            //else if (stat < 24) { return "+6"; }
            //else if (stat < 26) { return "+7"; }
            //else if (stat < 28) { return "+8"; }
            //else if (stat < 30) { return "+9"; }
            //else if (stat == 30) { return "+10"; }
            //else { return "Error: Stat can't be greater than 30"; }

            if (stat > 9) { return "+" + ((stat - 10) / 2).ToString(); }
            else { return ((stat - 10) / 2).ToString(); }

        }
    }
}
