namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cliente_grupo_det")]
    public partial class fin_cliente_grupo_det
    {
        public int id { get; set; }

        public int id_cliente { get; set; }

        public int id_fin_cliente_grupo_cab { get; set; }

        [StringLength(2)]
        public string dia_lancamento { get; set; }

        public decimal? valor { get; set; }

        [StringLength(1)]
        public string gera_boleto { get; set; }

        public virtual Cliente cliente { get; set; }

        public virtual fin_cliente_grupo_cab fin_cliente_grupo_cab { get; set; }
    }
}
