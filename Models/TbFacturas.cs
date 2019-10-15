using System;
using System.Collections.Generic;

namespace MVCRUD.Models
{
    public partial class TbFacturas
    {
        public string Folio { get; set; }
        public decimal? Importe { get; set; }
        public decimal? TipoCambio { get; set; }
        public string IdPago { get; set; }
        public string Orden { get; set; }

        public TbOrden OrdenNavigation { get; set; }
    }
}
