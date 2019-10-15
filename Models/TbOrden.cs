using System;
using System.Collections.Generic;

namespace MVCRUD.Models
{
    public partial class TbOrden
    {
        public TbOrden()
        {
            TbFacturas = new HashSet<TbFacturas>();
        }

        public string NumeroOrden { get; set; }
        public string TipoVenta { get; set; }
        public string Agente { get; set; }
        public string Cliente { get; set; }

        public TbAgente AgenteNavigation { get; set; }
        public TbCliente ClienteNavigation { get; set; }
        public ICollection<TbFacturas> TbFacturas { get; set; }
    }
}
