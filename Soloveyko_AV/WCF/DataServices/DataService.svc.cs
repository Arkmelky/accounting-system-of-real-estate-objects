﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataAccess;
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

        public List<int> GetUsersId()
        {
            return DataManager.GetUsersId();
        }
        public List<int> GetObjOfTransactId()
        {
            return DataManager.GetObjOfTransactId();
        }
    }
}
