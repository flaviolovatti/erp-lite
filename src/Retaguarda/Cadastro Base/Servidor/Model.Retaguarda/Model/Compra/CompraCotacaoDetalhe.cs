namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_cotacao_detalhe")]
    public partial class CompraCotacaoDetalhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraCotacaoDetalhe()
        {
            compra_cotacao_pedido_detalhe = new HashSet<CompraCotacaoPedidoDetalhe>();
        }

        public int id { get; set; }

        public int id_compra_fornecedor_cotacao { get; set; }

        public int id_produto { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? quantidade_pedida { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_total { get; set; }

        public virtual CompraFornecedorCotacao compra_fornecedor_cotacao { get; set; }

        public virtual Produto produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraCotacaoPedidoDetalhe> compra_cotacao_pedido_detalhe { get; set; }
    }
}
