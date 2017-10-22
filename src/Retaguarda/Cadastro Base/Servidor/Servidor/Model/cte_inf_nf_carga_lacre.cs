namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_inf_nf_carga_lacre")]
    public partial class cte_inf_nf_carga_lacre
    {
        public int id { get; set; }

        public int id_cte_informacao_nf_carga { get; set; }

        [StringLength(20)]
        public string numero { get; set; }

        public decimal? quantidade_rateada { get; set; }

        public virtual cte_informacao_nf_carga cte_informacao_nf_carga { get; set; }
    }
}
