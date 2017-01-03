namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PokemonTypeTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PokemonTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfPokemon = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pokemons", "PokemonTypeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Pokemons", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Pokemons", "PokemonTypeId");
            AddForeignKey("dbo.Pokemons", "PokemonTypeId", "dbo.PokemonTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pokemons", "PokemonTypeId", "dbo.PokemonTypes");
            DropIndex("dbo.Pokemons", new[] { "PokemonTypeId" });
            AlterColumn("dbo.Pokemons", "Name", c => c.String());
            DropColumn("dbo.Pokemons", "PokemonTypeId");
            DropTable("dbo.PokemonTypes");
        }
    }
}
