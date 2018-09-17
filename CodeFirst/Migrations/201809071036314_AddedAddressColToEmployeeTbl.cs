namespace CFUsingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAddressColToEmployeeTbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Address");
        }
    }
}
