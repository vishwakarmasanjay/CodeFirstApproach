namespace CFUsingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddedDepartmentIdinEmployeeTblFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Employees", "DepartmentId");
        }
    }
}
