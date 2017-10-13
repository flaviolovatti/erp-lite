namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAV_DETALHE_ALTERACAO
    {
        public int ID { get; set; }

        public int ID_DAV_DETALHE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ALTERACAO { get; set; }

        [StringLength(8)]
        public string HORA_ALTERACAO { get; set; }

        [StringLength(1)]
        public string TIPO_ALTERACAO { get; set; }

        [Column(TypeName = "text")]
        public string OBJETO { get; set; }

        public virtual DAV_DETALHE DAV_DETALHE { get; set; }
    }
}
