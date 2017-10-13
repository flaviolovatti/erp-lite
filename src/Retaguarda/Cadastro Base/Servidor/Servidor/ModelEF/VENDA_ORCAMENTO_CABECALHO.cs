namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_ORCAMENTO_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA_ORCAMENTO_CABECALHO()
        {
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
            VENDA_ORCAMENTO_DETALHE = new HashSet<VENDA_ORCAMENTO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int ID_VENDA_CONDICOES_PAGAMENTO { get; set; }

        public int ID_VENDEDOR { get; set; }

        public int? ID_TRANSPORTADORA { get; set; }

        public int ID_CLIENTE { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [StringLength(20)]
        public string CODIGO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ENTREGA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALIDADE { get; set; }

        [StringLength(1)]
        public string TIPO_FRETE { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public decimal? TAXA_COMISSAO { get; set; }

        public decimal? VALOR_COMISSAO { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual TRANSPORTADORA TRANSPORTADORA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }

        public virtual VENDA_CONDICOES_PAGAMENTO VENDA_CONDICOES_PAGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ORCAMENTO_DETALHE> VENDA_ORCAMENTO_DETALHE { get; set; }

        public virtual VENDEDOR VENDEDOR { get; set; }
    }
}
