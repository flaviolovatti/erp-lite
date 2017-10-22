namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_lacre_entrada")]
    public partial class ProdutoLacreEntrada
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        public int id_lacre_produto { get; set; }

        public virtual Produto produto { get; set; }

        public virtual ProdutoLacre produto_lacre { get; set; }
    }
}
