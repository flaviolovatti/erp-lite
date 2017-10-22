namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_seguro")]
    public partial class CTe_Seguro
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        public int? responsavel { get; set; }

        [StringLength(30)]
        public string seguradora { get; set; }

        [StringLength(20)]
        public string apolice { get; set; }

        [StringLength(20)]
        public string averbacao { get; set; }

        public decimal? valor_carga { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
