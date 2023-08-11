namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writerTitle_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterTitle", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
            DropColumn("dbo.Writers", "WriterTitle");
        }
    }
}
