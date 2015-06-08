using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.SupportEntities;

namespace Entities.ViewModels
{
    public partial class ViewObjOfTransact
    {
        public int ObjectOfTransactionID { get; set; }
        public int UserID { get; set; }
        public string UserInfo { get; set; }

        public EnumObjectType ObjectType { get; set; }
        public EnumServiceType ServiceType { get; set; }
        public EnumKindOfCalculating KindOfCalculating { get; set; }
        public EnumObjectState ObjectState { get; set; }

        public decimal Cost { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return "ObjectOfTransactionID: " + ObjectOfTransactionID +
                "\nUserInfo: " + UserInfo +
                "\nObjectType: " + ObjectType +
                "\nServiceType: " + ServiceType +
                "\nKindOfCalculating: " + KindOfCalculating +
                "\nObjectState: " + ObjectState +
                "\nCost: " + Cost +
                "\nDescription: " + Description;
        }

        public string AsString()
        {
            return "ObjectOfTransactionID: " + ObjectOfTransactionID +
               "\nUserInfo: " + UserInfo +
               "\nObjectType: " + ObjectType +
               "\nServiceType: " + ServiceType +
               "\nKindOfCalculating: " + KindOfCalculating +
               "\nObjectState: " + ObjectState +
               "\nCost: " + Cost +
               "\nDescription: " + Description;
        }
    }
}
