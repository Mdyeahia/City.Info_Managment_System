namespace City.IMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class citymodelAdded : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "Citymodels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Citymodels", newName: "Cities");
        }
    }
}
