namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cst_pis")]
    public partial class cst_pis
    {
        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }
    }
}