namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE_RASTRO
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        [StringLength(20)]
        public string NUMERO_LOTE { get; set; }

        public decimal? QUANTIDADE_LOTE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FABRICACAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VALIDADE { get; set; }

        [StringLength(20)]
        public string CODIGO_AGREGACAO { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
