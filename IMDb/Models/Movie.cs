using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IMDb.Models
{
    public class Movie
    {
        public int ID { get; set; } // ID filma

        // Naslov filma
        [Required]
        public String Title { get; set; }

        // Opis filma
        [Required]
        public String Description { get; set; }

        // Godina u kojoj je film snimljen
        [Required]
        public float Year { get; set; }

        // Redatelj filma
        [Required]
        public float Director { get; set; }

        // Scenarist filma
        [Required]
        public float Screenwriter { get; set; }

        // Glumačka postava filma
        [Required]
        public float Actors { get; set; }

        // Prosjecna ocjena filma
        public int? AverageRating { get; set; }
        
    }
}