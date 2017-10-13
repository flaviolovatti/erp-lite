namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_PASSAGEM
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(15)]
        public string SIGLA_PASSAGEM { get; set; }

        [StringLength(15)]
        public string SIGLA_DESTINO { get; set; }

        [StringLength(10)]
        public string ROTA { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
