using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{
    internal class DelegateDemo
    {
        public delegate void DelegateDemoDelegate(object sender, EventArgs e);
        public delegate void DelegateDemo1(object sender, EventArgs e);
        public static void TestDelegate(Action<object,EventArgs> delegateDemoDelegate)
        {
            delegateDemoDelegate(null,null);
        }
        public static void DelegateMethod1()
        {
            TestDelegate((ob,iv)=>
            {
                Console.WriteLine($"{ob} - {iv}"); 
            });
            Console.WriteLine("Execute delegate");
        }

        private static void myFunc(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public static void DelegateMethod()
        {
            Console.WriteLine("Execute delegate");
        }
        public static void TestDelegate(Action delegateDemoDelegate)
        {
            delegateDemoDelegate();
        }

        static string userName;
        static public string UserName 
        {
            get=>userName;
            set
            {
                OnUserNameChange?.Invoke(userName, value);
                if (OnUserNameChange != null)
                      OnUserNameChange.Invoke(userName, value);


            }
        }


        public static event Action<string,string> OnUserNameChange;


    }
}
