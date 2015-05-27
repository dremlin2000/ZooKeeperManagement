namespace ZooKeeper.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextMigration1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Animals", "ZookeeperId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "ZookeeperId", c => c.Int(nullable: false));
        }
    }
}
