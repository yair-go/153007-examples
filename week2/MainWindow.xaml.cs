using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace week2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            
            InitializeComponent();
        }

        private void tb_Console_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void pb_Console_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            s.Name = "Cinderalla";
            s.Age = 18;

            tb_Console.Text = "Hello  " + s.ToString();

        }
         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void pb_GetNumber_Click(object sender, RoutedEventArgs e)
        {
            
            int cin = Convert.ToInt32(tb_GuessNumber.Text);
            int inputNum = int.Parse(tb_GuessNumber.Text);
            int min = 0, max = 1000;
            int[] arr = new int[100];
            Random r = new Random();
            for (int i = 0; i<arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            StringBuilder nums = new StringBuilder();
            foreach (int item in arr)
            {
                nums.Append(item);
                nums.Append(", ");
            }
            tb_Console.Text = nums.ToString();
            tb_GuessNumber.Text = 100.ToString();
        }
    }
}
