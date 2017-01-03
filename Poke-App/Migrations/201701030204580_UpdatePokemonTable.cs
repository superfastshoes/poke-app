namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePokemonTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pokemons", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pokemons", "Type", c => c.String());
        }
    }
}
