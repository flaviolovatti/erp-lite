namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_PARCELA_PAGAMENTO
    {
        public int ID { get; set; }

        public int ID_FIN_PARCELA_PAGAR { get; set; }

        public int? ID_FIN_CHEQUE_EMITIDO { get; set; }

        public int ID_FIN_TIPO_PAGAMENTO { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PAGAMENTO { get; set; }

        public decimal? TAXA_JURO { get; set; }

        public decimal? TAXA_MULTA { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_JURO { get; set; }

        public decimal? VALOR_MULTA { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_PAGO { get; set; }

        [StringLength(250)]
        public string HISTORICO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual FIN_CHEQUE_EMITIDO FIN_CHEQUE_EMITIDO { get; set; }

        public virtual FIN_PARCELA_PAGAR FIN_PARCELA_PAGAR { get; set; }

        public virtual FIN_TIPO_PAGAMENTO FIN_TIPO_PAGAMENTO { get; set; }
    }
}
