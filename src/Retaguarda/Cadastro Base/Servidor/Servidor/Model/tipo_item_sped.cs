namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tipo_item_sped")]
    public partial class tipo_item_sped
    {
        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(50)]
        public string descricao { get; set; }
    }
}
