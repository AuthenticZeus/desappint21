using System;
using System.ComponentModel.DataAnnotations;

namespace Examen_2_blazorcrud__no_https.Models
{
    public class tblFilmCertificates {
        [Key]
        public int IdCertificado {get; set;}
        [Required]
        public string Certificado {get; set;}
    
    public ICollection<tblFilmTitles> Peliculas {get; set;}
    }
}
