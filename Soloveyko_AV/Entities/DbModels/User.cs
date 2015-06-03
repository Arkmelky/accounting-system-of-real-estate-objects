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
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }

        public ICollection<Deal> Deals;
        public ICollection<ObjectOfTransaction> ObjectOfTransactions;

        public override string ToString()
        {
            return UserID + Name + Surname + PhoneNumber + Email;
        }
    }
}
