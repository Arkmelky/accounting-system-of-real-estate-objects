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
    [Table("ObjectOfTransactions")]
    public class ObjectOfTransaction
    {
        [Key]
        public int ObjectOfTransactionID { get; set; }
        [Required]
        public int UserID { get; set; }

        [Required]
        public int ObjectTypeID { get; set; }
        [Required]
        public int ServiceTypeID { get; set; }
        [Required]
        public int KindOfCalculatingID { get; set; }
        [Required]
        public int ObjectStateID { get; set; }

        [Required]
        public decimal Cost { get; set; }
        [Required]
        public string Description { get; set; }

        public virtual User User { get; set; }

        public override string ToString()
        {
            return "ID: " + ObjectOfTransactionID +
                   "\nCost: " + Cost +
                   "\nDescription: " + Description;
        }

        //public ObjectType ObjectType { get; set; }
        //public ServiceType ServiceType { get; set; }
        //public KindOfCalculating KindOfCalculating { get; set; }
        //public ObjectState ObjectState { get; set; }

        //public EnumObjectType ObjectType { get; set; }
        //public EnumServiceType ServiceType { get; set; }
        //public EnumKindOfCalculating KindOfCalculating { get; set; }
        //public EnumObjectState ObjectState { get; set; }
        
    }
}
