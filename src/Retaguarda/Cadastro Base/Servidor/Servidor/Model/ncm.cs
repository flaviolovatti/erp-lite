namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ncm")]
    public partial class ncm
    {
        public int id { get; set; }

        [StringLength(8)]
        public string codigo { get; set; }

        public string descricao { get; set; }

        public string observacao { get; set; }
    }
}
