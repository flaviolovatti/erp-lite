namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_combo_item")]
    public partial class ProdutoComboItem
    {
        public int id { get; set; }

        public int id_produto_combo { get; set; }

        public int id_produto { get; set; }

        public decimal? taxa_desconto { get; set; }

        public virtual Produto produto { get; set; }

        public virtual ProdutoCombo produto_combo { get; set; }
    }
}
