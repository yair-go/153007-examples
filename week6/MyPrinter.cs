using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6
{
    public delegate void PrintEventHandler();
    public class MyPrinter
    {
        public event PrintEventHandler PageOver = null;
        private int pageCount = 20;
        private void handlePageOver()
        { if (PageOver != null) PageOver(); }
        public void Print(int pages)
        {
            if (pages <= pageCount) pageCount -= pages;
            else { pageCount = 0; handlePageOver(); }
        }
    }

}
