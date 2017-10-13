namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOG_IMPORTACAO
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_IMPORTACAO { get; set; }

        [StringLength(8)]
        public string HORA_IMPORTACAO { get; set; }

        [Column(TypeName = "text")]
        public string ERRO { get; set; }

        [Column(TypeName = "text")]
        public string REGISTRO { get; set; }
    }
}
