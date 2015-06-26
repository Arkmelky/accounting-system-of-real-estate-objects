using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Client.DataAccessService;
using Entities.ChartModels;
using Entities.SupportEntities;

namespace Client.ChartForm
{
    
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
            textBox_Apartment.Enabled = false;
            textBox_CommProp.Enabled = false;
            textBox_Homestead.Enabled = false;
            textBox_House.Enabled = false;
        }

        private void Button_GenerateChart_Click(object sender, EventArgs e)
        {
            ChartOfProfit.Series.Clear();
            //ChartOfProfit.Legends.Clear();
            ChartOfProfit.ResetAutoValues();
            
            //DateTime.TryParse();
            using (var service = new DataServiceClient())
            {
                var chartData = service.GetSummaryOfProfits(new DataAccessService.ChartRequestObject
                {
                    from = dateTimePicker_FROM.Value,
                    to = dateTimePicker_TO.Value
                });
                //DateTime.Now.AddYears(-1), DateTime.Now.AddYears(-1))};

                Series house = ChartOfProfit.Series.Add(EnumObjectType.House.ToString());
                house.Label = EnumObjectType.House.ToString();
                house.Points.AddXY(1, chartData.HouseProfit);
                textBox_House.Text = chartData.HouseProfit.ToString();

                Series homestead = ChartOfProfit.Series.Add(EnumObjectType.Homestead.ToString());
                homestead.Label = EnumObjectType.Homestead.ToString();
                homestead.Points.AddXY(1, chartData.HomesteadProfit);
                textBox_Homestead.Text = chartData.HomesteadProfit.ToString();

                Series commercialProp = ChartOfProfit.Series.Add(EnumObjectType.CommercialProperty.ToString());
                commercialProp.Label = EnumObjectType.CommercialProperty.ToString();
                commercialProp.Points.AddXY(1, chartData.CommercialPropertyProfit);
                textBox_CommProp.Text = chartData.CommercialPropertyProfit.ToString();

                Series apartment = ChartOfProfit.Series.Add(EnumObjectType.Apartment.ToString());
                apartment.Label = EnumObjectType.Apartment.ToString();
                apartment.Points.AddXY(1, chartData.ApartmentProfit);
                textBox_Apartment.Text = chartData.ApartmentProfit.ToString();
            }

            //ChartOfProfit.DataSource = list;
        }
    }
}

/*
 * Series house = ChartOfProfit.Series.Add(EnumObjectType.House.ToString());
            house.Label = EnumObjectType.House.ToString();
            house.Points.AddXY(1,10);
            Series homestead = ChartOfProfit.Series.Add(EnumObjectType.Homestead.ToString());
            homestead.Label = EnumObjectType.Homestead.ToString();
            homestead.Points.AddXY(2,20);
            Series commercialProp = ChartOfProfit.Series.Add(EnumObjectType.CommercialProperty.ToString());
            commercialProp.Label = EnumObjectType.CommercialProperty.ToString();
            commercialProp.Points.AddXY(3,30);
            Series apartment = ChartOfProfit.Series.Add(EnumObjectType.Apartment.ToString());
            apartment.Label = EnumObjectType.Apartment.ToString();
            apartment.Points.AddXY(4,40);
 */