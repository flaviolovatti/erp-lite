namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_pedido")]
    public partial class CompraPedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraPedido()
        {
            compra_cotacao_pedido_detalhe = new HashSet<CompraCotacaoPedidoDetalhe>();
            compra_pedido_detalhe = new HashSet<CompraPedidoDetalhe>();
        }

        public int id { get; set; }

        public int id_compra_tipo_pedido { get; set; }

        public int id_fornecedor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_pedido { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_prevista_entrega { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_previsao_pagamento { get; set; }

        [StringLength(100)]
        public string local_entrega { get; set; }

        [StringLength(100)]
        public string local_cobranca { get; set; }

        [StringLength(30)]
        public string contato { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_total_pedido { get; set; }

        [StringLength(1)]
        public string tipo_frete { get; set; }

        [StringLength(1)]
        public string forma_pagamento { get; set; }

        public decimal? base_calculo_icms { get; set; }

        public decimal? valor_icms { get; set; }

        public decimal? base_calculo_icms_st { get; set; }

        public decimal? valor_icms_st { get; set; }

        public decimal? valor_total_produtos { get; set; }

        public decimal? valor_frete { get; set; }

        public decimal? valor_seguro { get; set; }

        public decimal? valor_outras_despesas { get; set; }

        public decimal? valor_ipi { get; set; }

        public decimal? valor_total_nf { get; set; }

        public int? quantidade_parcelas { get; set; }

        public int? dias_primeiro_vencimento { get; set; }

        public int? dias_intervalo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraCotacaoPedidoDetalhe> compra_cotacao_pedido_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraPedidoDetalhe> compra_pedido_detalhe { get; set; }

        public virtual CompraTipoPedido compra_tipo_pedido { get; set; }

        public virtual Fornecedor fornecedor { get; set; }
    }
}
