namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_cotacao_pedido_detalhe")]
    public partial class compra_cotacao_pedido_detalhe
    {
        public int id { get; set; }

        public int id_compra_pedido { get; set; }

        public int id_compra_cotacao_detalhe { get; set; }

        public decimal? quantidade_pedida { get; set; }

        public virtual compra_cotacao_detalhe compra_cotacao_detalhe { get; set; }

        public virtual compra_pedido compra_pedido { get; set; }
    }
}
