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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frmobj = frmmain;
            frmmain.Navigate(new Reg1());
            DBConnect.entObj = new krikduchiEntities();
        }

        public object NavigationService { get; private set; }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Voiti_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
