namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe_rastro")]
    public partial class NFe_DetalheRastro
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        [StringLength(20)]
        public string numero_lote { get; set; }

        public decimal? quantidade_lote { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fabricacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_validade { get; set; }

        [StringLength(20)]
        public string codigo_agregacao { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }
    }
}
