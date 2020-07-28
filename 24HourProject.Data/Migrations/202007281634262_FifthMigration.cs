namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Like", "user_OwnerId", c => c.Guid());
            CreateIndex("dbo.Like", "user_OwnerId");
            AddForeignKey("dbo.Like", "user_OwnerId", "dbo.User", "OwnerId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Like", "user_OwnerId", "dbo.User");
            DropIndex("dbo.Like", new[] { "user_OwnerId" });
            DropColumn("dbo.Like", "user_OwnerId");
        }
    }
}
