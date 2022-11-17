using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{
    internal interface IFigure:ICloneable
    {
        public string Color { get; set; }
        public void Draw();
        public int this[int index] { get; set; }

        public int Calc(int a, int b) => a + b;

    }
}
