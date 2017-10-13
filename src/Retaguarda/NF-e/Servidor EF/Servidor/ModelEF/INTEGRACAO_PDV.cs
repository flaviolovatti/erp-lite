namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INTEGRACAO_PDV
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string IDENTIFICA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INTEGRACAO { get; set; }

        [StringLength(8)]
        public string HORA_INTEGRACAO { get; set; }
    }
}
