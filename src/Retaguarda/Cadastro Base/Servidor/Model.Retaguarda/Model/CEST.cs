namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cest")]
    public partial class CEST
    {
        public int id { get; set; }

        [StringLength(10)]
        public string item { get; set; }

        [Column("cest")]
        [StringLength(10)]
        public string cest1 { get; set; }

        [StringLength(15)]
        public string ncm_sh { get; set; }

        [StringLength(100)]
        public string descricao_segmento { get; set; }

        public string descricao_cest { get; set; }

        [StringLength(2)]
        public string sigla_unidade { get; set; }

        [StringLength(20)]
        public string descricao_unidade { get; set; }
    }
}
