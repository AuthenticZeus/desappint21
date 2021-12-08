using System;
using Microsoft.EntityFrameworkCore;

namespace Examen_2_blazorcrud__no_https.Data{
    public class AppDBContext : DbContext{
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options){

        }
        public DbSet<tblActors> Actores {get; set;}
    }
}