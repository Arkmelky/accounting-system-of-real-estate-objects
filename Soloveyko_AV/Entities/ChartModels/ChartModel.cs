using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.SupportEntities;

namespace Entities.ChartModels
{
    public class ChartData
    {
        public decimal HouseProfit { get; set; }
        public decimal ApartmentProfit { get; set; }
        public decimal HomesteadProfit { get; set; }
        public decimal CommercialPropertyProfit { get; set; }

        public void SetValueByProp(EnumObjectType objectType,decimal value)
        {
            switch (objectType)
            {
                case EnumObjectType.Apartment:
                {
                    ApartmentProfit += value;
                }break;
                case EnumObjectType.CommercialProperty:
                {
                    CommercialPropertyProfit += value;
                }break;
                case EnumObjectType.Homestead:
                {
                    HomesteadProfit += value;
                }break;
                case EnumObjectType.House:
                {
                    HouseProfit += value;
                }break;
            }
        }
    }

    public class ChartRequestObject
    {
        //public int objType { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
    }
}
