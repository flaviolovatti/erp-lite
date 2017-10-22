namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_inf_nf_transporte_lacre")]
    public partial class cte_inf_nf_transporte_lacre
    {
        public int id { get; set; }

        public int id_cte_informacao_nf_transp { get; set; }

        [StringLength(20)]
        public string numero { get; set; }

        public virtual cte_informacao_nf_transporte cte_informacao_nf_transporte { get; set; }
    }
}
