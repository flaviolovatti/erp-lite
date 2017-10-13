namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ECF_CONFIGURACAO
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string NOME_CAIXA { get; set; }

        public int? ID_GERADO_CAIXA { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_ECF_IMPRESSORA { get; set; }

        public int? ID_ECF_RESOLUCAO { get; set; }

        public int? ID_ECF_CAIXA { get; set; }

        public int? ID_ECF_EMPRESA { get; set; }

        [StringLength(250)]
        public string MENSAGEM_CUPOM { get; set; }

        [StringLength(10)]
        public string PORTA_ECF { get; set; }

        [StringLength(15)]
        public string IP_SERVIDOR { get; set; }

        [StringLength(15)]
        public string IP_SITEF { get; set; }

        [StringLength(2)]
        public string TIPO_TEF { get; set; }

        [StringLength(100)]
        public string TITULO_TELA_CAIXA { get; set; }

        [StringLength(250)]
        public string CAMINHO_IMAGENS_PRODUTOS { get; set; }

        [StringLength(250)]
        public string CAMINHO_IMAGENS_MARKETING { get; set; }

        [StringLength(250)]
        public string CAMINHO_IMAGENS_LAYOUT { get; set; }

        [StringLength(20)]
        public string COR_JANELAS_INTERNAS { get; set; }

        [StringLength(1)]
        public string MARKETING_ATIVO { get; set; }

        public int? CFOP_ECF { get; set; }

        public int? CFOP_NF2 { get; set; }

        public int? TIMEOUT_ECF { get; set; }

        public int? INTERVALO_ECF { get; set; }

        [StringLength(20)]
        public string DESCRICAO_SUPRIMENTO { get; set; }

        [StringLength(20)]
        public string DESCRICAO_SANGRIA { get; set; }

        public int? TEF_TIPO_GP { get; set; }

        public int? TEF_TEMPO_ESPERA { get; set; }

        public int? TEF_ESPERA_STS { get; set; }

        public int? TEF_NUMERO_VIAS { get; set; }

        public int? DECIMAIS_QUANTIDADE { get; set; }

        public int? DECIMAIS_VALOR { get; set; }

        public int? BITS_POR_SEGUNDO { get; set; }

        public int? QTDE_MAXIMA_CARTOES { get; set; }

        [StringLength(1)]
        public string PESQUISA_PARTE { get; set; }

        [StringLength(100)]
        public string CONFIGURACAO_BALANCA { get; set; }

        [StringLength(250)]
        public string PARAMETROS_DIVERSOS { get; set; }

        public int? ULTIMA_EXCLUSAO { get; set; }

        [StringLength(10)]
        public string LAUDO { get; set; }

        [StringLength(100)]
        public string INDICE_GERENCIAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ATUALIZACAO_ESTOQUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SINCRONIZACAO { get; set; }

        [StringLength(8)]
        public string HORA_SINCRONIZACAO { get; set; }
    }
}
