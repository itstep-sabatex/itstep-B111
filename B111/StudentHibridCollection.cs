using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B111
{
    internal class StudentHibridCollection : IEnumerable,IEnumerator
    {
        public string IvanenkoIvan { get; set; } = "Іван Іваненко";
        public string IvanenkoPetro { get; set; } = "Петро Іваненко";
        public string IvanenkoStepan { get; set; } = "Степан Іваненко";
        public string IvanenkoDima { get; set; } = "Дмитро Іваненко";
        public string IvanenkoIllia { get; set; } = "Ілля Іваненко";

        private int count = -1;


        object IEnumerator.Current {
            get
            {
                switch (count)
                {
                    case 0:return IvanenkoIvan;
                    case 1:return IvanenkoPetro;
                    case 2:return IvanenkoStepan;   
                    case 3:return IvanenkoDima;
                    case 4:return IvanenkoIllia;
                    default: throw new IndexOutOfRangeException($"{count}");
                        
                }
            }
        }

        public IEnumerator GetEnumerator()=>(IEnumerator)this;
  

        bool IEnumerator.MoveNext()
        {
            count++;
            if (count >=5) return false;
            return true;
        }

        void IEnumerator.Reset()
        {
            count = -1;
        }
    }

    internal class StudentHibridCollectionEnumerator : IEnumerator
    {
        StudentHibridCollection _studentHibridCollection;
        public StudentHibridCollectionEnumerator(StudentHibridCollection studentHibridCollection)
        {
            _studentHibridCollection= studentHibridCollection;
        }


        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}
