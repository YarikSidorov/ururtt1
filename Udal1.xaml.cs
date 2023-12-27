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
    /// Логика взаимодействия для Udal1.xaml
    /// </summary>
    public partial class Udal1 : Page
    {
        public Udal1()
        {
            InitializeComponent();
           
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmobj.Navigate(new Menu1());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var DocForRemoving = DGRU.SelectedItems.Cast<Procedure>().ToList();
            try
            {
                DBConnect.entObj.Procedure.RemoveRange(DocForRemoving);
                DBConnect.entObj.SaveChanges();
                MessageBox.Show("Данные удалены.");

                DGRU.ItemsSource = DBConnect.entObj.Procedure.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Подтвердите удаление " + ex.Message.ToString(),
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                DBConnect.entObj.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
                DGRU.ItemsSource = DBConnect.entObj.Procedure.ToList();
            }
        }
    }
}
