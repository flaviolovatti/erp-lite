namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_promocao")]
    public partial class ProdutoPromocao
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fim { get; set; }

        public decimal? quantidade_em_promocao { get; set; }

        public decimal? quantidade_maxima_cliente { get; set; }

        public decimal? valor { get; set; }

        public virtual Produto produto { get; set; }
    }
}
