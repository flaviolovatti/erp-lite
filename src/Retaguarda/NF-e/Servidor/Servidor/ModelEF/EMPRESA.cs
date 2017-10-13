namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPRESA")]
    public partial class EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA()
        {
            ADM_PARAMETRO = new HashSet<ADM_PARAMETRO>();
            ALMOXARIFADO = new HashSet<ALMOXARIFADO>();
            CARGO = new HashSet<CARGO>();
            COMISSAO_PERFIL = new HashSet<COMISSAO_PERFIL>();
            COMPRA_TIPO_REQUISICAO = new HashSet<COMPRA_TIPO_REQUISICAO>();
            CONTA_CAIXA = new HashSet<CONTA_CAIXA>();
            CONVENIO = new HashSet<CONVENIO>();
            CTE_CABECALHO = new HashSet<CTE_CABECALHO>();
            CTE_CONFIGURACAO = new HashSet<CTE_CONFIGURACAO>();
            DAV_CABECALHO = new HashSet<DAV_CABECALHO>();
            EMPRESA1 = new HashSet<EMPRESA>();
            EMPRESA_CNAE = new HashSet<EMPRESA_CNAE>();
            EMPRESA_CONTATO = new HashSet<EMPRESA_CONTATO>();
            EMPRESA_ENDERECO = new HashSet<EMPRESA_ENDERECO>();
            EMPRESA_PRODUTO = new HashSet<EMPRESA_PRODUTO>();
            EMPRESA_PESSOA = new HashSet<EMPRESA_PESSOA>();
            EMPRESA_TELEFONE = new HashSet<EMPRESA_TELEFONE>();
            FIN_CONFIGURACAO_BOLETO = new HashSet<FIN_CONFIGURACAO_BOLETO>();
            FIN_DOCUMENTO_ORIGEM = new HashSet<FIN_DOCUMENTO_ORIGEM>();
            FIN_STATUS_PARCELA = new HashSet<FIN_STATUS_PARCELA>();
            FIN_TIPO_RECEBIMENTO = new HashSet<FIN_TIPO_RECEBIMENTO>();
            FIN_TIPO_PAGAMENTO = new HashSet<FIN_TIPO_PAGAMENTO>();
            INVENTARIO_CONTAGEM_CAB = new HashSet<INVENTARIO_CONTAGEM_CAB>();
            NFCE_CONFIGURACAO = new HashSet<NFCE_CONFIGURACAO>();
            NFCE_MOVIMENTO = new HashSet<NFCE_MOVIMENTO>();
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
            NFE_CONFIGURACAO = new HashSet<NFE_CONFIGURACAO>();
            NFE_NUMERO_INUTILIZADO = new HashSet<NFE_NUMERO_INUTILIZADO>();
            NFE_NUMERO = new HashSet<NFE_NUMERO>();
            NOTA_FISCAL_TIPO = new HashSet<NOTA_FISCAL_TIPO>();
            PLANO_CENTRO_RESULTADO = new HashSet<PLANO_CENTRO_RESULTADO>();
            PLANO_NATUREZA_FINANCEIRA = new HashSet<PLANO_NATUREZA_FINANCEIRA>();
            PRE_VENDA_CABECALHO = new HashSet<PRE_VENDA_CABECALHO>();
            QUADRO_SOCIETARIO = new HashSet<QUADRO_SOCIETARIO>();
            SETOR = new HashSet<SETOR>();
            TALONARIO_CHEQUE = new HashSet<TALONARIO_CHEQUE>();
            TRIBUT_GRUPO_TRIBUTARIO = new HashSet<TRIBUT_GRUPO_TRIBUTARIO>();
            TRIBUT_ICMS_CUSTOM_CAB = new HashSet<TRIBUT_ICMS_CUSTOM_CAB>();
            TRIBUT_OPERACAO_FISCAL = new HashSet<TRIBUT_OPERACAO_FISCAL>();
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
            VENDA_CONDICOES_PAGAMENTO = new HashSet<VENDA_CONDICOES_PAGAMENTO>();
            VENDA_ORCAMENTO_CABECALHO = new HashSet<VENDA_ORCAMENTO_CABECALHO>();
        }

        public int ID { get; set; }

        public int? ID_EMPRESA { get; set; }

        public int? ID_SINDICATO_PATRONAL { get; set; }

        public int? ID_CONTADOR { get; set; }

        [StringLength(150)]
        public string RAZAO_SOCIAL { get; set; }

        [StringLength(150)]
        public string NOME_FANTASIA { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(30)]
        public string INSCRICAO_ESTADUAL { get; set; }

        [StringLength(30)]
        public string INSCRICAO_ESTADUAL_ST { get; set; }

        [StringLength(30)]
        public string INSCRICAO_MUNICIPAL { get; set; }

        [StringLength(30)]
        public string INSCRICAO_JUNTA_COMERCIAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INSC_JUNTA_COMERCIAL { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INICIO_ATIVIDADES { get; set; }

        [StringLength(9)]
        public string SUFRAMA { get; set; }

        [StringLength(250)]
        public string EMAIL { get; set; }

        [Column(TypeName = "text")]
        public string IMAGEM_LOGOTIPO { get; set; }

        [StringLength(1)]
        public string CRT { get; set; }

        [StringLength(1)]
        public string TIPO_REGIME { get; set; }

        public decimal? ALIQUOTA_PIS { get; set; }

        [StringLength(50)]
        public string CONTATO { get; set; }

        public decimal? ALIQUOTA_COFINS { get; set; }

        public int? CODIGO_IBGE_CIDADE { get; set; }

        public int? CODIGO_IBGE_UF { get; set; }

        public int? CODIGO_TERCEIROS { get; set; }

        public int? CODIGO_GPS { get; set; }

        public decimal? ALIQUOTA_SAT { get; set; }

        [StringLength(12)]
        public string CEI { get; set; }

        [StringLength(7)]
        public string CODIGO_CNAE_PRINCIPAL { get; set; }

        [StringLength(1)]
        public string TIPO_CONTROLE_ESTOQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_PARAMETRO> ADM_PARAMETRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALMOXARIFADO> ALMOXARIFADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARGO> CARGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_PERFIL> COMISSAO_PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_TIPO_REQUISICAO> COMPRA_TIPO_REQUISICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTA_CAIXA> CONTA_CAIXA { get; set; }

        public virtual CONTADOR CONTADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONVENIO> CONVENIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_CABECALHO> CTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_CONFIGURACAO> CTE_CONFIGURACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_CABECALHO> DAV_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA> EMPRESA1 { get; set; }

        public virtual EMPRESA EMPRESA2 { get; set; }

        public virtual SINDICATO SINDICATO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_CNAE> EMPRESA_CNAE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_CONTATO> EMPRESA_CONTATO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_ENDERECO> EMPRESA_ENDERECO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_PRODUTO> EMPRESA_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_PESSOA> EMPRESA_PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_TELEFONE> EMPRESA_TELEFONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CONFIGURACAO_BOLETO> FIN_CONFIGURACAO_BOLETO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_DOCUMENTO_ORIGEM> FIN_DOCUMENTO_ORIGEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_STATUS_PARCELA> FIN_STATUS_PARCELA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_TIPO_RECEBIMENTO> FIN_TIPO_RECEBIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_TIPO_PAGAMENTO> FIN_TIPO_PAGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO_CONTAGEM_CAB> INVENTARIO_CONTAGEM_CAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_CONFIGURACAO> NFCE_CONFIGURACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_MOVIMENTO> NFCE_MOVIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CONFIGURACAO> NFE_CONFIGURACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_NUMERO_INUTILIZADO> NFE_NUMERO_INUTILIZADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_NUMERO> NFE_NUMERO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTA_FISCAL_TIPO> NOTA_FISCAL_TIPO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANO_CENTRO_RESULTADO> PLANO_CENTRO_RESULTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLANO_NATUREZA_FINANCEIRA> PLANO_NATUREZA_FINANCEIRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_VENDA_CABECALHO> PRE_VENDA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QUADRO_SOCIETARIO> QUADRO_SOCIETARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SETOR> SETOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TALONARIO_CHEQUE> TALONARIO_CHEQUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_GRUPO_TRIBUTARIO> TRIBUT_GRUPO_TRIBUTARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_ICMS_CUSTOM_CAB> TRIBUT_ICMS_CUSTOM_CAB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_OPERACAO_FISCAL> TRIBUT_OPERACAO_FISCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CONDICOES_PAGAMENTO> VENDA_CONDICOES_PAGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ORCAMENTO_CABECALHO> VENDA_ORCAMENTO_CABECALHO { get; set; }
    }
}
