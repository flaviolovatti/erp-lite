namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_DOCUMENTO_ANTERIOR_ID
    {
        public int ID { get; set; }

        public int ID_CTE_DOCUMENTO_ANTERIOR { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        [StringLength(2)]
        public string SUBSERIE { get; set; }

        [StringLength(20)]
        public string NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(44)]
        public string CHAVE_CTE { get; set; }

        public virtual CTE_DOCUMENTO_ANTERIOR CTE_DOCUMENTO_ANTERIOR { get; set; }
    }
}
