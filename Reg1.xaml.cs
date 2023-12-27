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
    /// Логика взаимодействия для Reg1.xaml
    /// </summary>
    public partial class Reg1 : Page
    {
        public Reg1()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            {
                if (DBConnect.entObj.User.Count(x => x.Name == Login.Text) > 0)
                {
                    MessageBox.Show("Такой пользователь уже есть",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                    return;
                }
                else
                {
                    try
                    {
                        User userObj = new User()
                        {
                            IdRole = 2,
                            Name = Login.Text,
                            Password = Password.Text
                        };
                        DBConnect.entObj.User.Add(userObj);
                        DBConnect.entObj.SaveChanges();
                        MessageBox.Show("Пользователь создан",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(), "Критический сбой работы приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
            }
        }

        private void Button_Voiti_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Voiti1());
        }
    }
}
