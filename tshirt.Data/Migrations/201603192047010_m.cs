namespace tshirt.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDesignElement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductDesignId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductDesign", t => t.ProductDesignId, cascadeDelete: true)
                .Index(t => t.ProductDesignId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDesignElement", "ProductDesignId", "dbo.ProductDesign");
            DropIndex("dbo.ProductDesignElement", new[] { "ProductDesignId" });
            DropTable("dbo.ProductDesignElement");
        }
    }
}
