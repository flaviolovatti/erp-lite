namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_PARCELA_PAGAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_PARCELA_PAGAR()
        {
            FIN_PARCELA_PAGAMENTO = new HashSet<FIN_PARCELA_PAGAMENTO>();
        }

        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        public int ID_FIN_LANCAMENTO_PAGAR { get; set; }

        public int ID_FIN_STATUS_PARCELA { get; set; }

        public int? NUMERO_PARCELA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENCIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DESCONTO_ATE { get; set; }

        [StringLength(1)]
        public string SOFRE_RETENCAO { get; set; }

        public decimal? VALOR { get; set; }

        public decimal? TAXA_JURO { get; set; }

        public decimal? TAXA_MULTA { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_JURO { get; set; }

        public decimal? VALOR_MULTA { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual FIN_LANCAMENTO_PAGAR FIN_LANCAMENTO_PAGAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_PAGAMENTO> FIN_PARCELA_PAGAMENTO { get; set; }

        public virtual FIN_STATUS_PARCELA FIN_STATUS_PARCELA { get; set; }
    }
}
