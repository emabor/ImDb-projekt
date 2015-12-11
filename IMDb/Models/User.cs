using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IMDb.Models
{
    public class User
    {
        public int ID { get; set; } //ID korisnika

        //Nadimak
        [Required]
        [StringLength(160, MinimumLength = 2)]
        public string UserName { get; set; }

        //SLIKA??

        //E-mail
        [Required]
        [StringLength(160, MinimumLength = 2)]
        public string Email { get; set; }

        //Lokacija
        public string Location { get; set; }
    }
}