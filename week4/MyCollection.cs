 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2;

namespace week4
{
    public class MyCollection : IEnumerable
    {
        Student[] arr = new Student[10];

        private Dictionary<string, Student> students = new Dictionary<string, Student>();
        

        public MyCollection(Student s)
        {
            students.Add(s.Name, s);
        }

        public Student GetStudent()
        {
            return students["David"];
        }
        // Version 1
        //public IEnumerator GetEnumerator()
        //{
        //    return arr.GetEnumerator();
        //}

       // Version 2
        public IEnumerator GetEnumerator()
        {
            return new MyEnmrtr(this);
        }

        private class MyEnmrtr : IEnumerator
        {
            private MyCollection myCollection;
            Student curr = null;
            int cntr = -1; // before the first element!!!


            public MyEnmrtr(MyCollection myCollection)
            {
                this.myCollection = myCollection;
            }

            public object Current { get { return curr; } }

            public bool MoveNext()
            {
                if (++cntr >= myCollection.arr.Length) return false;
                else { curr = myCollection.arr[cntr]; return true; }

            }

            public void Reset()
            {
                this.curr = null;
                this.cntr = -1; // before the first element!!!

            }
        }
    }
}
