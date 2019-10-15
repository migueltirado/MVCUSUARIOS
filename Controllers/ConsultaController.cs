using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCRUD.Models;


namespace Tarea3.Controllers
{
    
    public class CalculadoraController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

   public System.Collections.Generic.List<MVCRUD.Models.Usuarios>  consulta()
        {  

  var dbContext =new pruebaContext();{
 var usuario = dbContext.Usuarios.ToList();
 return usuario;
            //.Where(u=> u.Id==1)
            //.OrderBy(u=> u.Id)
            //.ToList();
           
        }

}
}
