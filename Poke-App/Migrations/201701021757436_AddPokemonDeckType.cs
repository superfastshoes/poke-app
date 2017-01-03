namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPokemonDeckType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PokemonDecks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pokemons = c.Short(nullable: false),
                        Trainers = c.Short(nullable: false),
                        Energies = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Owners", "PokemonDeckId", c => c.Int(nullable: false));
            CreateIndex("dbo.Owners", "PokemonDeckId");
            AddForeignKey("dbo.Owners", "PokemonDeckId", "dbo.PokemonDecks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Owners", "PokemonDeckId", "dbo.PokemonDecks");
            DropIndex("dbo.Owners", new[] { "PokemonDeckId" });
            DropColumn("dbo.Owners", "PokemonDeckId");
            DropTable("dbo.PokemonDecks");
        }
    }
}
