namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToOwner : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Owners " +
              "SET Birthdate = '1987-04-26'" +
              "WHERE Id = 8");
        }
        
        public override void Down()
        {
        }
    }
}
