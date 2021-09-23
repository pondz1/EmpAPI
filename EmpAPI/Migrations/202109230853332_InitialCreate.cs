namespace EmpAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        EmpDesignation = c.String(),
                        EmpAddress = c.String(),
                        EmpSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmpJoiningDate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
