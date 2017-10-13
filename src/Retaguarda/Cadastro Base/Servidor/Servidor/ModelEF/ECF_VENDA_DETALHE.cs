namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_VENDA_DETALHE
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_ECF_PRODUTO { get; set; }

        public int? ID_ECF_VENDA_CABECALHO { get; set; }

        public int? CFOP { get; set; }

        [StringLength(14)]
        public string GTIN { get; set; }

        public int? CCF { get; set; }

        public int? COO { get; set; }

        [StringLength(20)]
        public string SERIE_ECF { get; set; }

        public int? ITEM { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        public decimal? TOTAL_ITEM { get; set; }

        public decimal? BASE_ICMS { get; set; }

        public decimal? TAXA_ICMS { get; set; }

        public decimal? ICMS { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? DESCONTO { get; set; }

        public decimal? TAXA_ISSQN { get; set; }

        public decimal? ISSQN { get; set; }

        public decimal? TAXA_PIS { get; set; }

        public decimal? PIS { get; set; }

        public decimal? TAXA_COFINS { get; set; }

        public decimal? COFINS { get; set; }

        public decimal? TAXA_ACRESCIMO { get; set; }

        public decimal? ACRESCIMO { get; set; }

        public decimal? ACRESCIMO_RATEIO { get; set; }

        public decimal? DESCONTO_RATEIO { get; set; }

        [StringLength(10)]
        public string TOTALIZADOR_PARCIAL { get; set; }

        [StringLength(3)]
        public string CST { get; set; }

        [StringLength(1)]
        public string CANCELADO { get; set; }

        [StringLength(1)]
        public string MOVIMENTA_ESTOQUE { get; set; }

        [StringLength(4)]
        public string ECF_ICMS_ST { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
