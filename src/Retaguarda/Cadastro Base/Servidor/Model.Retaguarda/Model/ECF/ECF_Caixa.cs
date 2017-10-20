namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_caixa")]
    public partial class ECF_Caixa
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }
    }
}
