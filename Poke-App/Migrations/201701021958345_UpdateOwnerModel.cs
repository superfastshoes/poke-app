namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOwnerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Owners", "Birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Owners", "Birthdate");
        }
    }
}
