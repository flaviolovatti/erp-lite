namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DUPLICATA
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(60)]
        public string NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENCIMENTO { get; set; }

        public decimal? VALOR { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
