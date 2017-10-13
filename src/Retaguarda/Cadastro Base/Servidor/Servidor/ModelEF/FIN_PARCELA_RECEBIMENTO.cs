namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_PARCELA_RECEBIMENTO
    {
        public int ID { get; set; }

        public int ID_FIN_PARCELA_RECEBER { get; set; }

        public int ID_FIN_TIPO_RECEBIMENTO { get; set; }

        public int? ID_FIN_CHEQUE_RECEBIDO { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_RECEBIMENTO { get; set; }

        public decimal? TAXA_JURO { get; set; }

        public decimal? TAXA_MULTA { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_JURO { get; set; }

        public decimal? VALOR_MULTA { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_RECEBIDO { get; set; }

        [StringLength(250)]
        public string HISTORICO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual FIN_CHEQUE_RECEBIDO FIN_CHEQUE_RECEBIDO { get; set; }

        public virtual FIN_PARCELA_RECEBER FIN_PARCELA_RECEBER { get; set; }

        public virtual FIN_TIPO_RECEBIMENTO FIN_TIPO_RECEBIMENTO { get; set; }
    }
}
