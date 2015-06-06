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
using System.Windows.Shapes;
using Client.DataAccessService;

namespace Client.OtherWindows
{
    /// <summary>
    /// Interaction logic for DealWindow.xaml
    /// </summary>
    public partial class DealWindow : Window
    {
        private ViewDeal viewDeal;

        public DealWindow()
        {
            InitializeComponent();
        }

        public DealWindow(ViewDeal deal)
        {
            InitializeComponent();

            viewDeal = deal;

            using (var data = new DataServiceClient())
            {
                ComboBox_Seller.ItemsSource = data.GetUsersId();
                ComboBox_Buyer.ItemsSource = ComboBox_Seller.ItemsSource;
            }

            ComboBox_Buyer.IsEnabled = false;
            ComboBox_ObjOfTransact.IsEnabled = false;
            ComboBox_KindOfCalc.IsEnabled = false;
            TextBox_PersonalNumberOfDeal.IsEnabled = false;
            TextBox_DateOfDeal.IsEnabled = false;
            TextBox_TransactionAmount.IsEnabled = false;

            SetInfo();

            if (deal.DealID > 0)
            {
                Button_Correct.IsEnabled = true;
                Button_Add.IsEnabled = false;
            }
            else
            {
                Button_Correct.IsEnabled = false;
                Button_Add.IsEnabled = true;
            }
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrepareObject();
                using (var data = new DataServiceClient())
                {
                    data.AddDeal(viewDeal);
                }
                MessageBox.Show("Transaction successful !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !");
            }
        }

        private void Button_Correct_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PrepareObject();
                using (var data = new DataServiceClient())
                {
                    data.UpdateDeal(viewDeal);
                }
                MessageBox.Show("Transaction successful !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
        }

        

        private void ComboBox_Seller_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ComboBox_Seller.Text != "")
            {
                ActivateTools();

                int id;
                int.TryParse(ComboBox_Seller.Text,out id);
                ComboBox_ObjOfTransact.ItemsSource = null;

                using (var data = new DataServiceClient())
                {
                    var temp = data.GetObjectOfTransactions();
                    var source = temp.Where(x => x.UserID == id).Select(x => x.ObjectOfTransactionID);
                    ComboBox_ObjOfTransact.ItemsSource = source;
                }
            }
        }

        private void PrepareObject()
        {
            int id;
            decimal dec;
            int.TryParse(ComboBox_Seller.Text, out id);
            viewDeal.Seller_UserID = id;
            int.TryParse(ComboBox_Buyer.Text, out id);
            viewDeal.Buyer_UserID = id;
            int.TryParse(ComboBox_ObjOfTransact.Text, out id);
            viewDeal.ObjectOfTransactionID = id;

            viewDeal.KindOfCalculatingID = (EnumKindOfCalculating)Enum.Parse(typeof(EnumKindOfCalculating), ComboBox_KindOfCalc.Text);
            viewDeal.PersonalNumberOfDeal = TextBox_PersonalNumberOfDeal.Text;
            viewDeal.DateOfDeal = DateTime.Parse(TextBox_DateOfDeal.Text);

            decimal.TryParse(TextBox_TransactionAmount.Text, out dec);
            viewDeal.TransactionAmount = dec;
        }

        private void ActivateTools()
        {
            ComboBox_Buyer.IsEnabled = true;
            ComboBox_ObjOfTransact.IsEnabled = true;
            ComboBox_KindOfCalc.IsEnabled = true;
            TextBox_PersonalNumberOfDeal.IsEnabled = true;
            TextBox_DateOfDeal.IsEnabled = true;
            TextBox_TransactionAmount.IsEnabled = true;
        }

        private void SetInfo()
        {
            ComboBox_Seller.Text = viewDeal.Seller_UserID.ToString();
            ComboBox_Buyer.Text = viewDeal.Buyer_UserID.ToString();
            ComboBox_ObjOfTransact.Text = viewDeal.ObjectOfTransactionID.ToString();

            ComboBox_KindOfCalc.ItemsSource = Enum.GetValues(typeof(EnumKindOfCalculating));
            ComboBox_KindOfCalc.Text = Enum.GetName(typeof(EnumKindOfCalculating), viewDeal.KindOfCalculatingID);

            TextBox_DateOfDeal.Text = DateTime.Now.ToString();

            TextBox_PersonalNumberOfDeal.Text = viewDeal.PersonalNumberOfDeal;
            TextBox_TransactionAmount.Text = viewDeal.TransactionAmount.ToString();
        }
    }
}

/*
 
            
 
 
 */