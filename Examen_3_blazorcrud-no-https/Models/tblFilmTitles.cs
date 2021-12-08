using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Examen_2_blazorcrud__no_https.Models
{
public class tblFilmTitles{
       [Key]
       public int IdTitulo {get; set;}
       public string NombreP {get; set;}
       public string HisPelicula {get; set;}
       public DataType fechacreada {get; set;}
       public int duracion {get; set;}
       public string IdGenero {get; set;} 
       public int IdCertificacion {get; set;}
       public string Informacion {get; set;}

       public ICollection<tblFilmsActorRoles> Rolesdeactoresenpeliculas {get; set;}
       public ICollection<tblFilmTitlesProducers> Peliculasdirigidasporproductores {get; set;}
       public tblFilmCertificates Certificadosdepeliculas {get; set;}
       public tblFilmGenres Generosdepelicula {get; set;}
}
}