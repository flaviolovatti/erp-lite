namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_fechamento")]
    public partial class nfce_fechamento
    {
        public int id { get; set; }

        public int id_nfce_movimento { get; set; }

        [StringLength(20)]
        public string tipo_pagamento { get; set; }

        public decimal? valor { get; set; }

        public virtual nfce_movimento nfce_movimento { get; set; }
    }
}
