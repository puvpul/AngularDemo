namespace TaskService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceJob",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Status = c.String(),
                        Comment = c.String(),
                        TechnicianId = c.Int(),
                        ClientID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Technician", t => t.TechnicianId)
                .Index(t => t.TechnicianId);
            
            CreateTable(
                "dbo.Technician",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceJob", "TechnicianId", "dbo.Technician");
            DropIndex("dbo.ServiceJob", new[] { "TechnicianId" });
            DropTable("dbo.Technician");
            DropTable("dbo.ServiceJob");
        }
    }
}
