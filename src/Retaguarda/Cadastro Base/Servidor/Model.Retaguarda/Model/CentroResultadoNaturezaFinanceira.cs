namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ct_resultado_nt_financeira")]
    public partial class CentroResultadoNaturezaFinanceira
    {
        public int id { get; set; }

        public int id_centro_resultado { get; set; }

        public int id_natureza_financeira { get; set; }

        public decimal? percentual_rateio { get; set; }

        public virtual CentroResultado centro_resultado { get; set; }

        public virtual NaturezaFinanceira natureza_financeira { get; set; }
    }
}
