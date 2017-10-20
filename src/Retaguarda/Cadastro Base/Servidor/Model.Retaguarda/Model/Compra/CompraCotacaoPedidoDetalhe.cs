namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_cotacao_pedido_detalhe")]
    public partial class CompraCotacaoPedidoDetalhe
    {
        public int id { get; set; }

        public int id_compra_pedido { get; set; }

        public int id_compra_cotacao_detalhe { get; set; }

        public decimal? quantidade_pedida { get; set; }

        public virtual CompraCotacaoDetalhe compra_cotacao_detalhe { get; set; }

        public virtual CompraPedido compra_pedido { get; set; }
    }
}
