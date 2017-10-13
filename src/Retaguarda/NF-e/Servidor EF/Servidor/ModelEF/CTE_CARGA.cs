namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_CARGA
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(2)]
        public string CODIGO_UNIDADE_MEDIDA { get; set; }

        [StringLength(20)]
        public string TIPO_MEDIDA { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
