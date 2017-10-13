namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_SUPRIMENTO
    {
        public int ID { get; set; }

        public int ID_NFCE_MOVIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SUPRIMENTO { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual NFCE_MOVIMENTO NFCE_MOVIMENTO { get; set; }
    }
}
