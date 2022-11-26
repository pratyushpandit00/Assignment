namespace EF_first_code_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deptheadadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "DepartmentHead", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "DepartmentHead");
        }
    }
}
