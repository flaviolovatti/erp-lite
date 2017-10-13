namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_CAIXA
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }
    }
}
