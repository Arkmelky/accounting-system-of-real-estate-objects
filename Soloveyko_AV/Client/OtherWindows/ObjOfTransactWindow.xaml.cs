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
using System.Windows.Shapes;
using Client.DataAccessService;
using Entities.SupportEntities;
using Entities.ViewModels;

namespace Client.OtherWindows
{
    /// <summary>
    /// Interaction logic for ObjOfTransactWindow.xaml
    /// </summary>
    public partial class ObjOfTransactWindow : Window
    {
        private ViewObjOfTransact objOfTransact;

        public ObjOfTransactWindow()
        {
            InitializeComponent();
        }

        public ObjOfTransactWindow(ViewObjOfTransact obj)
        {
            InitializeComponent();

            objOfTransact = obj;
            using (var data = new DataServiceClient())
            {
                ComboBox_UserId.ItemsSource = data.GetUsersId().ToList();
            }

            ComboBox_UserId.Text = objOfTransact.UserID.ToString();
            ComboBox_ObjectType.ItemsSource = Enum.GetValues(typeof(EnumObjectType));
            ComboBox_ObjectType.SelectedIndex = 0;
            ComboBox_ServiceType.ItemsSource = Enum.GetValues(typeof(EnumServiceType));
            ComboBox_ServiceType.SelectedIndex = 0;
            ComboBox_KindOfCalc.ItemsSource = Enum.GetValues(typeof(EnumKindOfCalculating));
            ComboBox_KindOfCalc.SelectedIndex = 0;
            ComboBox_ObjectState.ItemsSource = Enum.GetValues(typeof(EnumObjectState));
            ComboBox_ObjectState.SelectedIndex = 0;

            TextBox_Cost.Text = objOfTransact.Cost.ToString();
            TextBox_Description.Text = objOfTransact.Description;

            if (obj.ObjectOfTransactionID > 0)
            {
                Button_Correct.IsEnabled = true;
                Button_Add.IsEnabled = false;
            }else
            {
                Button_Correct.IsEnabled = false;
                Button_Add.IsEnabled = true;
            }
            
        }

        private void Button_Correct_Click(object sender, RoutedEventArgs e)
        {
            PrepareObject();
            try
            {
                using (var data = new DataServiceClient())
                {
                    data.UpdateObjectOfTransaction(objOfTransact);
                }
                MessageBox.Show("Transaction successful !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
            this.Close();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            PrepareObject();
            try
            {
                using (var data = new DataServiceClient())
                {
                    data.AddObjectOfTransaction(objOfTransact);
                }
                MessageBox.Show("Transaction successful !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error !");
            }
            this.Close();
        }

        private void PrepareObject()
        {
            int temp = 0;
            decimal dec = 0;
            int.TryParse(ComboBox_UserId.Text, out temp);
            objOfTransact.UserID = temp;

            objOfTransact.ObjectType = (EnumObjectType)Enum.Parse(typeof(EnumObjectType), ComboBox_ObjectType.Text);
            objOfTransact.ServiceType = (EnumServiceType)Enum.Parse(typeof(EnumServiceType), ComboBox_ServiceType.Text);
            objOfTransact.KindOfCalculating = (EnumKindOfCalculating)Enum.Parse(typeof(EnumKindOfCalculating), ComboBox_KindOfCalc.Text);
            objOfTransact.ObjectState = (EnumObjectState)Enum.Parse(typeof(EnumObjectState), ComboBox_ObjectState.Text); ;

            decimal.TryParse(TextBox_Cost.Text, out dec);
            objOfTransact.Cost = dec;
            objOfTransact.Description = TextBox_Description.Text;
        }
    }
}
