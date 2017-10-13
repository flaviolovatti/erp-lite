namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_FORNECEDOR_COTACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_FORNECEDOR_COTACAO()
        {
            COMPRA_COTACAO_DETALHE = new HashSet<COMPRA_COTACAO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COMPRA_COTACAO { get; set; }

        public int ID_FORNECEDOR { get; set; }

        [StringLength(30)]
        public string PRAZO_ENTREGA { get; set; }

        [StringLength(30)]
        public string VENDA_CONDICOES_PAGAMENTO { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? TOTAL { get; set; }

        public virtual COMPRA_COTACAO COMPRA_COTACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_COTACAO_DETALHE> COMPRA_COTACAO_DETALHE { get; set; }

        public virtual FORNECEDOR FORNECEDOR { get; set; }
    }
}
