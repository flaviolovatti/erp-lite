namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_LCTO_PAGAR_NT_FINANCEIRA
    {
        public int ID { get; set; }

        public int ID_FIN_LANCAMENTO_PAGAR { get; set; }

        public int ID_NATUREZA_FINANCEIRA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INCLUSAO { get; set; }

        public decimal? VALOR { get; set; }

        public decimal? PERCENTUAL { get; set; }

        public virtual FIN_LANCAMENTO_PAGAR FIN_LANCAMENTO_PAGAR { get; set; }

        public virtual NATUREZA_FINANCEIRA NATUREZA_FINANCEIRA { get; set; }
    }
}
