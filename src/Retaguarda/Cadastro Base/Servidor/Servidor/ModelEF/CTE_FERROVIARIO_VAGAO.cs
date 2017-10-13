namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_FERROVIARIO_VAGAO
    {
        public int ID { get; set; }

        public int ID_CTE_FERROVIARIO { get; set; }

        public int? NUMERO_VAGAO { get; set; }

        public decimal? CAPACIDADE { get; set; }

        [StringLength(3)]
        public string TIPO_VAGAO { get; set; }

        public decimal? PESO_REAL { get; set; }

        public decimal? PESO_BC { get; set; }

        public virtual CTE_FERROVIARIO CTE_FERROVIARIO { get; set; }
    }
}
