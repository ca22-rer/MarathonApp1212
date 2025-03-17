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

namespace Marathon2.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuUserPage.xaml
    /// </summary>
    public partial class MenuUserPage : Page
    {
        public MenuUserPage()
        {
            InitializeComponent();
            var runners = Core.DB.User.ToList();

            UserDtGrid.ItemsSource = runners;
           // UserDtGrid.ItemsSource = Core.DB.Country.ToList();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.RedactUserPage());
        }

        private void NewUserBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.DobUserPage());
        }
    }
}
