using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week2;

namespace week3
{
    public class MAStudent : Student
    {
        private bool milga;

        public MAStudent(bool milga) : base("David",20)
        {
            this.milga = milga;
        }
    }
}
