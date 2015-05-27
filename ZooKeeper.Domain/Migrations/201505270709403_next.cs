namespace ZooKeeper.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class next : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Animals", name: "Zookeeper_StaffID", newName: "StaffId");
            RenameIndex(table: "dbo.Animals", name: "IX_Zookeeper_StaffID", newName: "IX_StaffId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Animals", name: "IX_StaffId", newName: "IX_Zookeeper_StaffID");
            RenameColumn(table: "dbo.Animals", name: "StaffId", newName: "Zookeeper_StaffID");
        }
    }
}
