namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ficha_tecnica")]
    public partial class ficha_tecnica
    {
        public int id { get; set; }

        public int id_produto { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        public int? id_produto_filho { get; set; }

        public decimal? quantidade { get; set; }

        public int? sequencia_producao { get; set; }

        public virtual Produto produto { get; set; }
    }
}
