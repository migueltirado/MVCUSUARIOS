using System;
using System.Collections.Generic;

namespace MVCRUD.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
    }
}
