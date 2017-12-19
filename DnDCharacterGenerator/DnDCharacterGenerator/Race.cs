using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    class Race
    {
        string name;
        string size;
        int speed;
        List<string> languages = new List<string>();
        Subrace subraces;
    }
}
