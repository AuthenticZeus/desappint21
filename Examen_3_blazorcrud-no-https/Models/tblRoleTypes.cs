using System.ComponentModel.DataAnnotations;
using System;


namespace Examen_2_blazorcrud__no_https.Modelo{
    public class tblRoleTypes {

    public int IdTiporol {get; set;}
    public string Tiporol {get; set;}

    public tblRoleTypes Roless {get; set;}
    }
    
}