namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_suprimento")]
    public partial class nfce_suprimento
    {
        public int id { get; set; }

        public int id_nfce_movimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_suprimento { get; set; }

        public decimal? valor { get; set; }

        public string observacao { get; set; }

        public virtual nfce_movimento nfce_movimento { get; set; }
    }
}
