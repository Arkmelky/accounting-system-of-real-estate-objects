using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DbModels
{
    //[Serializable]
    [Table("Deals")]
    public class Deal
    {
        [Key]
        public int DealID { get; set; }
        [Required]
        public int Seller_UserID { get; set; }
        [Required]
        public int Buyer_UserID { get; set; }
        [Required]
        public int KindOfCalculatingID { get; set; }
        [Required]
        public int ObjectOfTransactionID { get; set; }

        [Required]
        public string PersonalNumberOfDeal { get; set; }
        [Required]
        public DateTime DateOfDeal { get; set; }
        [Required]
        public decimal TransactionAmount { get; set; }


        public virtual ObjectOfTransaction ObjectOfTransaction { get; set; }
        public virtual User Seller { get; set; }
        public virtual User Buyer { get; set; }

        //public KindOfCalculating KindOfCalculating { get; set; }
        //public EnumKindOfCalculating KindOfCalculating { get; set; }
    }
}
