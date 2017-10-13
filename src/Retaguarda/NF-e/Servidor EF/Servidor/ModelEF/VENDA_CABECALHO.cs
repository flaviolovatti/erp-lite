namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA_CABECALHO()
        {
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
            VENDA_COMISSAO = new HashSet<VENDA_COMISSAO>();
            VENDA_DETALHE = new HashSet<VENDA_DETALHE>();
            VENDA_FRETE = new HashSet<VENDA_FRETE>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? ID_VENDA_ROMANEIO_ENTREGA { get; set; }

        public int? ID_VENDA_ORCAMENTO_CABECALHO { get; set; }

        public int ID_VENDA_CONDICOES_PAGAMENTO { get; set; }

        public int? ID_TRANSPORTADORA { get; set; }

        public int ID_TIPO_NOTA_FISCAL { get; set; }

        public int ID_CLIENTE { get; set; }

        public int ID_VENDEDOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENDA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SAIDA { get; set; }

        [StringLength(8)]
        public string HORA_SAIDA { get; set; }

        public int? NUMERO_FATURA { get; set; }

        [StringLength(100)]
        public string LOCAL_ENTREGA { get; set; }

        [StringLength(100)]
        public string LOCAL_COBRANCA { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? TAXA_COMISSAO { get; set; }

        public decimal? VALOR_COMISSAO { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [StringLength(1)]
        public string TIPO_FRETE { get; set; }

        [StringLength(1)]
        public string FORMA_PAGAMENTO { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public decimal? VALOR_SEGURO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }

        public virtual NOTA_FISCAL_TIPO NOTA_FISCAL_TIPO { get; set; }

        public virtual TRANSPORTADORA TRANSPORTADORA { get; set; }

        public virtual VENDA_CONDICOES_PAGAMENTO VENDA_CONDICOES_PAGAMENTO { get; set; }

        public virtual VENDEDOR VENDEDOR { get; set; }

        public virtual VENDA_ROMANEIO_ENTREGA VENDA_ROMANEIO_ENTREGA { get; set; }

        public virtual VENDA_ORCAMENTO_CABECALHO VENDA_ORCAMENTO_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_COMISSAO> VENDA_COMISSAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_DETALHE> VENDA_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_FRETE> VENDA_FRETE { get; set; }
    }
}
