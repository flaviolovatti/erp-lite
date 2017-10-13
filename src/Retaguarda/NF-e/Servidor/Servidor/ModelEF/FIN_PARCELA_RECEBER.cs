namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_PARCELA_RECEBER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_PARCELA_RECEBER()
        {
            FIN_PARCELA_RECEBIMENTO = new HashSet<FIN_PARCELA_RECEBIMENTO>();
        }

        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        public int ID_FIN_LANCAMENTO_RECEBER { get; set; }

        public int ID_FIN_STATUS_PARCELA { get; set; }

        public int? NUMERO_PARCELA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENCIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DESCONTO_ATE { get; set; }

        public decimal? VALOR { get; set; }

        public decimal? TAXA_JURO { get; set; }

        public decimal? TAXA_MULTA { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_JURO { get; set; }

        public decimal? VALOR_MULTA { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        [StringLength(1)]
        public string EMITIU_BOLETO { get; set; }

        [StringLength(50)]
        public string BOLETO_NOSSO_NUMERO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual FIN_LANCAMENTO_RECEBER FIN_LANCAMENTO_RECEBER { get; set; }

        public virtual FIN_STATUS_PARCELA FIN_STATUS_PARCELA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBIMENTO> FIN_PARCELA_RECEBIMENTO { get; set; }
    }
}
