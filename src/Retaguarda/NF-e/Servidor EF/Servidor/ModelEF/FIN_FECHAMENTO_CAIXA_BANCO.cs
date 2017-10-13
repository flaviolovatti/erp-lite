namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_FECHAMENTO_CAIXA_BANCO
    {
        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FECHAMENTO { get; set; }

        [StringLength(7)]
        public string MES_ANO { get; set; }

        [StringLength(2)]
        public string MES { get; set; }

        [StringLength(4)]
        public string ANO { get; set; }

        public decimal? SALDO_ANTERIOR { get; set; }

        public decimal? RECEBIMENTOS { get; set; }

        public decimal? PAGAMENTOS { get; set; }

        public decimal? SALDO_CONTA { get; set; }

        public decimal? CHEQUE_NAO_COMPENSADO { get; set; }

        public decimal? SALDO_DISPONIVEL { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }
    }
}
