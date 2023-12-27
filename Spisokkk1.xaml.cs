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
using ururtt.DB;

namespace ururtt
{
    /// <summary>
    /// Логика взаимодействия для Spisokkk1.xaml
    /// </summary>
    public partial class Spisokkk1 : Page
    {
        public Spisokkk1()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Menu1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            DGRU2.ItemsSource = DBConnect.entObj.Procedure.ToList();


        }

        private void DGRU2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
