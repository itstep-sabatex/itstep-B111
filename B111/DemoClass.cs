using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{
    internal record struct DemoClassRecordStruct(string MyProperty, int? MyProperty2);

    internal struct DemoClassRecordStructFull
    {
        public string MyProperty { get; set; }
    }

    internal record DemoClassRecord(string MyProperty, int? MyProperty2)
    {
        public int MutableProperty { get; set; }
    }
    internal record DemoClassRecord1(string MyProperty, int? MyProperty2,string Rez):DemoClassRecord(MyProperty, MyProperty2)
    {
        public int MutableProperty2 { get; set; }
    }

    internal class DemoClass
    {
        public string MyProperty { get; set; }
        public int? MyProperty2 { get; set; }
        public DemoClass()
        {
            MyProperty=string.Empty;
            MyProperty2 = 0;
        }
    }
}
