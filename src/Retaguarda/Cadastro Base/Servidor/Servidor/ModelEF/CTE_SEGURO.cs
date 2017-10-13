namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_SEGURO
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        public int? RESPONSAVEL { get; set; }

        [StringLength(30)]
        public string SEGURADORA { get; set; }

        [StringLength(20)]
        public string APOLICE { get; set; }

        [StringLength(20)]
        public string AVERBACAO { get; set; }

        public decimal? VALOR_CARGA { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
