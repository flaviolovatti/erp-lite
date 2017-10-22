namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_exportacao")]
    public partial class nfe_exportacao
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public int? drawback { get; set; }

        public int? numero_registro { get; set; }

        [StringLength(44)]
        public string chave_acesso { get; set; }

        public decimal? quantidade { get; set; }

        public virtual nfe_detalhe nfe_detalhe { get; set; }
    }
}
