namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFE_CABECALHO()
        {
            NFE_ACESSO_XML = new HashSet<NFE_ACESSO_XML>();
            NFE_CANA = new HashSet<NFE_CANA>();
            NFE_CTE_REFERENCIADO = new HashSet<NFE_CTE_REFERENCIADO>();
            NFE_CUPOM_FISCAL_REFERENCIADO = new HashSet<NFE_CUPOM_FISCAL_REFERENCIADO>();
            NFE_DESTINATARIO = new HashSet<NFE_DESTINATARIO>();
            NFE_DETALHE = new HashSet<NFE_DETALHE>();
            NFE_DUPLICATA = new HashSet<NFE_DUPLICATA>();
            NFE_EMITENTE = new HashSet<NFE_EMITENTE>();
            NFE_FATURA = new HashSet<NFE_FATURA>();
            NFE_FORMA_PAGAMENTO = new HashSet<NFE_FORMA_PAGAMENTO>();
            NFE_LOCAL_RETIRADA = new HashSet<NFE_LOCAL_RETIRADA>();
            NFE_LOCAL_ENTREGA = new HashSet<NFE_LOCAL_ENTREGA>();
            NFE_NF_REFERENCIADA = new HashSet<NFE_NF_REFERENCIADA>();
            NFE_PROCESSO_REFERENCIADO = new HashSet<NFE_PROCESSO_REFERENCIADO>();
            NFE_PROD_RURAL_REFERENCIADA = new HashSet<NFE_PROD_RURAL_REFERENCIADA>();
            NFE_REFERENCIADA = new HashSet<NFE_REFERENCIADA>();
            NFE_TRANSPORTE = new HashSet<NFE_TRANSPORTE>();
            PRODUTO_LOTE = new HashSet<PRODUTO_LOTE>();
        }

        public int ID { get; set; }

        public int? ID_NFCE_MOVIMENTO { get; set; }

        public int? ID_VENDEDOR { get; set; }

        public int? ID_TRIBUT_OPERACAO_FISCAL { get; set; }

        public int? ID_VENDA_CABECALHO { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_FORNECEDOR { get; set; }

        public int? ID_CLIENTE { get; set; }

        public int? UF_EMITENTE { get; set; }

        [StringLength(8)]
        public string CODIGO_NUMERICO { get; set; }

        [StringLength(60)]
        public string NATUREZA_OPERACAO { get; set; }

        [StringLength(2)]
        public string CODIGO_MODELO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        [StringLength(9)]
        public string NUMERO { get; set; }

        public DateTime? DATA_HORA_EMISSAO { get; set; }

        public DateTime? DATA_HORA_ENTRADA_SAIDA { get; set; }

        public int? TIPO_OPERACAO { get; set; }

        public int? LOCAL_DESTINO { get; set; }

        public int? CODIGO_MUNICIPIO { get; set; }

        public int? FORMATO_IMPRESSAO_DANFE { get; set; }

        public int? TIPO_EMISSAO { get; set; }

        [StringLength(44)]
        public string CHAVE_ACESSO { get; set; }

        [StringLength(1)]
        public string DIGITO_CHAVE_ACESSO { get; set; }

        public int? AMBIENTE { get; set; }

        public int? FINALIDADE_EMISSAO { get; set; }

        public int? CONSUMIDOR_OPERACAO { get; set; }

        public int? CONSUMIDOR_PRESENCA { get; set; }

        public int? PROCESSO_EMISSAO { get; set; }

        [StringLength(20)]
        public string VERSAO_PROCESSO_EMISSAO { get; set; }

        public DateTime? DATA_ENTRADA_CONTINGENCIA { get; set; }

        [StringLength(255)]
        public string JUSTIFICATIVA_CONTINGENCIA { get; set; }

        public decimal? BASE_CALCULO_ICMS { get; set; }

        public decimal? VALOR_ICMS { get; set; }

        public decimal? VALOR_ICMS_DESONERADO { get; set; }

        public decimal? BASE_CALCULO_ICMS_ST { get; set; }

        public decimal? VALOR_ICMS_ST { get; set; }

        public decimal? VALOR_TOTAL_PRODUTOS { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public decimal? VALOR_SEGURO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_IMPOSTO_IMPORTACAO { get; set; }

        public decimal? VALOR_IPI { get; set; }

        public decimal? VALOR_PIS { get; set; }

        public decimal? VALOR_COFINS { get; set; }

        public decimal? VALOR_DESPESAS_ACESSORIAS { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        public decimal? VALOR_SERVICOS { get; set; }

        public decimal? BASE_CALCULO_ISSQN { get; set; }

        public decimal? VALOR_ISSQN { get; set; }

        public decimal? VALOR_PIS_ISSQN { get; set; }

        public decimal? VALOR_COFINS_ISSQN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_PRESTACAO_SERVICO { get; set; }

        public decimal? VALOR_DEDUCAO_ISSQN { get; set; }

        public decimal? OUTRAS_RETENCOES_ISSQN { get; set; }

        public decimal? DESCONTO_INCONDICIONADO_ISSQN { get; set; }

        public decimal? DESCONTO_CONDICIONADO_ISSQN { get; set; }

        public decimal? TOTAL_RETENCAO_ISSQN { get; set; }

        public int? REGIME_ESPECIAL_TRIBUTACAO { get; set; }

        public decimal? VALOR_RETIDO_PIS { get; set; }

        public decimal? VALOR_RETIDO_COFINS { get; set; }

        public decimal? VALOR_RETIDO_CSLL { get; set; }

        public decimal? BASE_CALCULO_IRRF { get; set; }

        public decimal? VALOR_RETIDO_IRRF { get; set; }

        public decimal? BASE_CALCULO_PREVIDENCIA { get; set; }

        public decimal? VALOR_RETIDO_PREVIDENCIA { get; set; }

        public decimal? TROCO { get; set; }

        [StringLength(2)]
        public string COMEX_UF_EMBARQUE { get; set; }

        [StringLength(60)]
        public string COMEX_LOCAL_EMBARQUE { get; set; }

        [StringLength(60)]
        public string COMEX_LOCAL_DESPACHO { get; set; }

        [StringLength(22)]
        public string COMPRA_NOTA_EMPENHO { get; set; }

        [StringLength(60)]
        public string COMPRA_PEDIDO { get; set; }

        [StringLength(60)]
        public string COMPRA_CONTRATO { get; set; }

        [Column(TypeName = "text")]
        public string INFORMACOES_ADD_FISCO { get; set; }

        [Column(TypeName = "text")]
        public string INFORMACOES_ADD_CONTRIBUINTE { get; set; }

        public int? STATUS_NOTA { get; set; }

        public int? QUANTIDADE_IMPRESSAO_DANFE { get; set; }

        [StringLength(1)]
        public string INDICADOR_PRESENCA { get; set; }

        public decimal? VALOR_FPC { get; set; }

        public decimal? VALOR_FPC_ST { get; set; }

        public decimal? VALOR_FPC_ST_RETIDO { get; set; }

        public decimal? VALOR_IPI_DEVOLVIDO { get; set; }

        [StringLength(20)]
        public string VERSAO_APLICATIVO { get; set; }

        public DateTime? DATA_HORA_PROCESSAMENTO { get; set; }

        [StringLength(15)]
        public string NUMERO_PROTOCOLO { get; set; }

        [StringLength(28)]
        public string DIGEST_VALUE { get; set; }

        [StringLength(3)]
        public string CODIGO_STATUS_RESPOSTA { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO_MOTIVO_RESPOSTA { get; set; }

        [StringLength(255)]
        public string JUSTIFICATIVA_CANCELAMENTO { get; set; }

        public decimal? VALOR_ICMS_FPC_UF_DESTINO { get; set; }

        public decimal? VALOR_ICMS_INTER_UF_DESTINO { get; set; }

        public decimal? VALOR_ICMS_INTER_UF_REMETENTE { get; set; }

        [Column(TypeName = "text")]
        public string QRCODE { get; set; }

        [StringLength(85)]
        public string URL_CHAVE { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual FORNECEDOR FORNECEDOR { get; set; }

        public virtual NFCE_MOVIMENTO NFCE_MOVIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_ACESSO_XML> NFE_ACESSO_XML { get; set; }

        public virtual TRIBUT_OPERACAO_FISCAL TRIBUT_OPERACAO_FISCAL { get; set; }

        public virtual VENDA_CABECALHO VENDA_CABECALHO { get; set; }

        public virtual VENDEDOR VENDEDOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CANA> NFE_CANA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CTE_REFERENCIADO> NFE_CTE_REFERENCIADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CUPOM_FISCAL_REFERENCIADO> NFE_CUPOM_FISCAL_REFERENCIADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DESTINATARIO> NFE_DESTINATARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE> NFE_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DUPLICATA> NFE_DUPLICATA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_EMITENTE> NFE_EMITENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_FATURA> NFE_FATURA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_FORMA_PAGAMENTO> NFE_FORMA_PAGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_LOCAL_RETIRADA> NFE_LOCAL_RETIRADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_LOCAL_ENTREGA> NFE_LOCAL_ENTREGA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_NF_REFERENCIADA> NFE_NF_REFERENCIADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_PROCESSO_REFERENCIADO> NFE_PROCESSO_REFERENCIADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_PROD_RURAL_REFERENCIADA> NFE_PROD_RURAL_REFERENCIADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_REFERENCIADA> NFE_REFERENCIADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_TRANSPORTE> NFE_TRANSPORTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_LOTE> PRODUTO_LOTE { get; set; }
    }
}
