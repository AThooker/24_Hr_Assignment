namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comment", "PostingId", "dbo.Posting");
            DropIndex("dbo.Comment", new[] { "PostingId" });
            DropColumn("dbo.Comment", "PostingId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comment", "PostingId", c => c.Int());
            CreateIndex("dbo.Comment", "PostingId");
            AddForeignKey("dbo.Comment", "PostingId", "dbo.Posting", "PostingId");
        }
    }
}
