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
    /// Interaction logic for DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        private object obj;
        private string objName;

        public DeleteWindow()
        {
            InitializeComponent();
        }

        public DeleteWindow(object t_obj,string t_objname)
        {
            InitializeComponent();
            obj = t_obj;
            objName = t_objname;
            switch (objName)
            {
                case "User":
                {
                    TextBox_ObjectInfo.Text = obj.ToString();
                } break;
                case "ObjOfTransact":
                {
                    TextBox_ObjectInfo.Text = obj.ToString();
                } break;
                case "Deal":
                {
                    TextBox_ObjectInfo.Text = obj.ToString();
                } break;
            }
            
        }

        private void Button_Yes_Click(object sender, RoutedEventArgs e)
        {
            switch (objName)
            {
                case "User":
                {
                    using (var data = new DataServiceClient())
                    {
                        data.DeleteUser((ViewUser)obj);
                    }
                }break;
                case "ObjOfTransact":
                {
                    using (var data = new DataServiceClient())
                    {
                        data.DeleteObjectOfTransaction((ViewObjOfTransact)obj);
                    }
                }break;
                case "Deal":
                {
                    using (var data = new DataServiceClient())
                    {
                        data.DeleteDeal((ViewDeal)obj);
                    }
                }break;
            }
            this.Close();
        }

        private void Button_No_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
