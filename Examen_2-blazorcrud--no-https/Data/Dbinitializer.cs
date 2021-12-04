using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Examen_2_blazorcrud__no_https.Data
{
    public class DBinitializer{
    public static void Inicializar(AppDBContext context){
        context.Database.EnsureCreated();
        if(context.Actores.Any()){
            return;
        }
        var Actores= new tblActors[] {
            new tblActors {strActorFullName="Alejandro",memActorNotes="okidoki"};
        };
        for(Actores actor in Actores)
        {
            context.tblActors.Add(actor);            
        };
        context.SaveChanges();


    }   
}