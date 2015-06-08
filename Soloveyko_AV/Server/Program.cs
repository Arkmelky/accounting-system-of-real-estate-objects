using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities.DbModels;
using Entities.SupportEntities;
using Entities.ViewModels;
using WCF.DataServices;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host1 = new ServiceHost(typeof(DataService), new Uri("http://localhost:8080/DataService"));
            host1.AddServiceEndpoint(typeof(IDataService), new BasicHttpBinding(), "");
            host1.Open();

            Console.WriteLine("Service started.");
            Console.WriteLine("Press eny key for close the server...");

            
            Console.ReadLine();
            host1.Close();
        }
    }
}

/*
 var data = DataManager.GetUsersFromDb();
            foreach (var user in data)
            {
                Console.WriteLine(user.ToString());
            }

 */
/*
 
 using (var DB = new DataAccess.DB_Context())
            {
                var userList = new List<User>
                {
                    new User{Name = "Roman",Surname = "Petrov",PhoneNumber = "123-12-12",Email = "qwe@mail.com"},
                    new User{Name = "Igor",Surname = "Sazanov",PhoneNumber = "223-32-12",Email = "aswe@mail.com"},
                    new User{Name = "Stas",Surname = "Pypkin",PhoneNumber = "323-22-12",Email = "pup@mail.com"},
                    new User{Name = "Nikolai",Surname = "Sovlasov",PhoneNumber = "523-33-21",Email = "sov@mail.com"},
                    new User{Name = "Vladimir",Surname = "Zvanik",PhoneNumber = "333-66-33",Email = "zvan@mail.com"},
                };
                DB.Users.AddRange(userList);
                DB.SaveChanges();

                var objOfTransactionsList = new List<ObjectOfTransaction>
                {
                    new ObjectOfTransaction
                    {
                        UserID = 2,
                        ObjectTypeID = (int)EnumObjectType.House,
                        ServiceTypeID = (int)EnumServiceType.Sale,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.Cahs,
                        ObjectStateID = (int)EnumObjectState.Opened,
                        Cost = 250000,
                        Description = "Rly cool house !"
                    },
                    new ObjectOfTransaction
                    {
                        UserID = 1,
                        ObjectTypeID = (int)EnumObjectType.CommercialProperty,
                        ServiceTypeID = (int)EnumServiceType.Rent,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.BankTransfer,
                        ObjectStateID = (int)EnumObjectState.Opened,
                        Cost = 1200,
                        Description = "Rly cool CommercialProperty !"
                    },
                    new ObjectOfTransaction
                    {
                        UserID = 3,
                        ObjectTypeID = (int)EnumObjectType.Apartment,
                        ServiceTypeID = (int)EnumServiceType.Rent,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.Cahs,
                        ObjectStateID = (int)EnumObjectState.Opened,
                        Cost = 500,
                        Description = "Rly cool Apartment !"
                    },
                    new ObjectOfTransaction
                    {
                        UserID = 4,
                        ObjectTypeID = (int)EnumObjectType.House,
                        ServiceTypeID = (int)EnumServiceType.Sale,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.BankTransfer,
                        ObjectStateID = (int)EnumObjectState.Opened,
                        Cost = 200000,
                        Description = "Rly cool house ! For: "
                    },
                    new ObjectOfTransaction
                    {
                        UserID = 5,
                        ObjectTypeID = (int)EnumObjectType.Homestead,
                        ServiceTypeID = (int)EnumServiceType.Sale,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.Cahs,
                        ObjectStateID = (int)EnumObjectState.Opened,
                        Cost = 25000,
                        Description = "Rly cool Homestead !"
                    },
                    new ObjectOfTransaction
                    {
                        UserID = 4,
                        ObjectTypeID = (int)EnumObjectType.CommercialProperty,
                        ServiceTypeID = (int)EnumServiceType.Sale,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.BankTransfer,
                        ObjectStateID = (int)EnumObjectState.Opened,
                        Cost = 105000,
                        Description = "Rly cool CommercialProperty !"
                    },

                };
                DB.ObjectOfTransactions.AddRange(objOfTransactionsList);
                DB.SaveChanges();
            }

            


            using (var DB = new DB_Context())
            {

                var dealsList = new List<Deal>
                {
                    new Deal 
                    {
                        Seller_UserID = 4,
                        Buyer_UserID = 5,
                        ObjectOfTransactionID = 6,
                        PersonalNumberOfDeal = "#102301",
                        DateOfDeal = DateTime.Now,
                        TransactionAmount = 105000,
                        KindOfCalculatingID = (int)EnumKindOfCalculating.BankTransfer
                    }
                };
                DB.ObjectOfTransactions.Find(6).ObjectStateID = (int)EnumObjectState.Closed;
                DB.Deals.AddRange(dealsList);
                DB.SaveChanges();

            }

            using (var DB = new DB_Context())
            {
                Console.WriteLine(DB.ObjectOfTransactions.First().ToString());
            }*/