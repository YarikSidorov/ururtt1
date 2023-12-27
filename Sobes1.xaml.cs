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
    /// Логика взаимодействия для Sobes1.xaml
    /// </summary>
    public partial class Sobes1 : Page
    {
        public Sobes1()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Menu1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            try
            {
                Sobes probj = new Sobes()
                {

                    Fam = Login2.Text,
                    Name = Login.Text,
                    Adress = Login3.Text,
                    Phone = Login4.Text,
                    Prof = Login5.Text,
                    
                };
                DBConnect.entObj.Sobes.Add(probj);
                DBConnect.entObj.SaveChanges();
                MessageBox.Show("Данные записаны");
            }
            catch
            {

            }
        }
    }
}
