namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe_imposto_ii")]
    public partial class nfe_detalhe_imposto_ii
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public decimal? valor_bc_ii { get; set; }

        public decimal? valor_despesas_aduaneiras { get; set; }

        public decimal? valor_imposto_importacao { get; set; }

        public decimal? valor_iof { get; set; }

        public virtual nfe_detalhe nfe_detalhe { get; set; }
    }
}
