using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    /// <summary>
    /// 
    /// </summary>
    public class Student : Person, IComparable
    {
        #region Fields
        private string _name;
        private int _age;
        private int _id;

        private static int _counterId;

        #endregion

        #region Ctors
        public Student(string name = "", int age = 0, int id = 1)
        {
            Name = name;
            Age = age;
            _id = _counterId++;
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _name + " " + Age + " ID : " + _id;
        }

        public override string getName()
        {
            return Name;
        }

        public int CompareTo(object obj)
        {

            return _id.CompareTo((obj as Student)._id);
        }
        #endregion
    }
}
