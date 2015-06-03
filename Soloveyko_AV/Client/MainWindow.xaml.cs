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
                DataGrid_Users.ItemsSource = dataAccess.GetUsers();
                DataGrid_ObjOfTransact.ItemsSource = dataAccess.GetObjectOfTransactions();
                DataGrid_Deals.ItemsSource = dataAccess.GetDeals();

            } //DataGrid_Users.Columns[1].Visibility = Visibility.Collapsed;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
