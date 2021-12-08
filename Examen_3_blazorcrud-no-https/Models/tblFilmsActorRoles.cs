using System.ComponentModel.DataAnnotations;
using System;

namespace Examen_2_blazorcrud__no_https.Models{
    public class tblFilmsActorRoles{
        public int IdTitulo {get; set;}
        public int IdActor {get; set;}
        public int IdTiporol {get; set;}
        public string NameC {get; set;}
        public string Descripcion {get; set;}
    

    public tblFilmsActorRoles tblFilmsActorRoless {get; set;}
    public tblActors Actores {get; set;}
    }
}
