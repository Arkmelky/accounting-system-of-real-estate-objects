﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.ChartModels;
using Entities.DbModels;
using Entities.SupportEntities;

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
            try
            {
                using (var db = new DB_Context())
                {
                    db.Deals.Add(deal);
                    db.ObjectOfTransactions.Find(deal.ObjectOfTransactionID).ObjectStateID = 2;
                    db.SaveChanges();
                }
            }
            catch (Exception EX)
            {
                
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
                db.Deals.Remove(db.Deals.Find(deal.DealID));
                db.ObjectOfTransactions.Find(deal.ObjectOfTransactionID).ObjectStateID = 1;
                db.SaveChanges();
            }
        }
        public static void DeleteUserFromDb(User user)
        {
            using (var db = new DB_Context())
            {
                db.Users.Remove(db.Users.Find(user.UserID));
                db.SaveChanges();
            }
        }
        public static void DeleteObjectOfTransactionFromDb(ObjectOfTransaction objectOfTransaction)
        {
            using (var db = new DB_Context())
            {
                db.ObjectOfTransactions.Remove(db.ObjectOfTransactions.Find(objectOfTransaction.ObjectOfTransactionID));
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

                db.ObjectOfTransactions.Find(deal.ObjectOfTransactionID).ObjectStateID = 2;
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

        /// <summary>
        /// View hendler methods
        /// </summary>
        /// <returns></returns>
        public static List<int> GetUsersId()
        {
            using (var db = new DB_Context())
            {
                return db.Users.Select(x => x.UserID).ToList();
            }
        }
        public static List<int> GetObjOfTransactId()
        {
            using (var db = new DB_Context())
            {
                return db.ObjectOfTransactions.Select(x => x.ObjectOfTransactionID).ToList();
            }
        }

        public static ChartData GetSummaryOfProfits(ChartRequestObject chartLetter)
        {
            var chartData = new ChartData(); 
            var list = new List<int>();

            using (var db = new DB_Context())
            {
                foreach (var deal in db.Deals)
                {
                    if (deal.DateOfDeal >= chartLetter.from && deal.DateOfDeal <= chartLetter.to)
                    {
                        list.Add(deal.ObjectOfTransactionID);
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    var obj = GetObjectOfTransactionFromDbById(list[i]);
                    chartData.SetValueByProp((EnumObjectType)obj.ObjectTypeID,obj.Cost);
                }
            }
            return chartData;
        }
    }
}
