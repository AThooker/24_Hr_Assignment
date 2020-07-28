namespace _24HourProject.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Like", "CreatedUtc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Like", "CreatedUtc", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
