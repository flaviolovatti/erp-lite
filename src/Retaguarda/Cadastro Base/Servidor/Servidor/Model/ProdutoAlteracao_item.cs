namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_alteracao_item")]
    public partial class ProdutoAlteracao_item
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        [StringLength(14)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inicial { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_final { get; set; }

        public virtual Produto produto { get; set; }
    }
}
