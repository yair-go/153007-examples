
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace week6
{
    public delegate int someDelegate(int x, int y);
    internal class DelegateExample
    {
        private TextBox tb_delegate;
        private List<int> list1;

        static public int sum(int num1, int num2) { return num1 + num2; }
        static public int mult(int num1, int num2) { return num1 * num2; }
        static public int sub(int num1, int num2) { return num1 - num2; }


        public DelegateExample(System.Windows.Controls.Viewbox vb_delegate)
        {
            

        }

        public DelegateExample(TextBox tb_delegate)
        {
            this.tb_delegate = tb_delegate;
            someDelegate myDlgt = new someDelegate(sum);
            myDlgt += mult;
            myDlgt += sub;
            myDlgt -= sum;
            tb_delegate.Text = "";
            foreach (var d in myDlgt.GetInvocationList())
                tb_delegate.Text += d.Method.Name + "\n" ;
            if (myDlgt is Delegate)
                tb_delegate.Text +=  "myDlgt is Delegate == true";
            tb_delegate.Text += "\n";
           // tb_delegate.Text += myDlgt(3, 2);
            foreach (someDelegate item in myDlgt.GetInvocationList())
                tb_delegate.Text += item(3, 2) + "\n" ;

        }

        bool condition(int x)
        {
            return x % 2 == 0;
        }

        public DelegateExample(TextBox tb_delegate, List<int> list) 
        {
            this.tb_delegate = tb_delegate;
            list1 = list;
            list1.AddRange(new []{1,2,3,4,5,6 });
            List<int> list2;

            //list2 = list1.FindAll(condition);

            //list2 = list1.FindAll(delegate (int x) { return x % 2 == 0; });

            list2 = list1.FindAll(x  =>  x % 3 == 0);
           

        }
    }
}