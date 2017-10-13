namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_COTACAO_PEDIDO_DETALHE
    {
        public int ID { get; set; }

        public int ID_COMPRA_PEDIDO { get; set; }

        public int ID_COMPRA_COTACAO_DETALHE { get; set; }

        public decimal? QUANTIDADE_PEDIDA { get; set; }

        public virtual COMPRA_COTACAO_DETALHE COMPRA_COTACAO_DETALHE { get; set; }

        public virtual COMPRA_PEDIDO COMPRA_PEDIDO { get; set; }
    }
}
