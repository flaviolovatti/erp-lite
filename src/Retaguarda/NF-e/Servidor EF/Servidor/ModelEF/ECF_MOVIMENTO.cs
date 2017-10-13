namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_MOVIMENTO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_ECF_EMPRESA { get; set; }

        public int? ID_ECF_TURNO { get; set; }

        public int? ID_ECF_IMPRESSORA { get; set; }

        public int? ID_ECF_OPERADOR { get; set; }

        public int? ID_ECF_CAIXA { get; set; }

        public int ID_GERENTE_SUPERVISOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ABERTURA { get; set; }

        [StringLength(8)]
        public string HORA_ABERTURA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FECHAMENTO { get; set; }

        [StringLength(8)]
        public string HORA_FECHAMENTO { get; set; }

        public decimal? TOTAL_SUPRIMENTO { get; set; }

        public decimal? TOTAL_SANGRIA { get; set; }

        public decimal? TOTAL_NAO_FISCAL { get; set; }

        public decimal? TOTAL_VENDA { get; set; }

        public decimal? TOTAL_DESCONTO { get; set; }

        public decimal? TOTAL_ACRESCIMO { get; set; }

        public decimal? TOTAL_FINAL { get; set; }

        public decimal? TOTAL_RECEBIDO { get; set; }

        public decimal? TOTAL_TROCO { get; set; }

        public decimal? TOTAL_CANCELADO { get; set; }

        [Required]
        [StringLength(1)]
        public string STATUS_MOVIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
