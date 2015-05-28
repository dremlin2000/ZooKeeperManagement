namespace ZooKeeper.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        AnimalID = c.String(nullable: false, maxLength: 6),
                        AnimalType = c.String(),
                        NickName = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                        ZookeeperId = c.Int(nullable: false),
                        Zookeeper_StaffID = c.String(maxLength: 6),
                    })
                .PrimaryKey(t => t.AnimalID)
                .ForeignKey("dbo.Zookeepers", t => t.Zookeeper_StaffID)
                .Index(t => t.Zookeeper_StaffID);
            
            CreateTable(
                "dbo.Zookeepers",
                c => new
                    {
                        StaffID = c.String(nullable: false, maxLength: 6),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.StaffID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Animals", "Zookeeper_StaffID", "dbo.Zookeepers");
            DropIndex("dbo.Animals", new[] { "Zookeeper_StaffID" });
            DropTable("dbo.Zookeepers");
            DropTable("dbo.Animals");
        }
    }
}
