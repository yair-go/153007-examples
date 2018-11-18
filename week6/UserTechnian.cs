using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    class UserTechnian
    {
        MyPrinter myPrinter;
        public UserTechnian(MyPrinter printer)
        {
            myPrinter = printer;
            printer.PageOver += myPageOver;
            //printer.PageOver();
        }
        private void myPageOver()
        {
        }

    }
}
