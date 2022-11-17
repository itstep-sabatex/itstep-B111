using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{
    [Flags]
    internal enum EnumFlagsDemo:uint
    {
        Понеділок =1, // 00000001
        Вівторок=2,   // 00000010
        Середа =4,    // 00000100
        Четверг=8,    // 00001000
        Пятниця=16,   // 00010000
        Субота = 32,  // 00100000
        Неділя =64    // 01000000
    }
}
