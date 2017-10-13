namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_R07
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_R06 { get; set; }

        public int? CCF { get; set; }

        [StringLength(20)]
        public string MEIO_PAGAMENTO { get; set; }

        public decimal? VALOR_PAGAMENTO { get; set; }

        [StringLength(1)]
        public string ESTORNO { get; set; }

        public decimal? VALOR_ESTORNO { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
