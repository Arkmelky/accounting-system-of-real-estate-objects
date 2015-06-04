using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DbModels;
using Entities.SupportEntities;
using Entities.ViewModels;

namespace Entities.ObjectConverter
{
    public static class DbConverter
    {
        public static Deal ConvertDeal(ViewDeal viewDeal)
        {
            return new Deal
            {
                DealID = viewDeal.DealID,
                Buyer_UserID = viewDeal.Buyer_UserID,
                Seller_UserID = viewDeal.Seller_UserID,
                ObjectOfTransactionID = viewDeal.ObjectOfTransactionID,

                PersonalNumberOfDeal = viewDeal.PersonalNumberOfDeal,
                DateOfDeal = viewDeal.DateOfDeal,
                KindOfCalculatingID = (int)viewDeal.KindOfCalculatingID,
                TransactionAmount = viewDeal.TransactionAmount
            };
        }

        public static ObjectOfTransaction ConverObjOfTransaction(ViewObjOfTransact objOfTransact)
        {
            return new ObjectOfTransaction
            {
                ObjectOfTransactionID = objOfTransact.ObjectOfTransactionID,
                UserID = objOfTransact.UserID,

                ObjectTypeID = (int)objOfTransact.ObjectType,
                ServiceTypeID = (int)objOfTransact.ServiceType,
                KindOfCalculatingID = (int)objOfTransact.KindOfCalculating,
                ObjectStateID = (int)objOfTransact.ObjectState,

                Cost = objOfTransact.Cost,
                Description = objOfTransact.Description
            };
        }

        public static User ConvertUser(ViewUser viewUser)
        {
            return new User
            {
                UserID = viewUser.UserID,
                Name = viewUser.Name,
                Surname = viewUser.Surname,
                PhoneNumber = viewUser.PhoneNumber,
                Email = viewUser.Email
            };
        }


        public static List<User> ConverListOfUsers(List<ViewUser> listUsers)
        {
            var newList = new List<User>();
            foreach (var user in listUsers)
            {
                newList.Add(ConvertUser(user));
            }
            return newList;
        }

        public static List<Deal> ConvertListOfDeals(List<ViewDeal> listDeals)
        {
            var newList = new List<Deal>();
            foreach (var deal in listDeals)
            {
                newList.Add(ConvertDeal(deal));
            }
            return newList;
        }

        public static List<ObjectOfTransaction> ConvertObjectOfTransact(List<ViewObjOfTransact> listObjOfTransacts)
        {
            var newList = new List<ObjectOfTransaction>();
            foreach (var objOfTransact in listObjOfTransacts)
            {
                newList.Add(ConverObjOfTransaction(objOfTransact));
            }
            return newList;
        }
    }
}
