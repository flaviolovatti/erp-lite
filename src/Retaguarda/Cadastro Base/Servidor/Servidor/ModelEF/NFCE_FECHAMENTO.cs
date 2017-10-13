namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_FECHAMENTO
    {
        public int ID { get; set; }

        public int ID_NFCE_MOVIMENTO { get; set; }

        [StringLength(20)]
        public string TIPO_PAGAMENTO { get; set; }

        public decimal? VALOR { get; set; }

        public virtual NFCE_MOVIMENTO NFCE_MOVIMENTO { get; set; }
    }
}
