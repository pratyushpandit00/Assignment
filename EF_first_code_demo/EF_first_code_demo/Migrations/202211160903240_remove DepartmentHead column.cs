namespace EF_first_code_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDepartmentHeadcolumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "name", c => c.String(nullable: false));
            DropColumn("dbo.Departments", "DepartmentHead");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "DepartmentHead", c => c.String());
            AlterColumn("dbo.Departments", "name", c => c.String());
        }
    }
}
