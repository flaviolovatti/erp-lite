namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_duplicata")]
    public partial class CTe_Duplicata
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        public decimal? valor { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
