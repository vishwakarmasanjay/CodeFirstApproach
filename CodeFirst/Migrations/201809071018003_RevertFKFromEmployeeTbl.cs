namespace CFUsingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevertFKFromEmployeeTbl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "DepartmentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
        }
    }
}
