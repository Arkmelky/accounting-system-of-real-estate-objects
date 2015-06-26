using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Client.AdditionalFunctionality;
using Client.ChartForm;
using Client.DataAccessService;
using Client.OtherWindows;
using Entities.ViewModels;

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

            TextBox_SearchValue.IsEnabled = false;
            Button_Search.IsEnabled = false;
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
                DataGrid_Users.ItemsSource = dataAccess.GetUsers();
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

        private void Button_Click_Correct(object sender, RoutedEventArgs e)
        {
            if (TabItem_Users.IsSelected )
            {
                if (DataGrid_Users.SelectedItem != null)
                {
                    var user = (ViewUser)DataGrid_Users.SelectedItem;
                    var userWindow = new UserWindow(user);
                    userWindow.ShowDialog();
                    UpdateUsers();
                }
                else
                {
                    MessageBox.Show("Select some item!");
                }
                
            }
            else if (TabItem_ObjOfTransact.IsSelected)
            {
                if (DataGrid_ObjOfTransact.SelectedItem != null)
                {
                    var objOfTransact = (ViewObjOfTransact)DataGrid_ObjOfTransact.SelectedItem;
                    var objOfTransactWindow = new ObjOfTransactWindow(objOfTransact);
                    objOfTransactWindow.ShowDialog();
                    UpdateObjectOfTransaction();
                }
                else
                {
                    MessageBox.Show("Select some item!");
                }
                
            }
            else if (TabItem_Deals.IsSelected)
            {
                if (DataGrid_Deals.SelectedItem != null)
                {
                    var viewDeal = (ViewDeal)DataGrid_Deals.SelectedItem;
                    var dealWindow = new DealWindow(viewDeal);
                    dealWindow.ShowDialog();
                    UpdateDeals();
                }
                else
                {
                    MessageBox.Show("Select some item!");
                }
                
            }
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            if (TabItem_Users.IsSelected)
            {
                if (DataGrid_Users.SelectedItem != null)
                {
                    var user = (ViewUser)DataGrid_Users.SelectedItem;
                    var deleteWindow = new DeleteWindow(user,"User");
                    deleteWindow.ShowDialog();
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Select some item!");
                }

            }
            else if (TabItem_ObjOfTransact.IsSelected)
            {
                if (DataGrid_ObjOfTransact.SelectedItem != null)
                {
                    var objOfTransact = (ViewObjOfTransact)DataGrid_ObjOfTransact.SelectedItem;
                    var deleteWindow = new DeleteWindow(objOfTransact, "ObjOfTransact");
                    deleteWindow.ShowDialog();
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Select some item!");
                }

            }
            else if (TabItem_Deals.IsSelected)
            {
                if (DataGrid_Deals.SelectedItem != null)
                {
                    var deal = (ViewDeal)DataGrid_Deals.SelectedItem;
                    var deleteWindow = new DeleteWindow(deal, "Deal");
                    deleteWindow.ShowDialog();
                    UpdateData();
                }
                else
                {
                    MessageBox.Show("Select some item!");
                }

            }
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            if (TabItem_Users.IsSelected)
            {
                if (TextBox_SearchValue.Text != "")
                {
                    List<ViewUser> list = new List<ViewUser>();
                    using (var db = new DataServiceClient())
                    {
                        foreach (var item in db.GetUsers())
                        {
                            if (SearchHelper.CompareStrings(TextBox_SearchValue.Text, item.AsString()))
                            {
                                list.Add(item);
                            }
                        }
                    }
                    DataGrid_Users.ItemsSource = list;
                }
                else
                {
                    MessageBox.Show("Enter some value");
                }

            }
            else if (TabItem_ObjOfTransact.IsSelected)
            {
                if (TextBox_SearchValue.Text != "")
                {
                    List<ViewObjOfTransact> list = new List<ViewObjOfTransact>();
                    using (var db = new DataServiceClient())
                    {
                        foreach (var item in db.GetObjectOfTransactions())
                        {
                            if (SearchHelper.CompareStrings(TextBox_SearchValue.Text, item.AsString()))
                            {
                                list.Add(item);
                            }
                        }
                    }
                    DataGrid_ObjOfTransact.ItemsSource = list;
                }
                else
                {
                    MessageBox.Show("Enter some value");
                }

            }
            else if (TabItem_Deals.IsSelected)
            {
                if (TextBox_SearchValue.Text != "")
                {
                    List<ViewDeal> list = new List<ViewDeal>();
                    using (var db = new DataServiceClient())
                    {
                        foreach (var item in db.GetDeals())
                        {
                            if (SearchHelper.CompareStrings(TextBox_SearchValue.Text, item.AsString()))
                            {
                                list.Add(item);
                            }
                        }
                    }
                    DataGrid_Deals.ItemsSource = list;
                }
                else
                {
                    MessageBox.Show("Enter some value");
                }

            }
        }

        private void CheckBox_ActivateSearch_Click(object sender, RoutedEventArgs e)
        {
            if (CheckBox_ActivateSearch.IsChecked == true)
            {
                TextBox_SearchValue.IsEnabled = true;
                Button_Search.IsEnabled = true;
            }
            else
            {
                TextBox_SearchValue.IsEnabled = false;
                Button_Search.IsEnabled = false;

                UpdateData();
            }
        }

        private void Button_Chart_Click(object sender, RoutedEventArgs e)
        {
            var chart = new ChartForm.ChartForm();
            chart.ShowDialog();
        }
    }
}
