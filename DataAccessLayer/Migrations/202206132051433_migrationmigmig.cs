namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrationmigmig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryDetails", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryDetails", c => c.String(maxLength: 100));
        }
    }
}
