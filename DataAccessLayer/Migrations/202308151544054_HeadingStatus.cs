namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HeadingStatus : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Headings", "HeadindStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "HeadindStatus", c => c.Boolean(nullable: false));
        }
    }
}
