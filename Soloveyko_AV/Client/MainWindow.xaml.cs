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
using Client.DataAccessService;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var dataAccess = new DataServiceClient())
            {
                List<ViewUser> data;
                data = dataAccess.GetUsers().ToList();
                DataGrid_Users.ItemsSource = data;
                //DataGrid_Users.Columns[0].Visibility = Visibility.Hidden;

                DataGrid_ObjOfTransact.ItemsSource = dataAccess.GetObjectOfTransactions();
                //DataGrid_ObjOfTransact.Columns[0].Visibility = Visibility.Hidden;

                DataGrid_Deals.ItemsSource = dataAccess.GetDeals();
                //DataGrid_Deals.Columns[0].Visibility = Visibility.Hidden;

            } //DataGrid_Users.Columns[1].Visibility = Visibility.Collapsed;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
