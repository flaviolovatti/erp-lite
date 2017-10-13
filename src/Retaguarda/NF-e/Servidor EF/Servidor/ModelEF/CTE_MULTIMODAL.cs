namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_MULTIMODAL
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(20)]
        public string COTM { get; set; }

        public int? INDICADOR_NEGOCIAVEL { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
