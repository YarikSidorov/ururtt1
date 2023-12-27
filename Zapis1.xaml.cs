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
    /// Логика взаимодействия для Zapis1.xaml
    /// </summary>
    public partial class Zapis1 : Page
    {
        public Zapis1()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Menus1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            try
            {
                ZapisProcedur probj = new ZapisProcedur()
                {

                    Fam = Login2.Text,
                    Name = Login.Text,
                    Sot = Login3.Text
                };
                DBConnect.entObj.ZapisProcedur.Add(probj);
                DBConnect.entObj.SaveChanges();
                MessageBox.Show("Вы записались на процедуру");
            }
            catch
            {

            }
        }
    }
}
