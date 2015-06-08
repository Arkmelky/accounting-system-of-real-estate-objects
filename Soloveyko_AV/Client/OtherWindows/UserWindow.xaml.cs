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
using Entities.ViewModels;

namespace Client.OtherWindows
{
    /// <summary>
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private ViewUser viewUser;

        public UserWindow()
        {
            InitializeComponent();
        }

        public UserWindow(ViewUser User)
        {
            InitializeComponent();

            viewUser = User;
            if (User.UserID > 0)
            {
                Button_Correct.IsEnabled = true;
                Button_Add.IsEnabled = false;

                TextBox_Name.Text = viewUser.Name;
                TextBox_Surname.Text = viewUser.Surname;
                TextBox_PhoneNumber.Text = viewUser.PhoneNumber;
                TextBox_Email.Text = viewUser.Email;
            }
            else
            {
                Button_Correct.IsEnabled = false;
                Button_Add.IsEnabled = true;
            }
            
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            PreapareObject();
            try
            {
                using (var data = new DataServiceClient())
                {
                    data.AddUser(viewUser);
                }
                MessageBox.Show("Transaction successful !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
            
            this.Close();
        }

        private void Button_Correct_Click(object sender, RoutedEventArgs e)
        {
            PreapareObject();
            try
            {
                using (var data = new DataServiceClient())
                {
                    data.UpdateUser(viewUser);
                }
                MessageBox.Show("Transaction successful !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
            
            this.Close();
        }

        private void PreapareObject()
        {
            viewUser.Name = TextBox_Name.Text;
            viewUser.Surname = TextBox_Surname.Text;
            viewUser.PhoneNumber = TextBox_PhoneNumber.Text;
            viewUser.Email = TextBox_Email.Text;
        }

    }
}
