﻿using System;
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
    /// Логика взаимодействия для MenuAdminPage.xaml
    /// </summary>
    public partial class MenuAdminPage : Page
    {
        public MenuAdminPage()
        {
            InitializeComponent();
        }

        private void BlagOrgBtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.NavigationService.Navigate(new Pages.MenuUserPage());
            
        }

        private void InventBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.MenuUserPage());
        }

        private void UserBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.MenuUserPage());
        }

        private void VolontBtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.MenuUserPage());
            //MFrame.MaFrame.Navigate(new Pages.MenuUserPage());
        }
    }
}
