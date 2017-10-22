namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.estoque_reajuste_detalhe")]
    public partial class estoque_reajuste_detalhe
    {
        public int id { get; set; }

        public int id_estoque_reajuste_cabecalho { get; set; }

        public int id_produto { get; set; }

        public decimal? valor_original { get; set; }

        public decimal? valor_reajuste { get; set; }

        public decimal? quantidade_original { get; set; }

        public decimal? quantidade_reajuste { get; set; }

        public virtual estoque_reajuste_cabecalho estoque_reajuste_cabecalho { get; set; }

        public virtual Produto produto { get; set; }
    }
}
