using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.SupportEntities;

namespace Entities.ViewModels
{
    public class ViewDeal
    {
        public int DealID { get; set; }
        public int ObjectOfTransactionID { get; set; }
        public int Seller_UserID { get; set; }
        public int Buyer_UserID { get; set; }

        public string PersonalNumberOfDeal { get; set; }
        public string SellerInfo { get; set; }
        public string BuyerInfo { get; set; }
        public string ObjectOfTransactionInfo { get; set; }

        public EnumKindOfCalculating KindOfCalculatingID { get; set; }
        public DateTime DateOfDeal { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
