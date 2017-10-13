namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_INF_NF_CARGA_LACRE
    {
        public int ID { get; set; }

        public int ID_CTE_INFORMACAO_NF_CARGA { get; set; }

        [StringLength(20)]
        public string NUMERO { get; set; }

        public decimal? QUANTIDADE_RATEADA { get; set; }

        public virtual CTE_INFORMACAO_NF_CARGA CTE_INFORMACAO_NF_CARGA { get; set; }
    }
}
