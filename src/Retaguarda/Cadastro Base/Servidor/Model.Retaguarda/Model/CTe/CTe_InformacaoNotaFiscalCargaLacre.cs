namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_inf_nf_carga_lacre")]
    public partial class CTe_InformacaoNotaFiscalCargaLacre
    {
        public int id { get; set; }

        public int id_cte_informacao_nf_carga { get; set; }

        [StringLength(20)]
        public string numero { get; set; }

        public decimal? quantidade_rateada { get; set; }

        public virtual CTe_InformacaoNotaFiscalCarga cte_informacao_nf_carga { get; set; }
    }
}
