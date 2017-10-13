namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CFOP")]
    public partial class CFOP
    {
        public int ID { get; set; }

        [Column("CFOP")]
        public int? CFOP1 { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        public string APLICACAO { get; set; }
    }
}
