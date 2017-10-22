namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_lcto_receber_nt_financeira")]
    public partial class FIN_LancamentoReceberNotaFinanceira
    {
        public int id { get; set; }

        public int id_fin_lancamento_receber { get; set; }

        public int id_natureza_financeira { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inclusao { get; set; }

        public decimal? valor { get; set; }

        public decimal? percentual { get; set; }

        public virtual FIN_LancamentoReceber fin_lancamento_receber { get; set; }

        public virtual NaturezaFinanceira natureza_financeira { get; set; }
    }
}
