using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities.ChartModels;
using Entities.DbModels;
using Entities.ViewModels;

namespace WCF.DataServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDataService" in both code and config file together.
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        List<ViewDeal> GetDeals();
        [OperationContract]
        List<ViewUser> GetUsers();
        [OperationContract]
        List<ViewObjOfTransact> GetObjectOfTransactions();

        [OperationContract]
        Deal GetDealById(int id);
        [OperationContract]
        User GetUserById(int id);
        [OperationContract]
        ObjectOfTransaction GetObjectOfTransactionById(int id);

        [OperationContract]
        void AddDeal(ViewDeal deal);
        [OperationContract]
        void AddUser(ViewUser user);
        [OperationContract]
        void AddObjectOfTransaction(ViewObjOfTransact objectOfTransaction);

        [OperationContract]
        void DeleteDeal(ViewDeal deal);
        [OperationContract]
        void DeleteUser(ViewUser user);
        [OperationContract]
        void DeleteObjectOfTransaction(ViewObjOfTransact objectOfTransaction);

        [OperationContract]
        void UpdateDeal(ViewDeal deal);
        [OperationContract]
        void UpdateUser(ViewUser user);
        [OperationContract]
        void UpdateObjectOfTransaction(ViewObjOfTransact objectOfTransaction);

        [OperationContract]
        List<int> GetUsersId();
        [OperationContract]
        List<int> GetObjOfTransactId();

        [OperationContract]
        ChartData GetSummaryOfProfits(ChartRequestObject chartLetter);
    }
}
