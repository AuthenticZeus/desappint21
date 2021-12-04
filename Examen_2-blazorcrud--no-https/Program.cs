using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Examen_2_blazorcrud__no_https.Data;

namespace Examen_2_blazorcrud__no_https
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var = host CreateHostBuilder(args).Build();
            using (var scope=Host.Services.CreateScope()){
                var context=ServiceDescriptor.GetRequiredService<AppDBContext>();
                DBinitializer.Inicializar(context);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
