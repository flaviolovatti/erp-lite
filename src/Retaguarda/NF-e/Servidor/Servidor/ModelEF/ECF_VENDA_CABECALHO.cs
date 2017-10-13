namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_VENDA_CABECALHO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_CLIENTE { get; set; }

        public int? ID_ECF_FUNCIONARIO { get; set; }

        public int? ID_ECF_MOVIMENTO { get; set; }

        public int? ID_ECF_DAV { get; set; }

        public int? ID_ECF_PRE_VENDA_CABECALHO { get; set; }

        [StringLength(20)]
        public string SERIE_ECF { get; set; }

        public int? CFOP { get; set; }

        public int? COO { get; set; }

        public int? CCF { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENDA { get; set; }

        [StringLength(8)]
        public string HORA_VENDA { get; set; }

        public decimal? VALOR_VENDA { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? DESCONTO { get; set; }

        public decimal? TAXA_ACRESCIMO { get; set; }

        public decimal? ACRESCIMO { get; set; }

        public decimal? VALOR_FINAL { get; set; }

        public decimal? VALOR_RECEBIDO { get; set; }

        public decimal? TROCO { get; set; }

        public decimal? VALOR_CANCELADO { get; set; }

        public decimal? TOTAL_PRODUTOS { get; set; }

        public decimal? TOTAL_DOCUMENTO { get; set; }

        public decimal? BASE_ICMS { get; set; }

        public decimal? ICMS { get; set; }

        public decimal? ICMS_OUTRAS { get; set; }

        public decimal? ISSQN { get; set; }

        public decimal? PIS { get; set; }

        public decimal? COFINS { get; set; }

        public decimal? ACRESCIMO_ITENS { get; set; }

        public decimal? DESCONTO_ITENS { get; set; }

        [StringLength(1)]
        public string STATUS_VENDA { get; set; }

        [StringLength(100)]
        public string NOME_CLIENTE { get; set; }

        [StringLength(14)]
        public string CPF_CNPJ_CLIENTE { get; set; }

        [StringLength(1)]
        public string CUPOM_CANCELADO { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
