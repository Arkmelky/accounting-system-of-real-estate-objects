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
            UpdateData();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            if (TabItem_Users.IsSelected)
            {
                var user = new ViewUser();
                var userWindow = new UserWindow(user);
                userWindow.ShowDialog();
                UpdateUsers();
            }
            else if(TabItem_ObjOfTransact.IsSelected)
            {
                var objOfTransact = new ViewObjOfTransact();
                var objOfTransactWindow = new ObjOfTransactWindow(objOfTransact);
                objOfTransactWindow.ShowDialog();
                UpdateObjectOfTransaction();
            }
            else if(TabItem_Deals.IsSelected)
            {
                var viewDeal = new ViewDeal();
                var dealWindow = new DealWindow(viewDeal);
                dealWindow.ShowDialog();
                UpdateDeals();
            }
        }

        private void UpdateData()
        {
            using (var dataAccess = new DataServiceClient())
            {
                DataGrid_Users.ItemsSource = dataAccess.GetUsers().ToList();
                DataGrid_Users.IsReadOnly = true;

                DataGrid_ObjOfTransact.ItemsSource = dataAccess.GetObjectOfTransactions();
                DataGrid_ObjOfTransact.IsReadOnly = true;
                
                DataGrid_Deals.ItemsSource = dataAccess.GetDeals();
                DataGrid_Deals.IsReadOnly = true;
            } 
        }
        private void UpdateUsers()
        {
            using (var dataAccess = new DataServiceClient())
            {
                DataGrid_Users.ItemsSource = dataAccess.GetUsers().ToList();
                DataGrid_Users.IsReadOnly = true;
            }
        }
        private void UpdateDeals()
        {
            using (var dataAccess = new DataServiceClient())
            {
                DataGrid_Deals.ItemsSource = dataAccess.GetDeals();
                DataGrid_Deals.IsReadOnly = true;
            }
        }
        private void UpdateObjectOfTransaction()
        {
            using (var dataAccess = new DataServiceClient())
            {
                DataGrid_ObjOfTransact.ItemsSource = dataAccess.GetObjectOfTransactions();
                DataGrid_ObjOfTransact.IsReadOnly = true;
            }
        }
    }
}
