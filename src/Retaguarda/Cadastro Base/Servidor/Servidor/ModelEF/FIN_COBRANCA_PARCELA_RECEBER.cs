namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_COBRANCA_PARCELA_RECEBER
    {
        public int ID { get; set; }

        public int ID_FIN_COBRANCA { get; set; }

        public int? ID_FIN_LANCAMENTO_RECEBER { get; set; }

        public int? ID_FIN_PARCELA_RECEBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENCIMENTO { get; set; }

        public decimal? VALOR_PARCELA { get; set; }

        public decimal? VALOR_JURO_SIMULADO { get; set; }

        public decimal? VALOR_MULTA_SIMULADO { get; set; }

        public decimal? VALOR_RECEBER_SIMULADO { get; set; }

        public decimal? VALOR_JURO_ACORDO { get; set; }

        public decimal? VALOR_MULTA_ACORDO { get; set; }

        public decimal? VALOR_RECEBER_ACORDO { get; set; }

        public virtual FIN_COBRANCA FIN_COBRANCA { get; set; }
    }
}
