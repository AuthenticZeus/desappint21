using System.ComponentModel.DataAnnotations;
using System;

namespace Examen_2_blazorcrud__no_https.Modelo{
    public class tblProducers{
        public int IdProductor {get; set;}
        public string NombreProductor {get; set;}
        public string email {get; set;}
        public string Sitioweb {get; set;}

        public tblProducers Productores {get; set;}
    }
    
}