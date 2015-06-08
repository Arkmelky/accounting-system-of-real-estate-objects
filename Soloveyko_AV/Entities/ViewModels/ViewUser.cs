using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public partial class ViewUser
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return "UserID: " + UserID +
                "\nName: " + Name +
                "\nSurname: " + Surname +
                "\nPhoneNumber: " + PhoneNumber +
                "\nEmail: " + Email;
        }

        public string AsString()
        {
            return "UserID: " + UserID +
                "\nName: " + Name +
                "\nSurname: " + Surname +
                "\nPhoneNumber: " + PhoneNumber +
                "\nPhoneNumber: " + PhoneNumber +
                "\nEmail: " + Email;
        }
    }
}
