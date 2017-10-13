namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_PEDIDO()
        {
            COMPRA_COTACAO_PEDIDO_DETALHE = new HashSet<COMPRA_COTACAO_PEDIDO_DETALHE>();
            COMPRA_PEDIDO_DETALHE = new HashSet<COMPRA_PEDIDO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COMPRA_TIPO_PEDIDO { get; set; }

        public int ID_FORNECEDOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PEDIDO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PREVISTA_ENTREGA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PREVISAO_PAGAMENTO { get; set; }

        [StringLength(100)]
        public string LOCAL_ENTREGA { get; set; }

        [StringLength(100)]
        public string LOCAL_COBRANCA { get; set; }

        [StringLength(30)]
        public string CONTATO { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_TOTAL_PEDIDO { get; set; }

        [StringLength(1)]
        public string TIPO_FRETE { get; set; }

        [StringLength(1)]
        public string FORMA_PAGAMENTO { get; set; }

        public decimal? BASE_CALCULO_ICMS { get; set; }

        public decimal? VALOR_ICMS { get; set; }

        public decimal? BASE_CALCULO_ICMS_ST { get; set; }

        public decimal? VALOR_ICMS_ST { get; set; }

        public decimal? VALOR_TOTAL_PRODUTOS { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public decimal? VALOR_SEGURO { get; set; }

        public decimal? VALOR_OUTRAS_DESPESAS { get; set; }

        public decimal? VALOR_IPI { get; set; }

        public decimal? VALOR_TOTAL_NF { get; set; }

        public int? QUANTIDADE_PARCELAS { get; set; }

        public int? DIAS_PRIMEIRO_VENCIMENTO { get; set; }

        public int? DIAS_INTERVALO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_COTACAO_PEDIDO_DETALHE> COMPRA_COTACAO_PEDIDO_DETALHE { get; set; }

        public virtual COMPRA_TIPO_PEDIDO COMPRA_TIPO_PEDIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_PEDIDO_DETALHE> COMPRA_PEDIDO_DETALHE { get; set; }

        public virtual FORNECEDOR FORNECEDOR { get; set; }
    }
}
