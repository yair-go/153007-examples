using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class Student
    {
        #region Fields
        private string _name;
        private int _age;
        private int _id;

        #endregion

        #region Ctors
        public Student(string name = "", int age = 0, int id = 1)
        {
            Name = name;
            Age = age;
            _id = id;
        }

        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age { get; set; }

        public int Grade { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            return _name + " " + Age ;
        }
        #endregion
    }
}
