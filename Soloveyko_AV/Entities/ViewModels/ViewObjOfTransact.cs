using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.SupportEntities;

namespace Entities.ViewModels
{
    public class ViewObjOfTransact
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
    }
}
