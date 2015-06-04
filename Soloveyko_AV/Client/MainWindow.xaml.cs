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
using Client.OtherWindows;

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
                DataGrid_Users.ItemsSource = dataAccess.GetUsers().ToList();
                DataGrid_Users.IsReadOnly = true;
                //DataGrid_Users.Columns[0].Visibility = Visibility.Hidden;

                DataGrid_ObjOfTransact.ItemsSource = dataAccess.GetObjectOfTransactions();
                DataGrid_ObjOfTransact.IsReadOnly = true;
                //DataGrid_ObjOfTransact.Columns[0].Visibility = Visibility.Hidden;

                DataGrid_Deals.ItemsSource = dataAccess.GetDeals();
                DataGrid_Deals.IsReadOnly = true;
                //DataGrid_Deals.Columns[0].Visibility = Visibility.Hidden;

            } //DataGrid_Users.Columns[1].Visibility = Visibility.Collapsed;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if (TabItem_Users.IsSelected)
            {
                var user = new ViewUser();
                var userWindow = new UserWindow(user);
                userWindow.ShowDialog();

                using (var data = new DataServiceClient())
                {
                    data.AddUser(user);
                }
            }
            else if(TabItem_ObjOfTransact.IsSelected)
            {
                var objOfTransactWindow = new ObjOfTransactWindow();
                objOfTransactWindow.ShowDialog();
            }
            else if(TabItem_Deals.IsSelected)
            {
                var dealWindow = new DealWindow();
                dealWindow.ShowDialog();
            }
        }
    }
}
