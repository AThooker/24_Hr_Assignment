namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SixthMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Like", "user_OwnerId", "dbo.User");
            DropIndex("dbo.Like", new[] { "user_OwnerId" });
            DropColumn("dbo.Like", "user_OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Like", "user_OwnerId", c => c.Guid());
            CreateIndex("dbo.Like", "user_OwnerId");
            AddForeignKey("dbo.Like", "user_OwnerId", "dbo.User", "OwnerId");
        }
    }
}
