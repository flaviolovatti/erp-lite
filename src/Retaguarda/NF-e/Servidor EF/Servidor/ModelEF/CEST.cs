namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CEST")]
    public partial class CEST
    {
        public int ID { get; set; }

        public int? ITEM { get; set; }

        [Column("CEST")]
        [StringLength(10)]
        public string CEST1 { get; set; }

        [StringLength(15)]
        public string NCM_SH { get; set; }

        [StringLength(100)]
        public string DESCRICAO_SEGMENTO { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO_CEST { get; set; }

        [StringLength(2)]
        public string SIGLA_UNIDADE { get; set; }

        [StringLength(20)]
        public string DESCRICAO_UNIDADE { get; set; }
    }
}
