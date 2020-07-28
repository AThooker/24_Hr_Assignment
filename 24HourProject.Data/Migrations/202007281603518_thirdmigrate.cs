namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdmigrate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "PostingId", "dbo.Posting");
            DropIndex("dbo.Comment", new[] { "PostingId" });
            AlterColumn("dbo.Comment", "PostingId", c => c.Int());
            CreateIndex("dbo.Comment", "PostingId");
            AddForeignKey("dbo.Comment", "PostingId", "dbo.Posting", "PostingId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "PostingId", "dbo.Posting");
            DropIndex("dbo.Comment", new[] { "PostingId" });
            AlterColumn("dbo.Comment", "PostingId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comment", "PostingId");
            AddForeignKey("dbo.Comment", "PostingId", "dbo.Posting", "PostingId", cascadeDelete: true);
        }
    }
}
