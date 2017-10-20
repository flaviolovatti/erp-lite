namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cst_icms_a")]
    public partial class CST_ICMS_A
    {
        public int id { get; set; }

        [Required]
        [StringLength(1)]
        public string codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }

        public string observacao { get; set; }
    }
}
