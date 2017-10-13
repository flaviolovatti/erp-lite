namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_DUTOVIARIO
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        public decimal? VALOR_TARIFA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FIM { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
