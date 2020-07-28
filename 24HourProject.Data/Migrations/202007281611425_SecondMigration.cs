namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Like", "OwnerId", "dbo.User");
            DropForeignKey("dbo.Like", "PostingId", "dbo.Posting");
            DropIndex("dbo.Like", new[] { "PostingId" });
            DropIndex("dbo.Like", new[] { "OwnerId" });
            DropColumn("dbo.Like", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Like", "OwnerId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Like", "OwnerId");
            CreateIndex("dbo.Like", "PostingId");
            AddForeignKey("dbo.Like", "PostingId", "dbo.Posting", "PostingId", cascadeDelete: true);
            AddForeignKey("dbo.Like", "OwnerId", "dbo.User", "OwnerId", cascadeDelete: true);
        }
    }
}
