namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deals",
                c => new
                    {
                        DealID = c.Int(nullable: false, identity: true),
                        Seller_UserID = c.Int(nullable: false),
                        Buyer_UserID = c.Int(nullable: false),
                        KindOfCalculatingID = c.Int(nullable: false),
                        ObjectOfTransactionID = c.Int(nullable: false),
                        PersonalNumberOfDeal = c.String(nullable: false),
                        DateOfDeal = c.DateTime(nullable: false),
                        TransactionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Buyer_UserID1 = c.Int(),
                        Seller_UserID1 = c.Int(),
                    })
                .PrimaryKey(t => t.DealID)
                .ForeignKey("dbo.Users", t => t.Buyer_UserID1)
                .ForeignKey("dbo.ObjectOfTransactions", t => t.ObjectOfTransactionID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Seller_UserID1)
                .Index(t => t.ObjectOfTransactionID)
                .Index(t => t.Buyer_UserID1)
                .Index(t => t.Seller_UserID1);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.ObjectOfTransactions",
                c => new
                    {
                        ObjectOfTransactionID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        ObjectTypeID = c.Int(nullable: false),
                        ServiceTypeID = c.Int(nullable: false),
                        KindOfCalculatingID = c.Int(nullable: false),
                        ObjectStateID = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ObjectOfTransactionID)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Deals", "Seller_UserID1", "dbo.Users");
            DropForeignKey("dbo.Deals", "ObjectOfTransactionID", "dbo.ObjectOfTransactions");
            DropForeignKey("dbo.ObjectOfTransactions", "UserID", "dbo.Users");
            DropForeignKey("dbo.Deals", "Buyer_UserID1", "dbo.Users");
            DropIndex("dbo.ObjectOfTransactions", new[] { "UserID" });
            DropIndex("dbo.Deals", new[] { "Seller_UserID1" });
            DropIndex("dbo.Deals", new[] { "Buyer_UserID1" });
            DropIndex("dbo.Deals", new[] { "ObjectOfTransactionID" });
            DropTable("dbo.ObjectOfTransactions");
            DropTable("dbo.Users");
            DropTable("dbo.Deals");
        }
    }
}
