namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_COTACAO_DETALHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_COTACAO_DETALHE()
        {
            COMPRA_COTACAO_PEDIDO_DETALHE = new HashSet<COMPRA_COTACAO_PEDIDO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_COMPRA_FORNECEDOR_COTACAO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? QUANTIDADE_PEDIDA { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_COTACAO_PEDIDO_DETALHE> COMPRA_COTACAO_PEDIDO_DETALHE { get; set; }

        public virtual COMPRA_FORNECEDOR_COTACAO COMPRA_FORNECEDOR_COTACAO { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
