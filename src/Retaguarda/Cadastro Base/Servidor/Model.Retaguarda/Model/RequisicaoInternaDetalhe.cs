namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.requisicao_interna_detalhe")]
    public partial class RequisicaoInternaDetalhe
    {
        public int id { get; set; }

        public int id_req_interna_cabecalho { get; set; }

        public int id_produto { get; set; }

        public decimal quantidade { get; set; }

        public virtual Produto produto { get; set; }

        public virtual RequisicaoInternaCabecalho requisicao_interna_cabecalho { get; set; }
    }
}
