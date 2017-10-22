namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.unidade_conversao")]
    public partial class unidade_conversao
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        public int id_unidade_produto { get; set; }

        [StringLength(10)]
        public string sigla { get; set; }

        public string descricao { get; set; }

        public decimal? fator_conversao { get; set; }

        [StringLength(1)]
        public string acao { get; set; }

        public virtual Produto produto { get; set; }

        public virtual UnidadeProduto unidade_produto { get; set; }
    }
}
