namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_transporte_reboque")]
    public partial class nfe_transporte_reboque
    {
        public int id { get; set; }

        public int id_nfe_transporte { get; set; }

        [StringLength(8)]
        public string placa { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(20)]
        public string rntc { get; set; }

        public virtual nfe_transporte nfe_transporte { get; set; }
    }
}
