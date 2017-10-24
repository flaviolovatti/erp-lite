namespace Servidor.Model
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
            adm_parametro = new HashSet<adm_parametro>();
            almoxarifadoes = new HashSet<Almoxarifado>();
            cargoes = new HashSet<Cargo>();
            comissao_perfil = new HashSet<comissao_perfil>();
            compra_tipo_requisicao = new HashSet<compra_tipo_requisicao>();
            conta_caixa = new HashSet<conta_caixa>();
            convenios = new HashSet<convenio>();
            cte_cabecalho = new HashSet<cte_cabecalho>();
            cte_configuracao = new HashSet<cte_configuracao>();
            dav_cabecalho = new HashSet<dav_cabecalho>();
            empresa_cnae = new HashSet<EmpresaCNAE>();
            empresa_contato = new HashSet<EmpresaContato>();
            empresa_endereco = new HashSet<EmpresaEndereco>();
            empresa1 = new HashSet<Empresa>();
            empresa_pessoa = new HashSet<EmpresaPessoa>();
            empresa_produto = new HashSet<EmpresaProduto>();
            empresa_telefone = new HashSet<empresa_telefone>();
            fin_configuracao_boleto = new HashSet<fin_configuracao_boleto>();
            fin_documento_origem = new HashSet<fin_documento_origem>();
            fin_status_parcela = new HashSet<fin_status_parcela>();
            fin_tipo_pagamento = new HashSet<fin_tipo_pagamento>();
            fin_tipo_recebimento = new HashSet<fin_tipo_recebimento>();
            inventario_contagem_cab = new HashSet<inventario_contagem_cab>();
            nfce_configuracao = new HashSet<nfce_configuracao>();
            nfce_movimento = new HashSet<nfce_movimento>();
            nfe_cabecalho = new HashSet<nfe_cabecalho>();
            nfe_configuracao = new HashSet<nfe_configuracao>();
            nfe_numero = new HashSet<nfe_numero>();
            nfe_numero_inutilizado = new HashSet<nfe_numero_inutilizado>();
            nota_fiscal_tipo = new HashSet<nota_fiscal_tipo>();
            plano_centro_resultado = new HashSet<plano_centro_resultado>();
            plano_natureza_financeira = new HashSet<plano_natureza_financeira>();
            pre_venda_cabecalho = new HashSet<pre_venda_cabecalho>();
            quadro_societario = new HashSet<quadro_societario>();
            setors = new HashSet<setor>();
            talonario_cheque = new HashSet<talonario_cheque>();
            tribut_grupo_tributario = new HashSet<Tribut_GrupoTributario>();
            tribut_icms_custom_cab = new HashSet<Tribut_ICMSCustomCabecalho>();
            tribut_operacao_fiscal = new HashSet<Tribut_OperacaoFiscal>();
            venda_cabecalho = new HashSet<venda_cabecalho>();
            venda_condicoes_pagamento = new HashSet<venda_condicoes_pagamento>();
            venda_orcamento_cabecalho = new HashSet<venda_orcamento_cabecalho>();
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
        public virtual ICollection<adm_parametro> adm_parametro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Almoxarifado> almoxarifadoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cargo> cargoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comissao_perfil> comissao_perfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_tipo_requisicao> compra_tipo_requisicao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<conta_caixa> conta_caixa { get; set; }

        public virtual Contador contador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<convenio> convenios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_cabecalho> cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_configuracao> cte_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dav_cabecalho> dav_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaCNAE> empresa_cnae { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaContato> empresa_contato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaEndereco> empresa_endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> empresa1 { get; set; }

        public virtual Empresa empresa2 { get; set; }

        public virtual sindicato sindicato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaPessoa> empresa_pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaProduto> empresa_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empresa_telefone> empresa_telefone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_configuracao_boleto> fin_configuracao_boleto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_documento_origem> fin_documento_origem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_status_parcela> fin_status_parcela { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_tipo_pagamento> fin_tipo_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_tipo_recebimento> fin_tipo_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventario_contagem_cab> inventario_contagem_cab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_configuracao> nfce_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_movimento> nfce_movimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_cabecalho> nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_configuracao> nfe_configuracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_numero> nfe_numero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_numero_inutilizado> nfe_numero_inutilizado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nota_fiscal_tipo> nota_fiscal_tipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plano_centro_resultado> plano_centro_resultado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plano_natureza_financeira> plano_natureza_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pre_venda_cabecalho> pre_venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<quadro_societario> quadro_societario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<setor> setors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<talonario_cheque> talonario_cheque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_GrupoTributario> tribut_grupo_tributario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_ICMSCustomCabecalho> tribut_icms_custom_cab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_OperacaoFiscal> tribut_operacao_fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_cabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_condicoes_pagamento> venda_condicoes_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_orcamento_cabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
