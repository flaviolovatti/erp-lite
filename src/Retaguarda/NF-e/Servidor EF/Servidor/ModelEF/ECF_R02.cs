namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_R02
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int ID_OPERADOR { get; set; }

        public int ID_IMPRESSORA { get; set; }

        public int? ID_ECF_CAIXA { get; set; }

        [StringLength(20)]
        public string SERIE_ECF { get; set; }

        public int? CRZ { get; set; }

        public int? COO { get; set; }

        public int? CRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_MOVIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(8)]
        public string HORA_EMISSAO { get; set; }

        public decimal? VENDA_BRUTA { get; set; }

        public decimal? GRANDE_TOTAL { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
