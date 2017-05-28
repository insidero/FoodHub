namespace FoodHUB1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class onelasttime : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        comment = c.String(),
                        stars = c.Int(nullable: false),
                        restaurant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.restaurant_Id)
                .Index(t => t.restaurant_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "restaurant_Id", "dbo.Restaurants");
            DropIndex("dbo.Reviews", new[] { "restaurant_Id" });
            DropTable("dbo.Reviews");
        }
    }
}
