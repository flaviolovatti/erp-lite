namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_dutoviario")]
    public partial class CTe_Dutoviario
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        public decimal? valor_tarifa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fim { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
