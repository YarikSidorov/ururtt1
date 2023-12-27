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
    /// Логика взаимодействия для Voiti1.xaml
    /// </summary>
    public partial class Voiti1 : Page
    {
        public Voiti1()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Reg1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    var userObj = DBConnect.entObj.User.FirstOrDefault(x =>x.Name == Login.Text && x.Password == Password.Text);

                    if (userObj == null)
                    {
                        MessageBox.Show("Такого пользователя нет", "Ошибка Авторизации",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                        Uri uri = new Uri("Reg1.xaml", UriKind.Relative);
                        this.NavigationService.Navigate(uri);
                    }
                    else if (userObj.IdRole == 1)
                    {

                        MessageBox.Show("Здравствуйте , " + userObj.Name + " !", "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                        Uri uri = new Uri("Menu1.xaml", UriKind.Relative);
                        this.NavigationService.Navigate(uri);

                    }
                    else
                    {
                        MessageBox.Show("Здравствуйте , " + userObj.Name + " !", "Уведомление",
                                MessageBoxButton.OK, MessageBoxImage.Information);
                        Uri uri = new Uri("Menus1.xaml", UriKind.Relative);
                        this.NavigationService.Navigate(uri);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message.ToString(), "Критическая работа приложения",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            
        }
    }
}
