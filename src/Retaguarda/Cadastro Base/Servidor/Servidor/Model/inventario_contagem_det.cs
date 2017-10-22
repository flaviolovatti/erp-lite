namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.inventario_contagem_det")]
    public partial class inventario_contagem_det
    {
        public int id { get; set; }

        public int id_inventario_contagem_cab { get; set; }

        public int id_produto { get; set; }

        public decimal? contagem01 { get; set; }

        public decimal? contagem02 { get; set; }

        public decimal? contagem03 { get; set; }

        [StringLength(2)]
        public string fechado_contagem { get; set; }

        public decimal? quantidade_sistema { get; set; }

        public decimal? acuracidade { get; set; }

        public decimal? divergencia { get; set; }

        public virtual inventario_contagem_cab inventario_contagem_cab { get; set; }

        public virtual Produto produto { get; set; }
    }
}
