namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tabela_preco_produto")]
    public partial class TabelaPrecoProduto
    {
        public int id { get; set; }

        public int id_tabela_preco { get; set; }

        public int id_produto { get; set; }

        public decimal? preco { get; set; }

        public virtual Produto produto { get; set; }

        public virtual TabelaPreco tabela_preco { get; set; }
    }
}
