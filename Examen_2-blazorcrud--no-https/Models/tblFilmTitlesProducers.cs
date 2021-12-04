using System;
using System.ComponentModel.DataAnnotations;

namespace Examen_2_blazorcrud__no_https.Models
{
    public class tblFilmTitlesProducers {
        [Key]
            public int IdProductor {get; set;}
            [Required]
        public int IdTitulo {get; set;}
    
    public tblFilmTitlesProducers Peliculasdirigidasporproductores {get; set;}
    public tblProducers Productores {get; set;}
    }
}