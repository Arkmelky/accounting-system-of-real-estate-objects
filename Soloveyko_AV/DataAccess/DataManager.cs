using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.DbModels;

namespace DataAccess
{
    /// <summary>
    /// Static class for work with database
    /// </summary>
    public static class DataManager
    {
        //No Entity Framework provider found for the ADO.NET provider with invariant name 'System.Data.SqlClient'
        //Dont add EF to client side!!!

        /// <summary>
        /// Get collections of objects from Database
        /// </summary>
        /// <returns></returns>
        public static List<Deal> GetDealsFromDb()
        {
            using (var db = new DB_Context())
            {
                return db.Deals.ToList();
            }
        }
        public static List<User> GetUsersFromDb()
        {
            try
            {
                using (var db = new DB_Context())
                {
                    var some = db.Users.ToList();
                    return some;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static List<ObjectOfTransaction> GetObjectOfTransactionsFromDb()
        {
            using (var db = new DB_Context())
            {
                return db.ObjectOfTransactions.ToList();
            }
        }

        /// <summary>
        /// Get objects from database by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static Deal GetDealFromDbById(int Id)
        {
            using (var db = new DB_Context())
            {
                return db.Deals.Find(Id);
            }
        }
        public static User GetuUserFromDbById(int Id)
        {
            using (var db = new DB_Context())
            {
                return db.Users.Find(Id);
            }
        }
        public static ObjectOfTransaction GetObjectOfTransactionFromDbById(int Id)
        {
            using (var db = new DB_Context())
            {
                return db.ObjectOfTransactions.Find(Id);
            }
        }

        /// <summary>
        /// Add new objects to database
        /// </summary>
        /// <param name="deal"></param>
        public static void AddDealToDb(Deal deal)
        {
            using (var db = new DB_Context())
            {
                db.Deals.Add(deal);
                db.SaveChanges();
            }
        }
        public static void AddUserToDb(User user)
        {
            using (var db = new DB_Context())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        public static void AddObjectOfTransactionToDb(ObjectOfTransaction objectOfTransaction)
        {
            using (var db = new DB_Context())
            {
                db.ObjectOfTransactions.Add(objectOfTransaction);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete obj from database
        /// </summary>
        /// <param name="deal"></param>
        public static void DeleteDealFromDb(Deal deal)
        {
            using (var db = new DB_Context())
            {
                db.Deals.Remove(deal);
                db.SaveChanges();
            }
        }
        public static void DeleteUserFromDb(User user)
        {
            using (var db = new DB_Context())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        public static void DeleteObjectOfTransactionFromDb(ObjectOfTransaction objectOfTransaction)
        {
            using (var db = new DB_Context())
            {
                db.ObjectOfTransactions.Remove(objectOfTransaction);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update objects from database
        /// </summary>
        /// <param name="deal"></param>
        public static void UpdateDealFromDb(Deal deal)
        {
            using (var db = new DB_Context())
            {
                var d = db.Deals.Find(deal.DealID);

                d.Buyer_UserID = deal.Buyer_UserID;
                d.Seller_UserID = deal.Seller_UserID;
                d.DateOfDeal = deal.DateOfDeal;
                d.PersonalNumberOfDeal = deal.PersonalNumberOfDeal;
                d.TransactionAmount = deal.TransactionAmount;
                d.KindOfCalculatingID = deal.KindOfCalculatingID;
                d.ObjectOfTransactionID = deal.ObjectOfTransactionID;

                db.SaveChanges();

            }
        }
        public static void UpdateUserFromDb(User user)
        {
            using (var db = new DB_Context())
            {
                var u = db.Users.Find(user.UserID);

                u.Name = user.Name;
                u.Surname = user.Surname;
                u.PhoneNumber = user.PhoneNumber;
                u.Email = user.Email;

                db.SaveChanges();
            }
        }
        public static void UpdateObjectOfTransactionFromDb(ObjectOfTransaction objectOfTransaction)
        {
            using (var db = new DB_Context())
            {
                var obj = db.ObjectOfTransactions.Find(objectOfTransaction.ObjectOfTransactionID);
                obj.ObjectTypeID = objectOfTransaction.ObjectTypeID;
                obj.ServiceTypeID = objectOfTransaction.ServiceTypeID;
                obj.KindOfCalculatingID = objectOfTransaction.KindOfCalculatingID;
                obj.UserID = objectOfTransaction.UserID;
                obj.ObjectStateID = objectOfTransaction.ObjectStateID;
                obj.Cost = objectOfTransaction.Cost;
                obj.Description = objectOfTransaction.Description;

                db.SaveChanges();
            }
        }


    }
}
