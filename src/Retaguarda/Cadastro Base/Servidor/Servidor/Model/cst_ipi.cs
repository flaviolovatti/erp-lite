namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cst_ipi")]
    public partial class cst_ipi
    {
        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }

        public string observacao { get; set; }
    }
}