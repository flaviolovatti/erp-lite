namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.csosn_b")]
    public partial class CSOSN_B
    {
        public int id { get; set; }

        [StringLength(3)]
        public string codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }

        public string observacao { get; set; }
    }
}
