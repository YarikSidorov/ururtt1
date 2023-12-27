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

namespace ururtt
{
    /// <summary>
    /// Логика взаимодействия для Menu1.xaml
    /// </summary>
    public partial class Menu1 : Page
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Dobav1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Udal1());
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Sobes1());
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Spisokkk1());
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Reg1());
        }

    }
}
