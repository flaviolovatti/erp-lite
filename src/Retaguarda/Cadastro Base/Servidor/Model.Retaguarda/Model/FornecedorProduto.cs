namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fornecedor_produto")]
    public partial class FornecedorProduto
    {
        public int id { get; set; }

        public int id_fornecedor { get; set; }

        public int id_produto { get; set; }

        [StringLength(20)]
        public string codigo_fornecedor_produto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_ultima_compra { get; set; }

        public decimal? preco_ultima_compra { get; set; }

        public decimal? lote_minimo_compra { get; set; }

        public decimal? menor_embalagem_compra { get; set; }

        public decimal? custo_ultima_compra { get; set; }

        public virtual Fornecedor fornecedor { get; set; }

        public virtual Produto produto { get; set; }
    }
}
