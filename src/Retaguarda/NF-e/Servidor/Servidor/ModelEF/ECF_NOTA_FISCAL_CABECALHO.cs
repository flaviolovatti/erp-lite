namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_NOTA_FISCAL_CABECALHO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_ECF_FUNCIONARIO { get; set; }

        public int? ID_CLIENTE { get; set; }

        [StringLength(14)]
        public string CPF_CNPJ_CLIENTE { get; set; }

        public int? CFOP { get; set; }

        [StringLength(6)]
        public string NUMERO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(8)]
        public string HORA_EMISSAO { get; set; }

        [StringLength(2)]
        public string SERIE { get; set; }

        [StringLength(2)]
        public string SUBSERIE { get; set; }

        public decimal? TOTAL_PRODUTOS { get; set; }

        public decimal? TOTAL_NF { get; set; }

        public decimal? BASE_ICMS { get; set; }

        public decimal? ICMS { get; set; }

        public decimal? ICMS_OUTRAS { get; set; }

        public decimal? ISSQN { get; set; }

        public decimal? PIS { get; set; }

        public decimal? COFINS { get; set; }

        public decimal? IPI { get; set; }

        public decimal? TAXA_ACRESCIMO { get; set; }

        public decimal? ACRESCIMO { get; set; }

        public decimal? ACRESCIMO_ITENS { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? DESCONTO { get; set; }

        public decimal? DESCONTO_ITENS { get; set; }

        [StringLength(1)]
        public string CANCELADA { get; set; }

        [StringLength(1)]
        public string TIPO_NOTA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
