namespace UniversityManagementApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class version5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Address = c.String(nullable: false, maxLength: 500, unicode: false),
                        Email = c.String(nullable: false, maxLength: 150, unicode: false),
                        ContactNo = c.Int(nullable: false),
                        Designation = c.String(nullable: false, maxLength: 100, unicode: false),
                        DepartmentId = c.Int(nullable: false),
                        CreditTaken = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropTable("dbo.Teachers");
        }
    }
}
