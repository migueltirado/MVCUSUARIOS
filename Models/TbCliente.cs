using System;
using System.Collections.Generic;

namespace MVCRUD.Models
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbOrden = new HashSet<TbOrden>();
        }

        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string NombreComercial { get; set; }

        public ICollection<TbOrden> TbOrden { get; set; }
    }
}
