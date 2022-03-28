using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{

    internal abstract class AbstractClass
    {
        [Description("Name of class")]
        public string Name { get=>Description("stefan"); }
        public abstract int MyProperty { get; set; }
        public abstract string Description(string name);

    }

    internal class A:AbstractClass
    {
        private int _a;
        public int PublicField;
        protected int ProtectedField=4;

        public override int MyProperty { get => _a; set => _a=value; }

        public A(int a)
        {

        }
        public A()
        {

        }

        public virtual string VitrualMethod()
        {
            return "Virtual Method Class A";
        }

        public override string Description(string name)
        {
            throw new NotImplementedException();
        }
    }

    internal class B : A
    {
        public new int PublicField;
        public B(int a):base(a)
        {
            base.PublicField = a;
            PublicField = a + 4;
        }

        public B()
        {

        }
        public override string ToString()
        {
            return $"A.PublicField={base.PublicField};B.PublicField={PublicField}";
        }
        public override string VitrualMethod()
        {
            return "Virtual Method Class B";
        }

        


    }

    internal  struct MyInt
    {
        public int PublicField;
        public MyInt()
        {
            PublicField = 0;
        }
    }


}
