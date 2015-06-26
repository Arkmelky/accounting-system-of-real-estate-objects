using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess;
using Entities.ChartModels;
using Entities.DbModels;
using Entities.ObjectConverter;
using Entities.ViewModels;

namespace WCF.DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DataService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DataService.svc or DataService.svc.cs at the Solution Explorer and start debugging.
    public class DataService : IDataService
    {
        public List<ViewDeal> GetDeals()
        {
            
            return ViewConverter.ConvertListOfDeals(DataManager.GetDealsFromDb());
        }
        public List<ViewUser> GetUsers()
        {
            return ViewConverter.ConverListOfUsers(DataManager.GetUsersFromDb());
                //List<User> {new User{UserID = 1,Name = "123",Surname = "123",PhoneNumber = "123",Email = "123"}}; //
        }
        public List<ViewObjOfTransact> GetObjectOfTransactions()
        {
            return ViewConverter.ConvertListObjOfTransacts(DataManager.GetObjectOfTransactionsFromDb());
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

        public void AddDeal(ViewDeal deal)
        {
            DataManager.AddDealToDb(DbConverter.ConvertDeal(deal));
        }
        public void AddUser(ViewUser user)
        {
            DataManager.AddUserToDb(DbConverter.ConvertUser(user));
        }
        public void AddObjectOfTransaction(ViewObjOfTransact objectOfTransaction)
        {
            DataManager.AddObjectOfTransactionToDb(DbConverter.ConverObjOfTransaction(objectOfTransaction));
        }

        public void DeleteDeal(ViewDeal deal)
        {
            DataManager.DeleteDealFromDb(DbConverter.ConvertDeal(deal));
        }
        public void DeleteUser(ViewUser user)
        {
            DataManager.DeleteUserFromDb(DbConverter.ConvertUser(user));
        }
        public void DeleteObjectOfTransaction(ViewObjOfTransact objectOfTransaction)
        {
            DataManager.DeleteObjectOfTransactionFromDb(DbConverter.ConverObjOfTransaction(objectOfTransaction));
        }

        public void UpdateDeal(ViewDeal deal)
        {
            DataManager.UpdateDealFromDb(DbConverter.ConvertDeal(deal));
        }
        public void UpdateUser(ViewUser user)
        {
            DataManager.UpdateUserFromDb(DbConverter.ConvertUser(user));
        }
        public void UpdateObjectOfTransaction(ViewObjOfTransact objectOfTransaction)
        {
            DataManager.UpdateObjectOfTransactionFromDb(DbConverter.ConverObjOfTransaction(objectOfTransaction));
        }

        public List<int> GetUsersId()
        {
            return DataManager.GetUsersId();
        }
        public List<int> GetObjOfTransactId()
        {
            return DataManager.GetObjOfTransactId();
        }

        public ChartData GetSummaryOfProfits(ChartRequestObject chartLetter)
        {
            return DataManager.GetSummaryOfProfits(chartLetter);
        }
    }
}
