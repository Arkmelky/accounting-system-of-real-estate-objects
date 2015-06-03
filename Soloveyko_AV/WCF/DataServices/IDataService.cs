﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities.DbModels;

namespace WCF.DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        IQueryable<Deal> GetDeals();
        [OperationContract]
        List<User> GetUsers();
        [OperationContract]
        IQueryable<ObjectOfTransaction> GetObjectOfTransactions();

        [OperationContract]
        Deal GetDealById(int id);
        [OperationContract]
        User GetUserById(int id);
        [OperationContract]
        ObjectOfTransaction GetObjectOfTransactionById(int id);

        [OperationContract]
        void AddDeal(Deal deal);
        [OperationContract]
        void AddUser(User user);
        [OperationContract]
        void AddObjectOfTransaction(ObjectOfTransaction objectOfTransaction);

        [OperationContract]
        void DeleteDeal(Deal deal);
        [OperationContract]
        void DeleteUser(User user);
        [OperationContract]
        void DeleteObjectOfTransaction(ObjectOfTransaction objectOfTransaction);

        [OperationContract]
        void UpdateDeal(Deal deal);
        [OperationContract]
        void UpdateUser(User user);
        [OperationContract]
        void UpdateObjectOfTransaction(ObjectOfTransaction objectOfTransaction);
    }
}
