using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.DbModels;
using Entities.SupportEntities;
using Entities.ViewModels;

namespace Entities.ObjectConverter
{
    public static class ViewConverter
    {
        static public ViewDeal ConvertDeal(Deal deal)
        {

            return new ViewDeal
            {
                DealID = deal.DealID,
                ObjectOfTransactionID = deal.ObjectOfTransactionID,
                Seller_UserID = deal.Seller_UserID,
                Buyer_UserID = deal.Buyer_UserID,

                PersonalNumberOfDeal = deal.PersonalNumberOfDeal,
                SellerInfo = DataManager.GetuUserFromDbById(deal.Seller_UserID).ToString(),
                BuyerInfo = DataManager.GetuUserFromDbById(deal.Buyer_UserID).ToString(),
                ObjectOfTransactionInfo = DataManager.GetObjectOfTransactionFromDbById(deal.ObjectOfTransactionID).ToString(),

                KindOfCalculatingID = (EnumKindOfCalculating)deal.KindOfCalculatingID,
                DateOfDeal = deal.DateOfDeal,
                TransactionAmount = deal.TransactionAmount
            };
        }

        public static ViewUser ConvertUser(User user)
        {
            return new ViewUser
            {
                UserID = user.UserID,
                Name = user.Name,
                Surname = user.Surname,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email
            };
        }

        public static ViewObjOfTransact ConvertObjOfTransact(ObjectOfTransaction obj)
        {
            return new ViewObjOfTransact
            {
                ObjectOfTransactionID = obj.ObjectOfTransactionID,
                UserID = obj.UserID,
                UserInfo = DataManager.GetuUserFromDbById(obj.UserID).ToString(),
                
                ObjectType = (EnumObjectType)obj.ObjectTypeID,
                ObjectState = (EnumObjectState)obj.ObjectStateID,
                ServiceType = (EnumServiceType)obj.ServiceTypeID,
                KindOfCalculating = (EnumKindOfCalculating)obj.KindOfCalculatingID,

                Cost = obj.Cost,
                Description = obj.Description
            };
        }


        public static List<ViewDeal> ConvertListOfDeals(List<Deal> deals)
        {
            var viewDeals = new List<ViewDeal>();
            foreach (var deal in deals)
            {
                viewDeals.Add(ConvertDeal(deal));
            }

            return viewDeals;
        }

        public static List<ViewUser> ConverListOfUsers(List<User> users)
        {
            var viewUsers = new List<ViewUser>();
            foreach (var user in users)
            {
                viewUsers.Add(ConvertUser(user));
            }
            return viewUsers;
        }

        public static List<ViewObjOfTransact> ConvertListObjOfTransacts(List<ObjectOfTransaction> objectsOfTransact)
        {
            var viewObjOfTransact = new List<ViewObjOfTransact>();
            foreach (var obj in objectsOfTransact)
            {
                viewObjOfTransact.Add(ConvertObjOfTransact(obj));
            }
            return viewObjOfTransact;
        }
    }
}
