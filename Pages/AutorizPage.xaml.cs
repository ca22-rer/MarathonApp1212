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
//using Marathon2.Aplication;

namespace Marathon2.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizPage.xaml
    /// </summary>
    public partial class AutorizPage : Page
    {
        public AutorizPage()
        {
            InitializeComponent();
            
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var admin = "admin";

            var email = EmailTexboxPag3.Text;
            var pass = PasswordPag3.Password;
            var db = new Aplication.MarathonSkillsEntities();
            // var user = db.User.Where(u => u.Email == email && u.Password == pass).FirstOrDefault();
            var runner = db.Runner.Where(r => r.Email == email && r.User.Password == pass).FirstOrDefault();
            
            /*
              if (user != null)
            {
              
              var p = new ProfilePage(user);
               this.NavigationService.Navigate(new ProfilePage(user));
               */
            if (runner != null)
            {
                var p = new RannerPage(runner);
                this.NavigationService.Navigate(new RannerPage(runner));

            }
            if (email == admin & pass == admin)
            {
                this.NavigationService.Navigate(new Pages.MenuAdminPage());
                //MFrame.MaFrame.Navigate(new Pages.MenuAdminPage());

            }
            else
            {
                MessageBox.Show(" Не найден ");
            }



            // this.NavigationService.GoBack();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

    }
}
