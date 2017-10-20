namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_codigo_adicional")]
    public partial class ProdutoCodigoAdicional
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        [StringLength(14)]
        public string codigo { get; set; }

        public virtual Produto produto { get; set; }
    }
}
