namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cobranca_parcela_receber")]
    public partial class FIN_CobrancaParcelaReceber
    {
        public int id { get; set; }

        public int id_fin_cobranca { get; set; }

        public int? id_fin_lancamento_receber { get; set; }

        public int? id_fin_parcela_receber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        public decimal? valor_parcela { get; set; }

        public decimal? valor_juro_simulado { get; set; }

        public decimal? valor_multa_simulado { get; set; }

        public decimal? valor_receber_simulado { get; set; }

        public decimal? valor_juro_acordo { get; set; }

        public decimal? valor_multa_acordo { get; set; }

        public decimal? valor_receber_acordo { get; set; }

        public virtual FIN_Cobranca fin_cobranca { get; set; }
    }
}
