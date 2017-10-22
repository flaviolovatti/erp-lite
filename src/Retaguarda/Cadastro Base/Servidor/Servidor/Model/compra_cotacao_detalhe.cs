namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_cotacao_detalhe")]
    public partial class compra_cotacao_detalhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra_cotacao_detalhe()
        {
            compra_cotacao_pedido_detalhe = new HashSet<compra_cotacao_pedido_detalhe>();
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

        public virtual compra_fornecedor_cotacao compra_fornecedor_cotacao { get; set; }

        public virtual Produto produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_cotacao_pedido_detalhe> compra_cotacao_pedido_detalhe { get; set; }
    }
}
