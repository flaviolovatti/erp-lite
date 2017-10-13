namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_CANA_FORNECIMENTO_DIARIO
    {
        public int ID { get; set; }

        public int ID_NFE_CANA { get; set; }

        [StringLength(2)]
        public string DIA { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? QUANTIDADE_TOTAL_MES { get; set; }

        public decimal? QUANTIDADE_TOTAL_ANTERIOR { get; set; }

        public decimal? QUANTIDADE_TOTAL_GERAL { get; set; }

        public virtual NFE_CANA NFE_CANA { get; set; }
    }
}
