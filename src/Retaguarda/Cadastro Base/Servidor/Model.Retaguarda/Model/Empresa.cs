namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.empresa")]
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            adm_parametro = new HashSet<ADM_Parametro>();
            almoxarifadoes = new HashSet<Almoxarifado>();
            cargoes = new HashSet<Cargo>();
            comissao_perfil = new HashSet<ComissaoPerfil>();
            compra_tipo_requisicao = new HashSet<CompraTipoRequisicao>();
            conta_caixa = new HashSet<ContaCaixa>();
            convenios = new HashSet<Convenio>();
            cte_cabecalho = new HashSet<CTe_Cabecalho>();
            cte_configuracao = new HashSet<CTe_Configuracao>();
            dav_cabecalho = new HashSet<DAV_Cabecalho>();
            empresa_cnae = new HashSet<EmpresaCNAE>();
            empresa_contato = new HashSet<EmpresaContato>();
            empresa_endereco = new HashSet<EmpresaEndereco>();
            empresa1 = new HashSet<Empresa>();
            empresa_pessoa = new HashSet<EmpresaPessoa>();
            empresa_produto = new HashSet<EmpresaProduto>();
            empresa_telefone = new HashSet<EmpresaTelefone>();
            fin_configuracao_boleto = new HashSet<FIN_ConfiguracaoBoleto>();
            fin_documento_origem = new HashSet<FIN_DocumentoOrigem>();
            fin_status_parcela = new HashSet<FIN_StatusParcela>();
            fin_tipo_pagamento = new HashSet<FIN_TipoPagamento>();
            fin_tipo_recebimento = new HashSet<FIN_TipoRecebimento>();
            inventario_contagem_cab = new HashSet<InventarioContagemCabecalho>();
            nfce_configuracao = new HashSet<NFCe_Configuracao>();
            nfce_movimento = new HashSet<NFCe_Movimento>();
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
            nfe_configuracao = new HashSet<NFe_Configuracao>();
            nfe_numero = new HashSet<NFe_Numero>();
            nfe_numero_inutilizado = new HashSet<NFe_NumeroInutilizado>();
            nota_fiscal_tipo = new HashSet<NotaFiscalTipo>();
            plano_centro_resultado = new HashSet<PlanoCentroResultado>();
            plano_natureza_financeira = new HashSet<PlanoNaturezaFinanceira>();
            pre_venda_cabecalho = new HashSet<PreVendaCabecalho>();
            quadro_societario = new HashSet<QuadroSocietario>();
            setors = new HashSet<Setor>();
            talonario_cheque = new HashSet<TalonarioCheque>();
            tribut_grupo_tributario = new HashSet<Tribut_GrupoTributario>();
            tribut_icms_custom_cab = new HashSet<Tribut_ICMSCustomizadoCabecalho>();
            tribut_operacao_fiscal = new HashSet<Tribut_OperacaoFiscal>();
            venda_cabecalho = new HashSet<VendaCabecalho>();
            venda_condicoes_pagamento = new HashSet<VendaCondicoesPagamento>();
            venda_orcamento_cabecalho = new HashSet<VendaOrcamentoCabecalho>();
        }

        public int id { get; set; }

        public int? id_empresa { get; set; }

        public int? id_sindicato_patronal { get; set; }

        public int? id_contador { get; set; }

        [StringLength(150)]
        public string razao_social { get; set; }

        [StringLength(150)]
        public string nome_fantasia { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(30)]
        public string inscricao_estadual { get; set; }

        [StringLength(30)]
        public string inscricao_estadual_st { get; set; }

        [StringLength(30)]
        public string inscricao_municipal { get; set; }

        [StringLength(30)]
        public string inscricao_junta_comercial { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_insc_junta_comercial { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inicio_atividades { get; set; }

        [StringLength(9)]
        public string suframa { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        public string imagem_logotipo { get; set; }

        [StringLength(1)]
        public string crt { get; set; }

        [StringLength(1)]
        public string tipo_regime { get; set; }

        public decimal? aliquota_pis { get; set; }

        [StringLength(50)]
        public string contato { get; set; }

        public decimal? aliquota_cofins { get; set; }

        public int? codigo_ibge_cidade { get; set; }

        public int? codigo_ibge_uf { get; set; }

        public int? codigo_terceiros { get; set; }

        public int? codigo_gps { get; set; }

        public decimal? aliquota_sat { get; set; }

        [StringLength(12)]
        public string cei { get; set; }

        [StringLength(7)]
        public string codigo_cnae_principal { get; set; }

        [StringLength(1)]
        public string tipo_controle_estoque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADM_Parametro> adm_parametro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almoxarifado> almoxarifadoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> cargoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissaoPerfil> comissao_perfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraTipoRequisicao> compra_tipo_requisicao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContaCaixa> conta_caixa { get; set; }

        public virtual Contador contador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Convenio> convenios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_Cabecalho> cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_Configuracao> cte_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_Cabecalho> dav_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaCNAE> empresa_cnae { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaContato> empresa_contato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaEndereco> empresa_endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> empresa1 { get; set; }

        public virtual Empresa empresa2 { get; set; }

        public virtual Sindicato sindicato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaPessoa> empresa_pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaProduto> empresa_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaTelefone> empresa_telefone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ConfiguracaoBoleto> fin_configuracao_boleto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_DocumentoOrigem> fin_documento_origem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_StatusParcela> fin_status_parcela { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_TipoPagamento> fin_tipo_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_TipoRecebimento> fin_tipo_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioContagemCabecalho> inventario_contagem_cab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Configuracao> nfce_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Movimento> nfce_movimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Configuracao> nfe_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Numero> nfe_numero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_NumeroInutilizado> nfe_numero_inutilizado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaFiscalTipo> nota_fiscal_tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoCentroResultado> plano_centro_resultado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanoNaturezaFinanceira> plano_natureza_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreVendaCabecalho> pre_venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuadroSocietario> quadro_societario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Setor> setors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TalonarioCheque> talonario_cheque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_GrupoTributario> tribut_grupo_tributario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_ICMSCustomizadoCabecalho> tribut_icms_custom_cab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_OperacaoFiscal> tribut_operacao_fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCondicoesPagamento> venda_condicoes_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaOrcamentoCabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
