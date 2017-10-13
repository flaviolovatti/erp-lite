namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_RESULTADO_NT_FINANCEIRA
    {
        public int ID { get; set; }

        public int ID_CENTRO_RESULTADO { get; set; }

        public int ID_NATUREZA_FINANCEIRA { get; set; }

        public decimal? PERCENTUAL_RATEIO { get; set; }

        public virtual CENTRO_RESULTADO CENTRO_RESULTADO { get; set; }

        public virtual NATUREZA_FINANCEIRA NATUREZA_FINANCEIRA { get; set; }
    }
}
