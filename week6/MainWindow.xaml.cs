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

namespace week6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DelegateExample d;
        public MainWindow()
        {
            InitializeComponent();
            d = new DelegateExample(tb_delegate);
            DelegateExample delegateExample2 = new DelegateExample(tb_delegate, new List<int>());

            MyPrinter printer = new MyPrinter();
            UserTechnian technian = new UserTechnian(printer);
            UserManager manager = new UserManager(printer);

        }

        private void byeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
