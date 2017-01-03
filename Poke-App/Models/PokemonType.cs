﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Poke_App.Models
{
    public class PokemonType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string TypeOfPokemon { get; set; }
    }
}