namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_PERIGOSO
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(4)]
        public string NUMERO_ONU { get; set; }

        [StringLength(150)]
        public string NOME_APROPRIADO { get; set; }

        [StringLength(40)]
        public string CLASSE_RISCO { get; set; }

        [StringLength(6)]
        public string GRUPO_EMBALAGEM { get; set; }

        [StringLength(20)]
        public string QUANTIDADE_TOTAL_PRODUTO { get; set; }

        [StringLength(60)]
        public string QUANTIDADE_TIPO_VOLUME { get; set; }

        [StringLength(6)]
        public string PONTO_FULGOR { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
