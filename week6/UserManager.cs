using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    class UserManager
    {
        MyPrinter myPrinter;
        public UserManager(MyPrinter printer)
        {
            myPrinter = printer;
            printer.PageOver += myPageOver;
        }
        private void myPageOver()
        {
        }
    }
}
