namespace UniversityManagementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Semester", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Semester", c => c.String(nullable: false, maxLength: 8000, unicode: false));
        }
    }
}
