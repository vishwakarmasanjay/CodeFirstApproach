namespace CFUsingEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddedFkColumnToEmployeeTblWithConstraint : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int());
            AddColumn("dbo.Employees", "Department_DepartmentId", c => c.Int());
            CreateIndex("dbo.Employees", "DepartmentId");
            CreateIndex("dbo.Employees", "Department_DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "DepartmentId");
            AddForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments", "DepartmentId");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropColumn("dbo.Employees", "Department_DepartmentId");
            DropColumn("dbo.Employees", "DepartmentId");
        }
    }
}
