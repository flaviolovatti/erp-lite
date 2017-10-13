namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_CANA_DEDUCOES_SAFRA
    {
        public int ID { get; set; }

        public int ID_NFE_CANA { get; set; }

        [StringLength(60)]
        public string DECRICAO { get; set; }

        public decimal? VALOR_DEDUCAO { get; set; }

        public decimal? VALOR_FORNECIMENTO { get; set; }

        public decimal? VALOR_TOTAL_DEDUCAO { get; set; }

        public decimal? VALOR_LIQUIDO_FORNECIMENTO { get; set; }

        public virtual NFE_CANA NFE_CANA { get; set; }
    }
}
