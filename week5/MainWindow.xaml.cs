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

namespace week5
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

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            var lecturer = new { ID = 29, Name = "Dani" };
            var lecturer2 = new { ID2 = 30, Name = "Oshri" };
            var lecturer3 = new { ID = 31, Name = "Yair", Age = 30 };
            tbShow.Text = lecturer.ToString() + " " + lecturer.GetType() + "\n";
            tbShow.Text += lecturer2.ToString() + " " + lecturer2.GetType();

            string str = "123";
            
            string StudentName = "Aviad";

           

            //string a = "123a";
            //try
            //{
            //    int c = Int32.Parse(a);
            //}
            //catch (Exception ex)
            //{
            //    tbShow.Text = ex.Message;
            //  //  throw new MyExpception("new message", ex);
            //}
            //finally
            //{
            //    tbShow.Text = "I always happen";
            //}
        }

        private void pbExtension_Click(object sender, RoutedEventArgs e)
        {
            string str = "123";
            str.ToInt();
          //  int[] arr = tbShow.Text.ToIntArray();

            string StudentName = "Aviad";
            int age = 23;
            

            Student s1 = new Student(StudentName);
            string newStudent = StudentName + "," + age;
            Student s = newStudent.ToStudent();
             string a = "123a";

            try
            {
                try
                {
                    int c = Int32.Parse(a);
                }
                catch (Exception ex)
                {
                    tbShow.Text = ex.Message;
                    //throw new Exception("Hello Exception");
                    throw new MyExpception2("new message", ex);
                }
                finally
                {
                      tbShow.Text = "\nI always happen";
                }
            }
            catch (Exception ex)
            {

                tbShow.Text += ex.Message;
                //throw ex;
            }

        }
    }
}
