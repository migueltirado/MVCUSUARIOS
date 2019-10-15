using System;
using System.Collections.Generic;

namespace MVCRUD.Models
{
    public partial class TbAgente
    {
        public TbAgente()
        {
            TbOrden = new HashSet<TbOrden>();
        }

        public string IdAgente { get; set; }
        public string Nombre { get; set; }
        public string Departamanto { get; set; }

        public ICollection<TbOrden> TbOrden { get; set; }
    }
}
