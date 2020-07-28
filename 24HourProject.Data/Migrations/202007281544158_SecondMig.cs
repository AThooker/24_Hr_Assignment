namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "OwnerId", "dbo.User");
            DropIndex("dbo.Comment", new[] { "OwnerId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Comment", "OwnerId");
            AddForeignKey("dbo.Comment", "OwnerId", "dbo.User", "OwnerId", cascadeDelete: true);
        }
    }
}
