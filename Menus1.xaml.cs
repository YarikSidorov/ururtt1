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
    /// Логика взаимодействия для Menus1.xaml
    /// </summary>
    public partial class Menus1 : Page
    {
        public Menus1()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Zapis1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Spisok1());
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Reg1());
        }
    }
}
