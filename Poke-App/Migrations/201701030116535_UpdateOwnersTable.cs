namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOwnersTable : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Owners " +
                "SET Name = 'Eddie' " +
                "WHERE Id = 9");
            Sql("UPDATE Owners " +
                "SET Name = 'Nercy' " +
                "WHERE Id = 8");
        }
        
        public override void Down()
        {
        }
    }
}
