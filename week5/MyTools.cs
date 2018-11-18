using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2;

namespace week5
{
    static class MyTools
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        public static Student ToStudent(this string str)
        {
            return Student.Parse(str);
        }

        static char[] delimiterChars = { ' ', ',', '.', ':', '\t', '&' };
        public static int[] ToIntArray(this string str)
        {

            string[] words = str.Split(delimiterChars);
            List<int> arr = new List<int>();
            foreach (string s in words)
            {
                arr.Add(int.Parse(s));
            }

            return arr.ToArray();
        }
    }
}
