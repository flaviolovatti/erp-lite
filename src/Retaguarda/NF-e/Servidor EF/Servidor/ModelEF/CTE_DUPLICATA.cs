namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_DUPLICATA
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(60)]
        public string NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENCIMENTO { get; set; }

        public decimal? VALOR { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
