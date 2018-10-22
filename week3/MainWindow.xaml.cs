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
using week2;

namespace week3
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

        private void pbStartWeek3_Click(object sender, RoutedEventArgs e)
        {
            BAStudent bA = new BAStudent(true);
            MAStudent mA = new MAStudent(false);

            List<Student> students = new List<Student>();

            students.Add(bA);
            students.Add(mA);
            students.Add(new BAStudent(false));
            
            students.Sort();
            tb_StudentDetails.Text = "";
            foreach (Student s in students)
            {
                if (s is BAStudent)
                {
                    tb_StudentDetails.Text += s.ToString() + "\n"; 
                }

            }
        }
    }
}
