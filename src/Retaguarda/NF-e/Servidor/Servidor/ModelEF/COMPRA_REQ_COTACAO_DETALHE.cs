namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_REQ_COTACAO_DETALHE
    {
        public int ID { get; set; }

        public int ID_COMPRA_COTACAO { get; set; }

        public int ID_COMPRA_REQUISICAO_DETALHE { get; set; }

        public decimal? QUANTIDADE_COTADA { get; set; }

        public virtual COMPRA_COTACAO COMPRA_COTACAO { get; set; }

        public virtual COMPRA_REQUISICAO_DETALHE COMPRA_REQUISICAO_DETALHE { get; set; }
    }
}
