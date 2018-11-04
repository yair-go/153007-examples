using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public class Address : IComparable
    {
        public string City
        {
            get => default(string);
            set
            {
            }
        }

        public string Street
        {
            get => default(string);
            set
            {
            }
        }

        public int House
        {
            get => default(int);
            set
            {
            }
        }

        public int CompareTo(object obj)
        {
            return City.CompareTo((obj as Address).City);
        }
    }
}
