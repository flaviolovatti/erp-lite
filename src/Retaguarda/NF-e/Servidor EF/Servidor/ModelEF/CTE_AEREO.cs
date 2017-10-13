namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_AEREO
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        public int? NUMERO_MINUTA { get; set; }

        public int? NUMERO_CONHECIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PREVISTA_ENTREGA { get; set; }

        [StringLength(20)]
        public string ID_EMISSOR { get; set; }

        [StringLength(14)]
        public string ID_INTERNA_TOMADOR { get; set; }

        [StringLength(1)]
        public string TARIFA_CLASSE { get; set; }

        [StringLength(4)]
        public string TARIFA_CODIGO { get; set; }

        public decimal? TARIFA_VALOR { get; set; }

        [StringLength(14)]
        public string CARGA_DIMENSAO { get; set; }

        public int? CARGA_INFORMACAO_MANUSEIO { get; set; }

        [StringLength(3)]
        public string CARGA_ESPECIAL { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
