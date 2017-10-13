namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_RODOVIARIO_OCC
    {
        public int ID { get; set; }

        public int ID_CTE_RODOVIARIO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        public int? NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(10)]
        public string CODIGO_INTERNO { get; set; }

        [StringLength(14)]
        public string IE { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(14)]
        public string TELEFONE { get; set; }

        public virtual CTE_RODOVIARIO CTE_RODOVIARIO { get; set; }
    }
}
