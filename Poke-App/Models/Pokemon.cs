using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poke_App.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string HitPoints { get; set; }
        public string Stage { get; set; }
        public string AttackDetails { get; set; }
        public string Weakness { get; set; }
        public string Resistance { get; set; }
        public string Retreat { get; set; }
        [Required]
        public PokemonType PokemonType { get; set; }
        public int PokemonTypeId { get; set; }
    }
}