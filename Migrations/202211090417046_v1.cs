namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductInvoices", newName: "InvoiceProducts");
            DropPrimaryKey("dbo.InvoiceProducts");
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        CustomerLastName = c.String(),
                        CustomerDNI = c.Int(nullable: false),
                        CustomerPhone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        InvoiceDetailID = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Terms = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceDetailID);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerID = c.Int(nullable: false, identity: true),
                        SellerName = c.String(),
                        SellerLastname = c.String(),
                        SellerRUC = c.Int(nullable: false),
                        SellerStoreName = c.String(),
                    })
                .PrimaryKey(t => t.SellerID);
            
            AddColumn("dbo.Products", "InvoiceDetail_InvoiceDetailID", c => c.Int());
            AddPrimaryKey("dbo.InvoiceProducts", new[] { "Invoice_InvoiceID", "Product_ProductID" });
            CreateIndex("dbo.Products", "InvoiceDetail_InvoiceDetailID");
            AddForeignKey("dbo.Products", "InvoiceDetail_InvoiceDetailID", "dbo.InvoiceDetails", "InvoiceDetailID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "InvoiceDetail_InvoiceDetailID", "dbo.InvoiceDetails");
            DropIndex("dbo.Products", new[] { "InvoiceDetail_InvoiceDetailID" });
            DropPrimaryKey("dbo.InvoiceProducts");
            DropColumn("dbo.Products", "InvoiceDetail_InvoiceDetailID");
            DropTable("dbo.Sellers");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Customers");
            AddPrimaryKey("dbo.InvoiceProducts", new[] { "Product_ProductID", "Invoice_InvoiceID" });
            RenameTable(name: "dbo.InvoiceProducts", newName: "ProductInvoices");
        }
    }
}
