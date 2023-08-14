namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_HeadingStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadindStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Headings", "HeadindStatus");
        }
    }
}
