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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ToRegPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegPage());
        }

        private void ToRunnerTableButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AutorizPage());
        }

        private void ToAutorizPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RunnerTablePage());
        }

        private void ToRegPageButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
