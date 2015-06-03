using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess;
using Entities.DbModels;

namespace WCF.DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DataService.svc or DataService.svc.cs at the Solution Explorer and start debugging.
    public class DataService : IDataService
    {
        public IQueryable<Deal> GetDeals()
        {
            return DataManager.GetDealsFromDb();
        }
        public List<User> GetUsers()
        {
            return DataManager.GetUsersFromDb();
        }
        public IQueryable<ObjectOfTransaction> GetObjectOfTransactions()
        {
            return DataManager.GetObjectOfTransactionsFromDb();
        }

        public Deal GetDealById(int id)
        {
            return DataManager.GetDealFromDbById(id);
        }
        public User GetUserById(int id)
        {
            return DataManager.GetuUserFromDbById(id);
        }
        public ObjectOfTransaction GetObjectOfTransactionById(int id)
        {
            return DataManager.GetObjectOfTransactionFromDbById(id);
        }

        public void AddDeal(Deal deal)
        {
            DataManager.AddDealToDb(deal);
        }
        public void AddUser(User user)
        {
            DataManager.AddUserToDb(user);
        }
        public void AddObjectOfTransaction(ObjectOfTransaction objectOfTransaction)
        {
            DataManager.AddObjectOfTransactionToDb(objectOfTransaction);
        }

        public void DeleteDeal(Deal deal)
        {
            DataManager.DeleteDealFromDb(deal);
        }
        public void DeleteUser(User user)
        {
            DataManager.DeleteUserFromDb(user);
        }
        public void DeleteObjectOfTransaction(ObjectOfTransaction objectOfTransaction)
        {
            DataManager.DeleteObjectOfTransactionFromDb(objectOfTransaction);
        }

        public void UpdateDeal(Deal deal)
        {
            DataManager.UpdateDealFromDb(deal);
        }
        public void UpdateUser(User user)
        {
            DataManager.UpdateUserFromDb(user);
        }
        public void UpdateObjectOfTransaction(ObjectOfTransaction objectOfTransaction)
        {
            DataManager.UpdateObjectOfTransactionFromDb(objectOfTransaction);
        }
    }
}
