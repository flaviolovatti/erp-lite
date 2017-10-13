namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_PROMOCAO
    {
        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FIM { get; set; }

        public decimal? QUANTIDADE_EM_PROMOCAO { get; set; }

        public decimal? QUANTIDADE_MAXIMA_CLIENTE { get; set; }

        public decimal? VALOR { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
