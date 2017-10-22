namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_transporte_volume_lacre")]
    public partial class nfe_transporte_volume_lacre
    {
        public int id { get; set; }

        public int id_nfe_transporte_volume { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        public virtual nfe_transporte_volume nfe_transporte_volume { get; set; }
    }
}
