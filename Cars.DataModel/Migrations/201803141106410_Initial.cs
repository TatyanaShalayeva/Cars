namespace Cars.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Producer = c.String(),
                        Model = c.String(),
                        HighSpeed = c.Int(nullable: false),
                        BodyType = c.String(),
                        Engine_EngineId = c.Int(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.Engines", t => t.Engine_EngineId)
                .Index(t => t.Engine_EngineId);
            
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        EngineId = c.Int(nullable: false, identity: true),
                        Cylinders = c.Int(nullable: false),
                        Power = c.Int(nullable: false),
                        Liters = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.EngineId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "Engine_EngineId", "dbo.Engines");
            DropIndex("dbo.Cars", new[] { "Engine_EngineId" });
            DropTable("dbo.Engines");
            DropTable("dbo.Cars");
        }
    }
}
