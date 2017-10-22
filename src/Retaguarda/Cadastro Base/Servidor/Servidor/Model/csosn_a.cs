namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.csosn_a")]
    public partial class csosn_a
    {
        public int id { get; set; }

        [StringLength(1)]
        public string codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }

        public string observacao { get; set; }
    }
}
