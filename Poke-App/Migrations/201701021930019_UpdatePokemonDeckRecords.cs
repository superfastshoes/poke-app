namespace Poke_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePokemonDeckRecords : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE PokemonDecks " +
                "SET Name = 'Even Deck' " +
                "WHERE Id = 1");
            Sql("UPDATE PokemonDecks " +
                "SET Name = 'Trainer Focused' " +
                "WHERE Id = 2");
            Sql("UPDATE PokemonDecks " +
                "SET Name = 'Heavy Trainer Focused' " +
                "WHERE Id = 3");
            Sql("UPDATE PokemonDecks " +
                "SET Name = 'Light Energy, Heavy Trainer Focused' " +
                "WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
