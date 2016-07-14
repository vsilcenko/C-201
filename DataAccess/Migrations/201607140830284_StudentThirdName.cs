
namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentThirdName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ThirdName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ThirdName");
        }
    }
}
