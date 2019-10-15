using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MVCRUD.Models;
namespace MVCRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
 
 
            using( var dbContext =new Models.pruebaContext()){
            var usuario = dbContext.Usuarios
            .Where(u=> u.Id==1)
            .OrderBy(u=> u.Id)
            .ToList();
                        
            var editarusuario=dbContext.Usuarios.FirstOrDefault(x => x.Id==2);
            editarusuario.Nombre="Jessica Barrios";
            editarusuario.Pass="1234";
            dbContext.SaveChanges();

        }



    


 
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
