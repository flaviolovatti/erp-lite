namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_req_cotacao_detalhe")]
    public partial class compra_req_cotacao_detalhe
    {
        public int id { get; set; }

        public int id_compra_cotacao { get; set; }

        public int id_compra_requisicao_detalhe { get; set; }

        public decimal? quantidade_cotada { get; set; }

        public virtual compra_cotacao compra_cotacao { get; set; }

        public virtual compra_requisicao_detalhe compra_requisicao_detalhe { get; set; }
    }
}
