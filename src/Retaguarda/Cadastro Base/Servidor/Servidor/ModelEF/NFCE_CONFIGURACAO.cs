namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_CONFIGURACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_CONFIGURACAO()
        {
            NFCE_CONFIGURACAO_LEITOR_SER = new HashSet<NFCE_CONFIGURACAO_LEITOR_SER>();
            NFCE_CONFIGURACAO_BALANCA = new HashSet<NFCE_CONFIGURACAO_BALANCA>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int ID_NFCE_CAIXA { get; set; }

        public int ID_NFCE_RESOLUCAO { get; set; }

        [StringLength(250)]
        public string MENSAGEM_CUPOM { get; set; }

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

        public int? CFOP { get; set; }

        public int? DECIMAIS_QUANTIDADE { get; set; }

        public int? DECIMAIS_VALOR { get; set; }

        public int? QUANTIDADE_MAXIMA_PARCELA { get; set; }

        [StringLength(1)]
        public string IMPRIME_PARCELA { get; set; }

        [StringLength(32)]
        public string CODIGO_CSC { get; set; }

        [StringLength(6)]
        public string ID_TOKEN_CSC { get; set; }

        [StringLength(100)]
        public string CERTIFICADO_DIGITAL_SERIE { get; set; }

        [Column(TypeName = "text")]
        public string CERTIFICADO_DIGITAL_CAMINHO { get; set; }

        [StringLength(100)]
        public string CERTIFICADO_DIGITAL_SENHA { get; set; }

        public int? TIPO_EMISSAO { get; set; }

        public int? FORMATO_IMPRESSAO_DANFE { get; set; }

        public int? PROCESSO_EMISSAO { get; set; }

        [StringLength(20)]
        public string VERSAO_PROCESSO_EMISSAO { get; set; }

        [Column(TypeName = "text")]
        public string CAMINHO_LOGOMARCA { get; set; }

        [StringLength(1)]
        public string SALVAR_XML { get; set; }

        [Column(TypeName = "text")]
        public string CAMINHO_SALVAR_XML { get; set; }

        [Column(TypeName = "text")]
        public string CAMINHO_SCHEMAS { get; set; }

        [Column(TypeName = "text")]
        public string CAMINHO_ARQUIVO_DANFE { get; set; }

        [Column(TypeName = "text")]
        public string CAMINHO_SALVAR_PDF { get; set; }

        [StringLength(2)]
        public string WEBSERVICE_UF { get; set; }

        public int? WEBSERVICE_AMBIENTE { get; set; }

        [StringLength(100)]
        public string WEBSERVICE_PROXY_HOST { get; set; }

        public int? WEBSERVICE_PROXY_PORTA { get; set; }

        [StringLength(100)]
        public string WEBSERVICE_PROXY_USUARIO { get; set; }

        [StringLength(100)]
        public string WEBSERVICE_PROXY_SENHA { get; set; }

        [StringLength(1)]
        public string WEBSERVICE_VISUALIZAR { get; set; }

        [StringLength(100)]
        public string EMAIL_SERVIDOR_SMTP { get; set; }

        public int? EMAIL_PORTA { get; set; }

        [StringLength(100)]
        public string EMAIL_USUARIO { get; set; }

        [StringLength(100)]
        public string EMAIL_SENHA { get; set; }

        [StringLength(100)]
        public string EMAIL_ASSUNTO { get; set; }

        [StringLength(1)]
        public string EMAIL_AUTENTICA_SSL { get; set; }

        [Column(TypeName = "text")]
        public string EMAIL_TEXTO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual NFCE_CAIXA NFCE_CAIXA { get; set; }

        public virtual NFCE_RESOLUCAO NFCE_RESOLUCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_CONFIGURACAO_LEITOR_SER> NFCE_CONFIGURACAO_LEITOR_SER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_CONFIGURACAO_BALANCA> NFCE_CONFIGURACAO_BALANCA { get; set; }
    }
}
