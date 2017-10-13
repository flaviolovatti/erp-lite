namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_RECEBIMENTO_NAO_FISCAL
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_ECF_MOVIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_RECEBIMENTO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public decimal? VALOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
