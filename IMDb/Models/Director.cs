using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMDb.Models
{
    public class Director
    {
        public int ID { get; set; } // ID glumca

        [Required]
        [StringLength(160, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(160, MinimumLength = 2)]
        public string Lastname { get; set; }

        //SLIKA???

        public string PlaceOfBirth { get; set; }

        public string YearOfBirth { get; set; }

        public string Filmography { get; set; }

        public string Details { get; set; }
    }
}