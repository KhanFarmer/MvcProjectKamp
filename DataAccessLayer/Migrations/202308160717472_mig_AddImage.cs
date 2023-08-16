﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_AddImage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImageFiles",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageName = c.String(maxLength: 500),
                        ImagePath = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ImageID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ImageFiles");
        }
    }
}
