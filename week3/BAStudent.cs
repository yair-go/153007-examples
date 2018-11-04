using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using week2;

namespace week3
{
    public class BAStudent : Student
    {
        private bool milga;

        public BAStudent(bool milga) : base("Moshe",18)
        {
            this.milga = milga;
        }

        public BAStudent(string name, bool milga) : base(name, 18)
        {
            this.milga = milga;
        }
        public bool Milga { get => milga; }

        public override string ToString()
        {
            return base.ToString() + " Milga : " + Milga; 
        }
    }
}