namespace Servidor.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextoERP : DbContext
    {
        public ContextoERP()
            : base("name=ContextoERP")
        {
        }

        public virtual DbSet<adm_modulo> adm_modulo { get; set; }
        public virtual DbSet<adm_parametro> adm_parametro { get; set; }
        public virtual DbSet<agencia_banco> agencia_banco { get; set; }
        public virtual DbSet<Almoxarifado> almoxarifadoes { get; set; }
        public virtual DbSet<AtividadeFornecedorCliente> atividade_for_cli { get; set; }
        public virtual DbSet<auditoria> auditorias { get; set; }
        public virtual DbSet<Banco> bancoes { get; set; }
        public virtual DbSet<Cargo> cargoes { get; set; }
        public virtual DbSet<centro_resultado> centro_resultado { get; set; }
        public virtual DbSet<CEP> ceps { get; set; }
        public virtual DbSet<cest> cests { get; set; }
        public virtual DbSet<cfop> cfops { get; set; }
        public virtual DbSet<cheque> cheques { get; set; }
        public virtual DbSet<Cliente> clientes { get; set; }
        public virtual DbSet<cnae> cnaes { get; set; }
        public virtual DbSet<Colaborador> colaboradors { get; set; }
        public virtual DbSet<colaborador_relacionamento> colaborador_relacionamento { get; set; }
        public virtual DbSet<comissao_objetivo> comissao_objetivo { get; set; }
        public virtual DbSet<comissao_perfil> comissao_perfil { get; set; }
        public virtual DbSet<compra_cotacao> compra_cotacao { get; set; }
        public virtual DbSet<compra_cotacao_detalhe> compra_cotacao_detalhe { get; set; }
        public virtual DbSet<compra_cotacao_pedido_detalhe> compra_cotacao_pedido_detalhe { get; set; }
        public virtual DbSet<compra_fornecedor_cotacao> compra_fornecedor_cotacao { get; set; }
        public virtual DbSet<compra_pedido> compra_pedido { get; set; }
        public virtual DbSet<compra_pedido_detalhe> compra_pedido_detalhe { get; set; }
        public virtual DbSet<compra_req_cotacao_detalhe> compra_req_cotacao_detalhe { get; set; }
        public virtual DbSet<compra_requisicao> compra_requisicao { get; set; }
        public virtual DbSet<compra_requisicao_detalhe> compra_requisicao_detalhe { get; set; }
        public virtual DbSet<compra_tipo_pedido> compra_tipo_pedido { get; set; }
        public virtual DbSet<compra_tipo_requisicao> compra_tipo_requisicao { get; set; }
        public virtual DbSet<conta_caixa> conta_caixa { get; set; }
        public virtual DbSet<contabil_conta> contabil_conta { get; set; }
        public virtual DbSet<Contador> contadors { get; set; }
        public virtual DbSet<contrib_sind_patronal_cab> contrib_sind_patronal_cab { get; set; }
        public virtual DbSet<contrib_sind_patronal_det> contrib_sind_patronal_det { get; set; }
        public virtual DbSet<convenio> convenios { get; set; }
        public virtual DbSet<csosn_a> csosn_a { get; set; }
        public virtual DbSet<csosn_b> csosn_b { get; set; }
        public virtual DbSet<cst_cofins> cst_cofins { get; set; }
        public virtual DbSet<cst_icms_a> cst_icms_a { get; set; }
        public virtual DbSet<cst_icms_b> cst_icms_b { get; set; }
        public virtual DbSet<cst_ipi> cst_ipi { get; set; }
        public virtual DbSet<cst_pis> cst_pis { get; set; }
        public virtual DbSet<ct_resultado_nt_financeira> ct_resultado_nt_financeira { get; set; }
        public virtual DbSet<cte_aereo> cte_aereo { get; set; }
        public virtual DbSet<cte_aquaviario> cte_aquaviario { get; set; }
        public virtual DbSet<cte_aquaviario_balsa> cte_aquaviario_balsa { get; set; }
        public virtual DbSet<cte_cabecalho> cte_cabecalho { get; set; }
        public virtual DbSet<cte_carga> cte_carga { get; set; }
        public virtual DbSet<cte_componente> cte_componente { get; set; }
        public virtual DbSet<cte_configuracao> cte_configuracao { get; set; }
        public virtual DbSet<cte_destinatario> cte_destinatario { get; set; }
        public virtual DbSet<cte_documento_anterior> cte_documento_anterior { get; set; }
        public virtual DbSet<cte_documento_anterior_id> cte_documento_anterior_id { get; set; }
        public virtual DbSet<cte_duplicata> cte_duplicata { get; set; }
        public virtual DbSet<cte_dutoviario> cte_dutoviario { get; set; }
        public virtual DbSet<cte_emitente> cte_emitente { get; set; }
        public virtual DbSet<cte_expedidor> cte_expedidor { get; set; }
        public virtual DbSet<cte_fatura> cte_fatura { get; set; }
        public virtual DbSet<cte_ferroviario> cte_ferroviario { get; set; }
        public virtual DbSet<cte_ferroviario_ferrovia> cte_ferroviario_ferrovia { get; set; }
        public virtual DbSet<cte_ferroviario_vagao> cte_ferroviario_vagao { get; set; }
        public virtual DbSet<cte_inf_nf_carga_lacre> cte_inf_nf_carga_lacre { get; set; }
        public virtual DbSet<cte_inf_nf_transporte_lacre> cte_inf_nf_transporte_lacre { get; set; }
        public virtual DbSet<cte_informacao_nf_carga> cte_informacao_nf_carga { get; set; }
        public virtual DbSet<cte_informacao_nf_outros> cte_informacao_nf_outros { get; set; }
        public virtual DbSet<cte_informacao_nf_transporte> cte_informacao_nf_transporte { get; set; }
        public virtual DbSet<cte_local_coleta> cte_local_coleta { get; set; }
        public virtual DbSet<cte_local_entrega> cte_local_entrega { get; set; }
        public virtual DbSet<cte_multimodal> cte_multimodal { get; set; }
        public virtual DbSet<cte_passagem> cte_passagem { get; set; }
        public virtual DbSet<cte_perigoso> cte_perigoso { get; set; }
        public virtual DbSet<cte_recebedor> cte_recebedor { get; set; }
        public virtual DbSet<cte_remetente> cte_remetente { get; set; }
        public virtual DbSet<cte_rodoviario> cte_rodoviario { get; set; }
        public virtual DbSet<cte_rodoviario_lacre> cte_rodoviario_lacre { get; set; }
        public virtual DbSet<cte_rodoviario_motorista> cte_rodoviario_motorista { get; set; }
        public virtual DbSet<cte_rodoviario_occ> cte_rodoviario_occ { get; set; }
        public virtual DbSet<cte_rodoviario_pedagio> cte_rodoviario_pedagio { get; set; }
        public virtual DbSet<cte_rodoviario_veiculo> cte_rodoviario_veiculo { get; set; }
        public virtual DbSet<cte_seguro> cte_seguro { get; set; }
        public virtual DbSet<cte_tomador> cte_tomador { get; set; }
        public virtual DbSet<cte_veiculo_novo> cte_veiculo_novo { get; set; }
        public virtual DbSet<dav_cabecalho> dav_cabecalho { get; set; }
        public virtual DbSet<dav_detalhe> dav_detalhe { get; set; }
        public virtual DbSet<dav_detalhe_alteracao> dav_detalhe_alteracao { get; set; }
        public virtual DbSet<ecf_aliquotas> ecf_aliquotas { get; set; }
        public virtual DbSet<ecf_caixa> ecf_caixa { get; set; }
        public virtual DbSet<ecf_configuracao> ecf_configuracao { get; set; }
        public virtual DbSet<ecf_documentos_emitidos> ecf_documentos_emitidos { get; set; }
        public virtual DbSet<ecf_e3> ecf_e3 { get; set; }
        public virtual DbSet<ecf_fechamento> ecf_fechamento { get; set; }
        public virtual DbSet<ecf_impressora> ecf_impressora { get; set; }
        public virtual DbSet<ecf_movimento> ecf_movimento { get; set; }
        public virtual DbSet<ecf_nota_fiscal_cabecalho> ecf_nota_fiscal_cabecalho { get; set; }
        public virtual DbSet<ecf_nota_fiscal_detalhe> ecf_nota_fiscal_detalhe { get; set; }
        public virtual DbSet<ecf_posicao_componentes> ecf_posicao_componentes { get; set; }
        public virtual DbSet<ecf_r02> ecf_r02 { get; set; }
        public virtual DbSet<ecf_r03> ecf_r03 { get; set; }
        public virtual DbSet<ecf_r06> ecf_r06 { get; set; }
        public virtual DbSet<ecf_r07> ecf_r07 { get; set; }
        public virtual DbSet<ecf_recebimento_nao_fiscal> ecf_recebimento_nao_fiscal { get; set; }
        public virtual DbSet<ecf_resolucao> ecf_resolucao { get; set; }
        public virtual DbSet<ecf_sangria> ecf_sangria { get; set; }
        public virtual DbSet<ecf_sintegra_60a> ecf_sintegra_60a { get; set; }
        public virtual DbSet<ecf_sintegra_60m> ecf_sintegra_60m { get; set; }
        public virtual DbSet<ecf_suprimento> ecf_suprimento { get; set; }
        public virtual DbSet<ecf_tipo_pagamento> ecf_tipo_pagamento { get; set; }
        public virtual DbSet<ecf_total_tipo_pagamento> ecf_total_tipo_pagamento { get; set; }
        public virtual DbSet<ecf_turno> ecf_turno { get; set; }
        public virtual DbSet<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
        public virtual DbSet<ecf_venda_detalhe> ecf_venda_detalhe { get; set; }
        public virtual DbSet<efd_tabela_4310> efd_tabela_4310 { get; set; }
        public virtual DbSet<efd_tabela_4313> efd_tabela_4313 { get; set; }
        public virtual DbSet<efd_tabela_4314> efd_tabela_4314 { get; set; }
        public virtual DbSet<efd_tabela_4315> efd_tabela_4315 { get; set; }
        public virtual DbSet<efd_tabela_4316> efd_tabela_4316 { get; set; }
        public virtual DbSet<efd_tabela_436> efd_tabela_436 { get; set; }
        public virtual DbSet<efd_tabela_437> efd_tabela_437 { get; set; }
        public virtual DbSet<efd_tabela_439> efd_tabela_439 { get; set; }
        public virtual DbSet<Empresa> empresas { get; set; }
        public virtual DbSet<EmpresaCNAE> empresa_cnae { get; set; }
        public virtual DbSet<EmpresaContato> empresa_contato { get; set; }
        public virtual DbSet<EmpresaEndereco> empresa_endereco { get; set; }
        public virtual DbSet<EmpresaPessoa> empresa_pessoa { get; set; }
        public virtual DbSet<EmpresaProduto> empresa_produto { get; set; }
        public virtual DbSet<empresa_telefone> empresa_telefone { get; set; }
        public virtual DbSet<EstadoCivil> estado_civil { get; set; }
        public virtual DbSet<estoque_cor> estoque_cor { get; set; }
        public virtual DbSet<estoque_grade> estoque_grade { get; set; }
        public virtual DbSet<estoque_marca> estoque_marca { get; set; }
        public virtual DbSet<estoque_reajuste_cabecalho> estoque_reajuste_cabecalho { get; set; }
        public virtual DbSet<estoque_reajuste_detalhe> estoque_reajuste_detalhe { get; set; }
        public virtual DbSet<estoque_sabor> estoque_sabor { get; set; }
        public virtual DbSet<estoque_tamanho> estoque_tamanho { get; set; }
        public virtual DbSet<feriado> feriados { get; set; }
        public virtual DbSet<ficha_tecnica> ficha_tecnica { get; set; }
        public virtual DbSet<fin_cheque_emitido> fin_cheque_emitido { get; set; }
        public virtual DbSet<fin_cheque_recebido> fin_cheque_recebido { get; set; }
        public virtual DbSet<fin_cliente_grupo_cab> fin_cliente_grupo_cab { get; set; }
        public virtual DbSet<fin_cliente_grupo_det> fin_cliente_grupo_det { get; set; }
        public virtual DbSet<fin_cobranca> fin_cobranca { get; set; }
        public virtual DbSet<fin_cobranca_parcela_receber> fin_cobranca_parcela_receber { get; set; }
        public virtual DbSet<fin_configuracao_boleto> fin_configuracao_boleto { get; set; }
        public virtual DbSet<fin_documento_origem> fin_documento_origem { get; set; }
        public virtual DbSet<fin_extrato_conta_banco> fin_extrato_conta_banco { get; set; }
        public virtual DbSet<fin_fechamento_caixa_banco> fin_fechamento_caixa_banco { get; set; }
        public virtual DbSet<fin_lancamento_pagar> fin_lancamento_pagar { get; set; }
        public virtual DbSet<fin_lancamento_receber> fin_lancamento_receber { get; set; }
        public virtual DbSet<fin_lcto_pagar_nt_financeira> fin_lcto_pagar_nt_financeira { get; set; }
        public virtual DbSet<fin_lcto_receber_nt_financeira> fin_lcto_receber_nt_financeira { get; set; }
        public virtual DbSet<fin_pagamento_fixo> fin_pagamento_fixo { get; set; }
        public virtual DbSet<fin_parcela_pagamento> fin_parcela_pagamento { get; set; }
        public virtual DbSet<fin_parcela_pagar> fin_parcela_pagar { get; set; }
        public virtual DbSet<fin_parcela_receber> fin_parcela_receber { get; set; }
        public virtual DbSet<fin_parcela_recebimento> fin_parcela_recebimento { get; set; }
        public virtual DbSet<fin_status_parcela> fin_status_parcela { get; set; }
        public virtual DbSet<fin_tipo_pagamento> fin_tipo_pagamento { get; set; }
        public virtual DbSet<fin_tipo_recebimento> fin_tipo_recebimento { get; set; }
        public virtual DbSet<fornecedor> fornecedors { get; set; }
        public virtual DbSet<fornecedor_produto> fornecedor_produto { get; set; }
        public virtual DbSet<funcao> funcaos { get; set; }
        public virtual DbSet<ibpt> ibpts { get; set; }
        public virtual DbSet<indice_economico> indice_economico { get; set; }
        public virtual DbSet<integracao_pdv> integracao_pdv { get; set; }
        public virtual DbSet<inventario_contagem_cab> inventario_contagem_cab { get; set; }
        public virtual DbSet<inventario_contagem_det> inventario_contagem_det { get; set; }
        public virtual DbSet<log_exportacao> log_exportacao { get; set; }
        public virtual DbSet<log_importacao> log_importacao { get; set; }
        public virtual DbSet<logss> logsses { get; set; }
        public virtual DbSet<municipio> municipios { get; set; }
        public virtual DbSet<natureza_financeira> natureza_financeira { get; set; }
        public virtual DbSet<ncm> ncms { get; set; }
        public virtual DbSet<nfce_caixa> nfce_caixa { get; set; }
        public virtual DbSet<nfce_configuracao> nfce_configuracao { get; set; }
        public virtual DbSet<nfce_configuracao_balanca> nfce_configuracao_balanca { get; set; }
        public virtual DbSet<nfce_configuracao_leitor_ser> nfce_configuracao_leitor_ser { get; set; }
        public virtual DbSet<nfce_fechamento> nfce_fechamento { get; set; }
        public virtual DbSet<nfce_movimento> nfce_movimento { get; set; }
        public virtual DbSet<nfce_operador> nfce_operador { get; set; }
        public virtual DbSet<nfce_posicao_componentes> nfce_posicao_componentes { get; set; }
        public virtual DbSet<nfce_resolucao> nfce_resolucao { get; set; }
        public virtual DbSet<nfce_sangria> nfce_sangria { get; set; }
        public virtual DbSet<nfce_suprimento> nfce_suprimento { get; set; }
        public virtual DbSet<nfce_tipo_pagamento> nfce_tipo_pagamento { get; set; }
        public virtual DbSet<nfce_turno> nfce_turno { get; set; }
        public virtual DbSet<nfe_acesso_xml> nfe_acesso_xml { get; set; }
        public virtual DbSet<nfe_cabecalho> nfe_cabecalho { get; set; }
        public virtual DbSet<nfe_cana> nfe_cana { get; set; }
        public virtual DbSet<nfe_cana_deducoes_safra> nfe_cana_deducoes_safra { get; set; }
        public virtual DbSet<nfe_cana_fornecimento_diario> nfe_cana_fornecimento_diario { get; set; }
        public virtual DbSet<nfe_configuracao> nfe_configuracao { get; set; }
        public virtual DbSet<nfe_cte_referenciado> nfe_cte_referenciado { get; set; }
        public virtual DbSet<nfe_cupom_fiscal_referenciado> nfe_cupom_fiscal_referenciado { get; set; }
        public virtual DbSet<nfe_declaracao_importacao> nfe_declaracao_importacao { get; set; }
        public virtual DbSet<nfe_destinatario> nfe_destinatario { get; set; }
        public virtual DbSet<nfe_det_especifico_armamento> nfe_det_especifico_armamento { get; set; }
        public virtual DbSet<nfe_det_especifico_combustivel> nfe_det_especifico_combustivel { get; set; }
        public virtual DbSet<nfe_det_especifico_medicamento> nfe_det_especifico_medicamento { get; set; }
        public virtual DbSet<nfe_det_especifico_veiculo> nfe_det_especifico_veiculo { get; set; }
        public virtual DbSet<nfe_detalhe> nfe_detalhe { get; set; }
        public virtual DbSet<nfe_detalhe_imposto_cofins> nfe_detalhe_imposto_cofins { get; set; }
        public virtual DbSet<nfe_detalhe_imposto_icms> nfe_detalhe_imposto_icms { get; set; }
        public virtual DbSet<nfe_detalhe_imposto_ii> nfe_detalhe_imposto_ii { get; set; }
        public virtual DbSet<nfe_detalhe_imposto_ipi> nfe_detalhe_imposto_ipi { get; set; }
        public virtual DbSet<nfe_detalhe_imposto_issqn> nfe_detalhe_imposto_issqn { get; set; }
        public virtual DbSet<nfe_detalhe_imposto_pis> nfe_detalhe_imposto_pis { get; set; }
        public virtual DbSet<nfe_detalhe_rastro> nfe_detalhe_rastro { get; set; }
        public virtual DbSet<nfe_duplicata> nfe_duplicata { get; set; }
        public virtual DbSet<nfe_emitente> nfe_emitente { get; set; }
        public virtual DbSet<nfe_exportacao> nfe_exportacao { get; set; }
        public virtual DbSet<nfe_fatura> nfe_fatura { get; set; }
        public virtual DbSet<nfe_forma_pagamento> nfe_forma_pagamento { get; set; }
        public virtual DbSet<nfe_importacao_detalhe> nfe_importacao_detalhe { get; set; }
        public virtual DbSet<nfe_local_entrega> nfe_local_entrega { get; set; }
        public virtual DbSet<nfe_local_retirada> nfe_local_retirada { get; set; }
        public virtual DbSet<nfe_nf_referenciada> nfe_nf_referenciada { get; set; }
        public virtual DbSet<nfe_numero> nfe_numero { get; set; }
        public virtual DbSet<nfe_numero_inutilizado> nfe_numero_inutilizado { get; set; }
        public virtual DbSet<nfe_processo_referenciado> nfe_processo_referenciado { get; set; }
        public virtual DbSet<nfe_prod_rural_referenciada> nfe_prod_rural_referenciada { get; set; }
        public virtual DbSet<nfe_referenciada> nfe_referenciada { get; set; }
        public virtual DbSet<nfe_transporte> nfe_transporte { get; set; }
        public virtual DbSet<nfe_transporte_reboque> nfe_transporte_reboque { get; set; }
        public virtual DbSet<nfe_transporte_volume> nfe_transporte_volume { get; set; }
        public virtual DbSet<nfe_transporte_volume_lacre> nfe_transporte_volume_lacre { get; set; }
        public virtual DbSet<nivel_formacao> nivel_formacao { get; set; }
        public virtual DbSet<nota_fiscal_modelo> nota_fiscal_modelo { get; set; }
        public virtual DbSet<nota_fiscal_tipo> nota_fiscal_tipo { get; set; }
        public virtual DbSet<operadora_cartao> operadora_cartao { get; set; }
        public virtual DbSet<OperadoraPlanoSaude> operadora_plano_saude { get; set; }
        public virtual DbSet<Pais> pais { get; set; }
        public virtual DbSet<papel> papels { get; set; }
        public virtual DbSet<papel_funcao> papel_funcao { get; set; }
        public virtual DbSet<Pessoa> pessoas { get; set; }
        public virtual DbSet<PessoaAlteracao> pessoa_alteracao { get; set; }
        public virtual DbSet<PessoaContato> pessoa_contato { get; set; }
        public virtual DbSet<PessoaEndereco> pessoa_endereco { get; set; }
        public virtual DbSet<PessoaFisica> pessoa_fisica { get; set; }
        public virtual DbSet<PessoaJuridica> pessoa_juridica { get; set; }
        public virtual DbSet<PessoaTelefone> pessoa_telefone { get; set; }
        public virtual DbSet<plano_centro_resultado> plano_centro_resultado { get; set; }
        public virtual DbSet<plano_natureza_financeira> plano_natureza_financeira { get; set; }
        public virtual DbSet<pre_venda_cabecalho> pre_venda_cabecalho { get; set; }
        public virtual DbSet<pre_venda_detalhe> pre_venda_detalhe { get; set; }
        public virtual DbSet<Produto> produtoes { get; set; }
        public virtual DbSet<ProdutoAlteracao_item> produto_alteracao_item { get; set; }
        public virtual DbSet<ProdutoCodigoAdicional> produto_codigo_adicional { get; set; }
        public virtual DbSet<ProdutoCombo> produto_combo { get; set; }
        public virtual DbSet<ProdutoComboItem> produto_combo_item { get; set; }
        public virtual DbSet<ProdutoGrupo> produto_grupo { get; set; }
        public virtual DbSet<ProdutoLacre> produto_lacre { get; set; }
        public virtual DbSet<ProdutoLacreEntrada> produto_lacre_entrada { get; set; }
        public virtual DbSet<ProdutoLote> produto_lote { get; set; }
        public virtual DbSet<ProdutoMarca> produto_marca { get; set; }
        public virtual DbSet<ProdutoPromocao> produto_promocao { get; set; }
        public virtual DbSet<ProdutoSubGrupo> produto_subgrupo { get; set; }
        public virtual DbSet<quadro_societario> quadro_societario { get; set; }
        public virtual DbSet<regiao> regiaos { get; set; }
        public virtual DbSet<requisicao_interna_cabecalho> requisicao_interna_cabecalho { get; set; }
        public virtual DbSet<requisicao_interna_detalhe> requisicao_interna_detalhe { get; set; }
        public virtual DbSet<setor> setors { get; set; }
        public virtual DbSet<sindicato> sindicatoes { get; set; }
        public virtual DbSet<situacao_colaborador> situacao_colaborador { get; set; }
        public virtual DbSet<situacao_documento> situacao_documento { get; set; }
        public virtual DbSet<situacao_for_cli> situacao_for_cli { get; set; }
        public virtual DbSet<socio> socios { get; set; }
        public virtual DbSet<socio_dependente> socio_dependente { get; set; }
        public virtual DbSet<socio_participacao_societaria> socio_participacao_societaria { get; set; }
        public virtual DbSet<tabela_preco> tabela_preco { get; set; }
        public virtual DbSet<tabela_preco_produto> tabela_preco_produto { get; set; }
        public virtual DbSet<talonario_cheque> talonario_cheque { get; set; }
        public virtual DbSet<tipo_admissao> tipo_admissao { get; set; }
        public virtual DbSet<tipo_colaborador> tipo_colaborador { get; set; }
        public virtual DbSet<tipo_item_sped> tipo_item_sped { get; set; }
        public virtual DbSet<tipo_receita_dipi> tipo_receita_dipi { get; set; }
        public virtual DbSet<tipo_relacionamento> tipo_relacionamento { get; set; }
        public virtual DbSet<transportadora> transportadoras { get; set; }
        public virtual DbSet<transportadora_municipio> transportadora_municipio { get; set; }
        public virtual DbSet<Tribut_CofinsCodigoApuracao> tribut_cofins_cod_apuracao { get; set; }
        public virtual DbSet<Tribut_ConfiguraOperacaoFiscalGrupoTributario> tribut_configura_of_gt { get; set; }
        public virtual DbSet<Tribut_GrupoTributario> tribut_grupo_tributario { get; set; }
        public virtual DbSet<Tribut_ICMSCustomCabecalho> tribut_icms_custom_cab { get; set; }
        public virtual DbSet<Tribut_ICMSCustomDetalhe> tribut_icms_custom_det { get; set; }
        public virtual DbSet<Tribut_ICMS_UF> tribut_icms_uf { get; set; }
        public virtual DbSet<tribut_ipi_dipi> tribut_ipi_dipi { get; set; }
        public virtual DbSet<Tribut_ISS> tribut_iss { get; set; }
        public virtual DbSet<Tribut_OperacaoFiscal> tribut_operacao_fiscal { get; set; }
        public virtual DbSet<Tribut_PIS_CodigoApuracao> tribut_pis_cod_apuracao { get; set; }
        public virtual DbSet<UF> ufs { get; set; }
        public virtual DbSet<unidade_conversao> unidade_conversao { get; set; }
        public virtual DbSet<UnidadeProduto> unidade_produto { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<venda_cabecalho> venda_cabecalho { get; set; }
        public virtual DbSet<venda_comissao> venda_comissao { get; set; }
        public virtual DbSet<venda_condicoes_pagamento> venda_condicoes_pagamento { get; set; }
        public virtual DbSet<venda_condicoes_parcelas> venda_condicoes_parcelas { get; set; }
        public virtual DbSet<venda_detalhe> venda_detalhe { get; set; }
        public virtual DbSet<venda_frete> venda_frete { get; set; }
        public virtual DbSet<venda_orcamento_cabecalho> venda_orcamento_cabecalho { get; set; }
        public virtual DbSet<venda_orcamento_detalhe> venda_orcamento_detalhe { get; set; }
        public virtual DbSet<venda_romaneio_entrega> venda_romaneio_entrega { get; set; }
        public virtual DbSet<vendedor> vendedors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<adm_modulo>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<adm_modulo>()
                .Property(e => e.ativo)
                .IsFixedLength();

            modelBuilder.Entity<agencia_banco>()
                .Property(e => e.digito)
                .IsFixedLength();

            modelBuilder.Entity<agencia_banco>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<agencia_banco>()
                .HasMany(e => e.conta_caixa)
                .WithOptional(e => e.agencia_banco)
                .HasForeignKey(e => e.id_agencia_banco);

            modelBuilder.Entity<Almoxarifado>()
                .HasMany(e => e.produtoes)
                .WithOptional(e => e.almoxarifado)
                .HasForeignKey(e => e.id_almoxarifado);

            modelBuilder.Entity<AtividadeFornecedorCliente>()
                .HasMany(e => e.clientes)
                .WithRequired(e => e.atividade_for_cli)
                .HasForeignKey(e => e.id_atividade_for_cli)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AtividadeFornecedorCliente>()
                .HasMany(e => e.fornecedors)
                .WithRequired(e => e.atividade_for_cli)
                .HasForeignKey(e => e.id_atividade_for_cli)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.agencia_banco)
                .WithRequired(e => e.banco)
                .HasForeignKey(e => e.id_banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cargo>()
                .Property(e => e.salario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Cargo>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.cargo)
                .HasForeignKey(e => e.id_cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<centro_resultado>()
                .Property(e => e.sofre_rateiro)
                .IsFixedLength();

            modelBuilder.Entity<centro_resultado>()
                .HasMany(e => e.ct_resultado_nt_financeira)
                .WithRequired(e => e.centro_resultado)
                .HasForeignKey(e => e.id_centro_resultado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cest>()
                .Property(e => e.sigla_unidade)
                .IsFixedLength();

            modelBuilder.Entity<cheque>()
                .Property(e => e.status_cheque)
                .IsFixedLength();

            modelBuilder.Entity<cheque>()
                .HasMany(e => e.fin_cheque_emitido)
                .WithRequired(e => e.cheque)
                .HasForeignKey(e => e.id_cheque)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.gera_financeiro)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.indicador_preco)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.porcento_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.forma_desconto)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.limite_credito)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .Property(e => e.bloqueado)
                .IsFixedLength();

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.fin_cliente_grupo_det)
                .WithRequired(e => e.cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.fin_cobranca)
                .WithRequired(e => e.cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.fin_lancamento_receber)
                .WithRequired(e => e.cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.cliente)
                .HasForeignKey(e => e.id_cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithRequired(e => e.cliente)
                .HasForeignKey(e => e.id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cnae>()
                .HasMany(e => e.empresa_cnae)
                .WithRequired(e => e.cnae)
                .HasForeignKey(e => e.id_cnae)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.fgts_optante)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.pagamento_forma)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.pagamento_agencia_digito)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.pagamento_conta_digito)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.pis_agencia_digito)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.ctps_uf)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.desconto_plano_saude)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.sai_na_rais)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.categoria_sefip)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.codigo_turma_ponto)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.caged_aprendiz)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .Property(e => e.caged_deficiencia)
                .IsFixedLength();

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.colaborador_relacionamento)
                .WithRequired(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.compra_requisicao)
                .WithRequired(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.estoque_reajuste_cabecalho)
                .WithRequired(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.requisicao_interna_cabecalho)
                .WithRequired(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.venda_romaneio_entrega)
                .WithRequired(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colaborador>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.colaborador)
                .HasForeignKey(e => e.id_colaborador);

            modelBuilder.Entity<colaborador_relacionamento>()
                .Property(e => e.salario_familia)
                .IsFixedLength();

            modelBuilder.Entity<comissao_objetivo>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<comissao_objetivo>()
                .Property(e => e.forma_pagamento)
                .IsFixedLength();

            modelBuilder.Entity<comissao_objetivo>()
                .Property(e => e.taxa_pagamento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<comissao_objetivo>()
                .Property(e => e.valor_pagamento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<comissao_objetivo>()
                .Property(e => e.valor_meta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<comissao_objetivo>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<comissao_perfil>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<comissao_perfil>()
                .HasMany(e => e.comissao_objetivo)
                .WithRequired(e => e.comissao_perfil)
                .HasForeignKey(e => e.id_comissao_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comissao_perfil>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.comissao_perfil)
                .HasForeignKey(e => e.id_comissao_perfil);

            modelBuilder.Entity<compra_cotacao>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<compra_cotacao>()
                .HasMany(e => e.compra_fornecedor_cotacao)
                .WithRequired(e => e.compra_cotacao)
                .HasForeignKey(e => e.id_compra_cotacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_cotacao>()
                .HasMany(e => e.compra_req_cotacao_detalhe)
                .WithRequired(e => e.compra_cotacao)
                .HasForeignKey(e => e.id_compra_cotacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.quantidade_pedida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_cotacao_detalhe>()
                .HasMany(e => e.compra_cotacao_pedido_detalhe)
                .WithRequired(e => e.compra_cotacao_detalhe)
                .HasForeignKey(e => e.id_compra_cotacao_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_cotacao_pedido_detalhe>()
                .Property(e => e.quantidade_pedida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_fornecedor_cotacao>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_fornecedor_cotacao>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_fornecedor_cotacao>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_fornecedor_cotacao>()
                .Property(e => e.total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_fornecedor_cotacao>()
                .HasMany(e => e.compra_cotacao_detalhe)
                .WithRequired(e => e.compra_fornecedor_cotacao)
                .HasForeignKey(e => e.id_compra_fornecedor_cotacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_total_pedido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.forma_pagamento)
                .IsFixedLength();

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_outras_despesas)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .Property(e => e.valor_total_nf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido>()
                .HasMany(e => e.compra_cotacao_pedido_detalhe)
                .WithRequired(e => e.compra_pedido)
                .HasForeignKey(e => e.id_compra_pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_pedido>()
                .HasMany(e => e.compra_pedido_detalhe)
                .WithRequired(e => e.compra_pedido)
                .HasForeignKey(e => e.id_compra_pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.cst_csosn)
                .IsFixedLength();

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.aliquota_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_pedido_detalhe>()
                .Property(e => e.aliquota_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_req_cotacao_detalhe>()
                .Property(e => e.quantidade_cotada)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_requisicao>()
                .HasMany(e => e.compra_requisicao_detalhe)
                .WithRequired(e => e.compra_requisicao)
                .HasForeignKey(e => e.id_compra_requisicao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_requisicao_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_requisicao_detalhe>()
                .Property(e => e.quantidade_cotada)
                .HasPrecision(18, 6);

            modelBuilder.Entity<compra_requisicao_detalhe>()
                .Property(e => e.item_cotado)
                .IsFixedLength();

            modelBuilder.Entity<compra_requisicao_detalhe>()
                .HasMany(e => e.compra_req_cotacao_detalhe)
                .WithRequired(e => e.compra_requisicao_detalhe)
                .HasForeignKey(e => e.id_compra_requisicao_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_tipo_pedido>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<compra_tipo_pedido>()
                .HasMany(e => e.compra_pedido)
                .WithRequired(e => e.compra_tipo_pedido)
                .HasForeignKey(e => e.id_compra_tipo_pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<compra_tipo_requisicao>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<compra_tipo_requisicao>()
                .HasMany(e => e.compra_requisicao)
                .WithRequired(e => e.compra_tipo_requisicao)
                .HasForeignKey(e => e.id_compra_tipo_requisicao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .Property(e => e.digito)
                .IsFixedLength();

            modelBuilder.Entity<conta_caixa>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<conta_caixa>()
                .Property(e => e.limite_credito)
                .HasPrecision(18, 6);

            modelBuilder.Entity<conta_caixa>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<conta_caixa>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<conta_caixa>()
                .Property(e => e.desconto_maximo_permitido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_cheque_recebido)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_configuracao_boleto)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_extrato_conta_banco)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_fechamento_caixa_banco)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_parcela_pagar)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_parcela_receber)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.fin_tipo_recebimento)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.operadora_cartao)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<conta_caixa>()
                .HasMany(e => e.talonario_cheque)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.natureza)
                .IsFixedLength();

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.patrimonio_resultado)
                .IsFixedLength();

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.livro_caixa)
                .IsFixedLength();

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.dfc)
                .IsFixedLength();

            modelBuilder.Entity<contabil_conta>()
                .Property(e => e.codigo_efd)
                .IsFixedLength();

            modelBuilder.Entity<Contador>()
                .Property(e => e.uf_crc)
                .IsFixedLength();

            modelBuilder.Entity<Contador>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<Contador>()
                .HasMany(e => e.empresas)
                .WithOptional(e => e.contador)
                .HasForeignKey(e => e.id_contador);

            modelBuilder.Entity<contrib_sind_patronal_cab>()
                .Property(e => e.vigencia_ano)
                .IsFixedLength();

            modelBuilder.Entity<contrib_sind_patronal_cab>()
                .HasMany(e => e.contrib_sind_patronal_det)
                .WithRequired(e => e.contrib_sind_patronal_cab)
                .HasForeignKey(e => e.id_contrib_sind_patronal_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<contrib_sind_patronal_det>()
                .Property(e => e.de)
                .HasPrecision(18, 6);

            modelBuilder.Entity<contrib_sind_patronal_det>()
                .Property(e => e.ate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<contrib_sind_patronal_det>()
                .Property(e => e.percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<contrib_sind_patronal_det>()
                .Property(e => e.valor_adicionar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<convenio>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<convenio>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<convenio>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.convenio)
                .HasForeignKey(e => e.id_convenio);

            modelBuilder.Entity<csosn_a>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<csosn_b>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<cst_cofins>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<cst_icms_a>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<cst_icms_b>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<cst_ipi>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<cst_pis>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<ct_resultado_nt_financeira>()
                .Property(e => e.percentual_rateio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_aereo>()
                .Property(e => e.tarifa_classe)
                .IsFixedLength();

            modelBuilder.Entity<cte_aereo>()
                .Property(e => e.tarifa_valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_aereo>()
                .Property(e => e.carga_especial)
                .IsFixedLength();

            modelBuilder.Entity<cte_aquaviario>()
                .Property(e => e.valor_prestacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_aquaviario>()
                .Property(e => e.afrmm)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_aquaviario>()
                .HasMany(e => e.cte_aquaviario_balsa)
                .WithRequired(e => e.cte_aquaviario)
                .HasForeignKey(e => e.id_cte_aquaviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_aquaviario_balsa>()
                .Property(e => e.direcao)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.digito_chave_acesso)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.uf_envio)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.modal)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.uf_ini_prestacao)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.uf_fim_prestacao)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_total_servico)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_receber)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.cst)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.aliquota_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.percentual_reducao_bc_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_bc_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.aliquota_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_credito_presumido_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.percentual_bc_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_bc_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.aliquota_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.simples_nacional_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_total_carga)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_bc_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.percentual_fcp_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.aliquota_icms_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.aliquota_interestadual_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.percentual_partilha_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_icms_fcp_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_icms_partilha_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_icms_partilha_uf_ini)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.valor_carga_averbacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_cabecalho>()
                .Property(e => e.codigo_status_resposta)
                .IsFixedLength();

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_aereo)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_aquaviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_carga)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_componente)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_destinatario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_documento_anterior)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_duplicata)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_dutoviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_emitente)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_expedidor)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_fatura)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_ferroviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_informacao_nf_outros)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_local_coleta)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_local_entrega)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_multimodal)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_passagem)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_perigoso)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_recebedor)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_remetente)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_rodoviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_seguro)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_tomador)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_cabecalho>()
                .HasMany(e => e.cte_veiculo_novo)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_carga>()
                .Property(e => e.codigo_unidade_medida)
                .IsFixedLength();

            modelBuilder.Entity<cte_carga>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_componente>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_configuracao>()
                .Property(e => e.salvar_xml)
                .IsFixedLength();

            modelBuilder.Entity<cte_configuracao>()
                .Property(e => e.webservice_uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_configuracao>()
                .Property(e => e.webservice_visualizar)
                .IsFixedLength();

            modelBuilder.Entity<cte_configuracao>()
                .Property(e => e.email_autentica_ssl)
                .IsFixedLength();

            modelBuilder.Entity<cte_destinatario>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_documento_anterior>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_documento_anterior>()
                .HasMany(e => e.cte_documento_anterior_id)
                .WithRequired(e => e.cte_documento_anterior)
                .HasForeignKey(e => e.id_cte_documento_anterior)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_documento_anterior_id>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<cte_documento_anterior_id>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<cte_documento_anterior_id>()
                .Property(e => e.subserie)
                .IsFixedLength();

            modelBuilder.Entity<cte_duplicata>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_dutoviario>()
                .Property(e => e.valor_tarifa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_emitente>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_expedidor>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_fatura>()
                .Property(e => e.valor_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_fatura>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_fatura>()
                .Property(e => e.valor_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_ferroviario>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_ferroviario>()
                .HasMany(e => e.cte_ferroviario_ferrovia)
                .WithRequired(e => e.cte_ferroviario)
                .HasForeignKey(e => e.id_cte_ferroviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_ferroviario>()
                .HasMany(e => e.cte_ferroviario_vagao)
                .WithRequired(e => e.cte_ferroviario)
                .HasForeignKey(e => e.id_cte_ferroviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_ferroviario_ferrovia>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_ferroviario_vagao>()
                .Property(e => e.capacidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_ferroviario_vagao>()
                .Property(e => e.tipo_vagao)
                .IsFixedLength();

            modelBuilder.Entity<cte_ferroviario_vagao>()
                .Property(e => e.peso_real)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_ferroviario_vagao>()
                .Property(e => e.peso_bc)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_inf_nf_carga_lacre>()
                .Property(e => e.quantidade_rateada)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_carga>()
                .HasMany(e => e.cte_inf_nf_carga_lacre)
                .WithRequired(e => e.cte_informacao_nf_carga)
                .HasForeignKey(e => e.id_cte_informacao_nf_carga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.codigo_modelo)
                .IsFixedLength();

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.valor_total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.peso_total_kg)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.outro_tipo_doc_orig)
                .IsFixedLength();

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .Property(e => e.outro_valor_documento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .HasMany(e => e.cte_informacao_nf_carga)
                .WithRequired(e => e.cte_informacao_nf_outros)
                .HasForeignKey(e => e.id_cte_informacao_nf)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_informacao_nf_outros>()
                .HasMany(e => e.cte_informacao_nf_transporte)
                .WithRequired(e => e.cte_informacao_nf_outros)
                .HasForeignKey(e => e.id_cte_informacao_nf)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_informacao_nf_transporte>()
                .HasMany(e => e.cte_inf_nf_transporte_lacre)
                .WithRequired(e => e.cte_informacao_nf_transporte)
                .HasForeignKey(e => e.id_cte_informacao_nf_transp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_local_coleta>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_local_entrega>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_recebedor>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_remetente>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario>()
                .HasMany(e => e.cte_rodoviario_lacre)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_rodoviario>()
                .HasMany(e => e.cte_rodoviario_motorista)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_rodoviario>()
                .HasMany(e => e.cte_rodoviario_occ)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_rodoviario>()
                .HasMany(e => e.cte_rodoviario_pedagio)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_rodoviario>()
                .HasMany(e => e.cte_rodoviario_veiculo)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cte_rodoviario_occ>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario_occ>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario_pedagio>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_rodoviario_veiculo>()
                .Property(e => e.tipo_propriedade)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario_veiculo>()
                .Property(e => e.tipo_rodado)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario_veiculo>()
                .Property(e => e.tipo_carroceria)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario_veiculo>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_rodoviario_veiculo>()
                .Property(e => e.proprietario_uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_seguro>()
                .Property(e => e.valor_carga)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_tomador>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<cte_veiculo_novo>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<cte_veiculo_novo>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_cabecalho>()
                .Property(e => e.impresso)
                .IsFixedLength();

            modelBuilder.Entity<dav_cabecalho>()
                .HasMany(e => e.dav_detalhe)
                .WithRequired(e => e.dav_cabecalho)
                .HasForeignKey(e => e.id_dav_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dav_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<dav_detalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<dav_detalhe>()
                .Property(e => e.mescla_produto)
                .IsFixedLength();

            modelBuilder.Entity<dav_detalhe>()
                .HasMany(e => e.dav_detalhe_alteracao)
                .WithRequired(e => e.dav_detalhe)
                .HasForeignKey(e => e.id_dav_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dav_detalhe_alteracao>()
                .Property(e => e.tipo_alteracao)
                .IsFixedLength();

            modelBuilder.Entity<ecf_aliquotas>()
                .Property(e => e.paf_p_st)
                .IsFixedLength();

            modelBuilder.Entity<ecf_configuracao>()
                .Property(e => e.porta_ecf)
                .IsFixedLength();

            modelBuilder.Entity<ecf_configuracao>()
                .Property(e => e.tipo_tef)
                .IsFixedLength();

            modelBuilder.Entity<ecf_configuracao>()
                .Property(e => e.marketing_ativo)
                .IsFixedLength();

            modelBuilder.Entity<ecf_configuracao>()
                .Property(e => e.pesquisa_parte)
                .IsFixedLength();

            modelBuilder.Entity<ecf_documentos_emitidos>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<ecf_e3>()
                .Property(e => e.mf_adicional)
                .IsFixedLength();

            modelBuilder.Entity<ecf_fechamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.mc)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.md)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.vr)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.modelo_documento_fiscal)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.le)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.lef)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.mfd)
                .IsFixedLength();

            modelBuilder.Entity<ecf_impressora>()
                .Property(e => e.lacre_na_mfd)
                .IsFixedLength();

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_suprimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_sangria)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_nao_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.total_cancelado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_movimento>()
                .Property(e => e.status_movimento)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.subserie)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.total_nf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.icms_outras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.acrescimo_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.desconto_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.cancelada)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_cabecalho>()
                .Property(e => e.tipo_nota)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.icms_outras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.icms_isento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.taxa_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.cst)
                .IsFixedLength();

            modelBuilder.Entity<ecf_nota_fiscal_detalhe>()
                .Property(e => e.movimenta_estoque)
                .IsFixedLength();

            modelBuilder.Entity<ecf_r02>()
                .Property(e => e.venda_bruta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_r02>()
                .Property(e => e.grande_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_r03>()
                .Property(e => e.valor_acumulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_r06>()
                .Property(e => e.denominacao)
                .IsFixedLength();

            modelBuilder.Entity<ecf_r07>()
                .Property(e => e.valor_pagamento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_r07>()
                .Property(e => e.estorno)
                .IsFixedLength();

            modelBuilder.Entity<ecf_r07>()
                .Property(e => e.valor_estorno)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_recebimento_nao_fiscal>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_sangria>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_sintegra_60a>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_sintegra_60m>()
                .Property(e => e.modelo_documento_fiscal)
                .IsFixedLength();

            modelBuilder.Entity<ecf_sintegra_60m>()
                .Property(e => e.valor_venda_bruta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_sintegra_60m>()
                .Property(e => e.valor_grande_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_suprimento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_tipo_pagamento>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<ecf_tipo_pagamento>()
                .Property(e => e.tef)
                .IsFixedLength();

            modelBuilder.Entity<ecf_tipo_pagamento>()
                .Property(e => e.imprime_vinculado)
                .IsFixedLength();

            modelBuilder.Entity<ecf_tipo_pagamento>()
                .Property(e => e.permite_troco)
                .IsFixedLength();

            modelBuilder.Entity<ecf_tipo_pagamento>()
                .Property(e => e.tef_tipo_gp)
                .IsFixedLength();

            modelBuilder.Entity<ecf_tipo_pagamento>()
                .Property(e => e.gera_parcelas)
                .IsFixedLength();

            modelBuilder.Entity<ecf_total_tipo_pagamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_total_tipo_pagamento>()
                .Property(e => e.estorno)
                .IsFixedLength();

            modelBuilder.Entity<ecf_total_tipo_pagamento>()
                .Property(e => e.cartao_dc)
                .IsFixedLength();

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.valor_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.valor_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.valor_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.valor_cancelado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.total_documento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.icms_outras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.acrescimo_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.desconto_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.status_venda)
                .IsFixedLength();

            modelBuilder.Entity<ecf_venda_cabecalho>()
                .Property(e => e.cupom_cancelado)
                .IsFixedLength();

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.total_item)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.taxa_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.taxa_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.taxa_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.taxa_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.acrescimo_rateio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.desconto_rateio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.cst)
                .IsFixedLength();

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<ecf_venda_detalhe>()
                .Property(e => e.movimenta_estoque)
                .IsFixedLength();

            modelBuilder.Entity<efd_tabela_437>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<Empresa>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<Empresa>()
                .Property(e => e.crt)
                .IsFixedLength();

            modelBuilder.Entity<Empresa>()
                .Property(e => e.tipo_regime)
                .IsFixedLength();

            modelBuilder.Entity<Empresa>()
                .Property(e => e.aliquota_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.aliquota_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.aliquota_sat)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.tipo_controle_estoque)
                .IsFixedLength();

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.adm_parametro)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.almoxarifadoes)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.cargoes)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.comissao_perfil)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.compra_tipo_requisicao)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.conta_caixa)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.convenios)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.cte_cabecalho)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.cte_configuracao)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.dav_cabecalho)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa_cnae)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa_contato)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa_endereco)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa1)
                .WithOptional(e => e.empresa2)
                .HasForeignKey(e => e.id_empresa);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa_pessoa)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa_produto)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.empresa_telefone)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.fin_configuracao_boleto)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.fin_documento_origem)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.fin_status_parcela)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.fin_tipo_pagamento)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.fin_tipo_recebimento)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.inventario_contagem_cab)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nfce_configuracao)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.empresa)
                .HasForeignKey(e => e.id_empresa);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nfe_configuracao)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nfe_numero)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nfe_numero_inutilizado)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.nota_fiscal_tipo)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.plano_centro_resultado)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.plano_natureza_financeira)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.pre_venda_cabecalho)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.quadro_societario)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.setors)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.talonario_cheque)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.tribut_grupo_tributario)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.tribut_icms_custom_cab)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.tribut_operacao_fiscal)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.venda_condicoes_pagamento)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithRequired(e => e.empresa)
                .HasForeignKey(e => e.id_empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaCNAE>()
                .Property(e => e.principal)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaEndereco>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaEndereco>()
                .Property(e => e.principal)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaEndereco>()
                .Property(e => e.entrega)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaEndereco>()
                .Property(e => e.cobranca)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaEndereco>()
                .Property(e => e.correspondencia)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaPessoa>()
                .Property(e => e.responsavel_legal)
                .IsFixedLength();

            modelBuilder.Entity<EmpresaProduto>()
                .Property(e => e.quantidade_estoque)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EmpresaProduto>()
                .HasMany(e => e.estoque_grade)
                .WithOptional(e => e.empresa_produto)
                .HasForeignKey(e => e.id_empresa_produto);

            modelBuilder.Entity<EstadoCivil>()
                .HasMany(e => e.pessoa_fisica)
                .WithRequired(e => e.estado_civil)
                .HasForeignKey(e => e.id_estado_civil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estoque_cor>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<estoque_cor>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_cor)
                .HasForeignKey(e => e.id_estoque_cor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estoque_grade>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_marca>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<estoque_marca>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_marca)
                .HasForeignKey(e => e.id_estoque_marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estoque_reajuste_cabecalho>()
                .Property(e => e.porcentagem)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_reajuste_cabecalho>()
                .Property(e => e.tipo_reajuste)
                .IsFixedLength();

            modelBuilder.Entity<estoque_reajuste_cabecalho>()
                .Property(e => e.quantidade_fixa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_reajuste_cabecalho>()
                .Property(e => e.campo_reajuste)
                .IsFixedLength();

            modelBuilder.Entity<estoque_reajuste_cabecalho>()
                .HasMany(e => e.estoque_reajuste_detalhe)
                .WithRequired(e => e.estoque_reajuste_cabecalho)
                .HasForeignKey(e => e.id_estoque_reajuste_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estoque_reajuste_detalhe>()
                .Property(e => e.valor_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_reajuste_detalhe>()
                .Property(e => e.valor_reajuste)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_reajuste_detalhe>()
                .Property(e => e.quantidade_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_reajuste_detalhe>()
                .Property(e => e.quantidade_reajuste)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_sabor>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<estoque_sabor>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_sabor)
                .HasForeignKey(e => e.id_estoque_sabor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<estoque_tamanho>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<estoque_tamanho>()
                .Property(e => e.altura)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_tamanho>()
                .Property(e => e.comprimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_tamanho>()
                .Property(e => e.largura)
                .HasPrecision(18, 6);

            modelBuilder.Entity<estoque_tamanho>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_tamanho)
                .HasForeignKey(e => e.id_estoque_tamanho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<feriado>()
                .Property(e => e.ano)
                .IsFixedLength();

            modelBuilder.Entity<feriado>()
                .Property(e => e.abrangencia)
                .IsFixedLength();

            modelBuilder.Entity<feriado>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<feriado>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<ficha_tecnica>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_emitido>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_emitido>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithOptional(e => e.fin_cheque_emitido)
                .HasForeignKey(e => e.id_fin_cheque_emitido);

            modelBuilder.Entity<fin_cheque_recebido>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_recebido>()
                .Property(e => e.custodia_tarifa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_recebido>()
                .Property(e => e.custodia_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_recebido>()
                .Property(e => e.desconto_tarifa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_recebido>()
                .Property(e => e.desconto_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_recebido>()
                .Property(e => e.valor_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cheque_recebido>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithOptional(e => e.fin_cheque_recebido)
                .HasForeignKey(e => e.id_fin_cheque_recebido);

            modelBuilder.Entity<fin_cliente_grupo_cab>()
                .HasMany(e => e.fin_cliente_grupo_det)
                .WithRequired(e => e.fin_cliente_grupo_cab)
                .HasForeignKey(e => e.id_fin_cliente_grupo_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_cliente_grupo_det>()
                .Property(e => e.dia_lancamento)
                .IsFixedLength();

            modelBuilder.Entity<fin_cliente_grupo_det>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cliente_grupo_det>()
                .Property(e => e.gera_boleto)
                .IsFixedLength();

            modelBuilder.Entity<fin_cobranca>()
                .Property(e => e.total_receber_na_data)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca>()
                .HasMany(e => e.fin_cobranca_parcela_receber)
                .WithRequired(e => e.fin_cobranca)
                .HasForeignKey(e => e.id_fin_cobranca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_parcela)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_juro_simulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_multa_simulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_receber_simulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_juro_acordo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_multa_acordo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_cobranca_parcela_receber>()
                .Property(e => e.valor_receber_acordo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_configuracao_boleto>()
                .Property(e => e.layout_remessa)
                .IsFixedLength();

            modelBuilder.Entity<fin_configuracao_boleto>()
                .Property(e => e.aceite)
                .IsFixedLength();

            modelBuilder.Entity<fin_configuracao_boleto>()
                .Property(e => e.especie)
                .IsFixedLength();

            modelBuilder.Entity<fin_configuracao_boleto>()
                .Property(e => e.carteira)
                .IsFixedLength();

            modelBuilder.Entity<fin_configuracao_boleto>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_configuracao_boleto>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_documento_origem>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<fin_documento_origem>()
                .Property(e => e.sigla_documento)
                .IsFixedLength();

            modelBuilder.Entity<fin_documento_origem>()
                .HasMany(e => e.fin_lancamento_pagar)
                .WithRequired(e => e.fin_documento_origem)
                .HasForeignKey(e => e.id_fin_documento_origem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_documento_origem>()
                .HasMany(e => e.fin_lancamento_receber)
                .WithRequired(e => e.fin_documento_origem)
                .HasForeignKey(e => e.id_fin_documento_origem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_documento_origem>()
                .HasMany(e => e.fin_pagamento_fixo)
                .WithRequired(e => e.fin_documento_origem)
                .HasForeignKey(e => e.id_fin_documento_origem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_extrato_conta_banco>()
                .Property(e => e.mes)
                .IsFixedLength();

            modelBuilder.Entity<fin_extrato_conta_banco>()
                .Property(e => e.ano)
                .IsFixedLength();

            modelBuilder.Entity<fin_extrato_conta_banco>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_extrato_conta_banco>()
                .Property(e => e.conciliado)
                .IsFixedLength();

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.mes)
                .IsFixedLength();

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.ano)
                .IsFixedLength();

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.saldo_anterior)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.recebimentos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.pagamentos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.saldo_conta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.cheque_nao_compensado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_fechamento_caixa_banco>()
                .Property(e => e.saldo_disponivel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_pagar>()
                .Property(e => e.pagamento_compartilhado)
                .IsFixedLength();

            modelBuilder.Entity<fin_lancamento_pagar>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_pagar>()
                .Property(e => e.valor_a_pagar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_pagar>()
                .Property(e => e.codigo_modulo_lcto)
                .IsFixedLength();

            modelBuilder.Entity<fin_lancamento_pagar>()
                .HasMany(e => e.fin_lcto_pagar_nt_financeira)
                .WithRequired(e => e.fin_lancamento_pagar)
                .HasForeignKey(e => e.id_fin_lancamento_pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_lancamento_pagar>()
                .HasMany(e => e.fin_parcela_pagar)
                .WithRequired(e => e.fin_lancamento_pagar)
                .HasForeignKey(e => e.id_fin_lancamento_pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_lancamento_receber>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_receber>()
                .Property(e => e.valor_desconto_convenio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_receber>()
                .Property(e => e.valor_a_receber)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_receber>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_receber>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lancamento_receber>()
                .Property(e => e.codigo_modulo_lcto)
                .IsFixedLength();

            modelBuilder.Entity<fin_lancamento_receber>()
                .HasMany(e => e.fin_lcto_receber_nt_financeira)
                .WithRequired(e => e.fin_lancamento_receber)
                .HasForeignKey(e => e.id_fin_lancamento_receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_lancamento_receber>()
                .HasMany(e => e.fin_parcela_receber)
                .WithRequired(e => e.fin_lancamento_receber)
                .HasForeignKey(e => e.id_fin_lancamento_receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_lcto_pagar_nt_financeira>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lcto_pagar_nt_financeira>()
                .Property(e => e.percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lcto_receber_nt_financeira>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_lcto_receber_nt_financeira>()
                .Property(e => e.percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_pagamento_fixo>()
                .Property(e => e.pagamento_compartilhado)
                .IsFixedLength();

            modelBuilder.Entity<fin_pagamento_fixo>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_pagamento_fixo>()
                .Property(e => e.valor_a_pagar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagamento>()
                .Property(e => e.valor_pago)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.sofre_retencao)
                .IsFixedLength();

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_pagar>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithRequired(e => e.fin_parcela_pagar)
                .HasForeignKey(e => e.id_fin_parcela_pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_receber>()
                .Property(e => e.emitiu_boleto)
                .IsFixedLength();

            modelBuilder.Entity<fin_parcela_receber>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithRequired(e => e.fin_parcela_receber)
                .HasForeignKey(e => e.id_fin_parcela_receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_parcela_recebimento>()
                .Property(e => e.valor_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fin_status_parcela>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<fin_status_parcela>()
                .HasMany(e => e.fin_parcela_pagar)
                .WithRequired(e => e.fin_status_parcela)
                .HasForeignKey(e => e.id_fin_status_parcela)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_status_parcela>()
                .HasMany(e => e.fin_parcela_receber)
                .WithRequired(e => e.fin_status_parcela)
                .HasForeignKey(e => e.id_fin_status_parcela)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_tipo_pagamento>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<fin_tipo_pagamento>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithRequired(e => e.fin_tipo_pagamento)
                .HasForeignKey(e => e.id_fin_tipo_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_tipo_recebimento>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<fin_tipo_recebimento>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithRequired(e => e.fin_tipo_recebimento)
                .HasForeignKey(e => e.id_fin_tipo_recebimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fin_tipo_recebimento>()
                .HasMany(e => e.venda_condicoes_pagamento)
                .WithRequired(e => e.fin_tipo_recebimento)
                .HasForeignKey(e => e.id_fin_tipo_recebimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.optante_simples_nacional)
                .IsFixedLength();

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.localizacao)
                .IsFixedLength();

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.sofre_retencao)
                .IsFixedLength();

            modelBuilder.Entity<fornecedor>()
                .Property(e => e.gera_faturamento)
                .IsFixedLength();

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.compra_fornecedor_cotacao)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.compra_pedido)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.fin_lancamento_pagar)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.fin_pagamento_fixo)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.fornecedor_produto)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<fornecedor>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor);

            modelBuilder.Entity<fornecedor_produto>()
                .Property(e => e.preco_ultima_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fornecedor_produto>()
                .Property(e => e.lote_minimo_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fornecedor_produto>()
                .Property(e => e.menor_embalagem_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<fornecedor_produto>()
                .Property(e => e.custo_ultima_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<funcao>()
                .HasMany(e => e.papel_funcao)
                .WithRequired(e => e.funcao)
                .HasForeignKey(e => e.id_funcao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ibpt>()
                .Property(e => e.ex)
                .IsFixedLength();

            modelBuilder.Entity<ibpt>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<ibpt>()
                .Property(e => e.nacional_federal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ibpt>()
                .Property(e => e.importados_federal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ibpt>()
                .Property(e => e.estadual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ibpt>()
                .Property(e => e.municipal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<inventario_contagem_cab>()
                .Property(e => e.estoque_atualizado)
                .IsFixedLength();

            modelBuilder.Entity<inventario_contagem_cab>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<inventario_contagem_cab>()
                .HasMany(e => e.inventario_contagem_det)
                .WithRequired(e => e.inventario_contagem_cab)
                .HasForeignKey(e => e.id_inventario_contagem_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.contagem01)
                .HasPrecision(18, 6);

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.contagem02)
                .HasPrecision(18, 6);

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.contagem03)
                .HasPrecision(18, 6);

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.fechado_contagem)
                .IsFixedLength();

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.quantidade_sistema)
                .HasPrecision(18, 6);

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.acuracidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<inventario_contagem_det>()
                .Property(e => e.divergencia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<municipio>()
                .Property(e => e.uf_sigla)
                .IsFixedLength();

            modelBuilder.Entity<municipio>()
                .HasMany(e => e.transportadora_municipio)
                .WithRequired(e => e.municipio)
                .HasForeignKey(e => e.id_municipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<natureza_financeira>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<natureza_financeira>()
                .Property(e => e.aparece_a_pagar)
                .IsFixedLength();

            modelBuilder.Entity<natureza_financeira>()
                .Property(e => e.aparece_a_receber)
                .IsFixedLength();

            modelBuilder.Entity<natureza_financeira>()
                .HasMany(e => e.ct_resultado_nt_financeira)
                .WithRequired(e => e.natureza_financeira)
                .HasForeignKey(e => e.id_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<natureza_financeira>()
                .HasMany(e => e.fin_lcto_pagar_nt_financeira)
                .WithRequired(e => e.natureza_financeira)
                .HasForeignKey(e => e.id_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<natureza_financeira>()
                .HasMany(e => e.fin_lcto_receber_nt_financeira)
                .WithRequired(e => e.natureza_financeira)
                .HasForeignKey(e => e.id_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_caixa>()
                .HasMany(e => e.nfce_configuracao)
                .WithRequired(e => e.nfce_caixa)
                .HasForeignKey(e => e.id_nfce_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_caixa>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.nfce_caixa)
                .HasForeignKey(e => e.id_nfce_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_configuracao>()
                .Property(e => e.marketing_ativo)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao>()
                .Property(e => e.imprime_parcela)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao>()
                .Property(e => e.salvar_xml)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao>()
                .Property(e => e.webservice_uf)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao>()
                .Property(e => e.webservice_visualizar)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao>()
                .Property(e => e.email_autentica_ssl)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao>()
                .HasMany(e => e.nfce_configuracao_balanca)
                .WithRequired(e => e.nfce_configuracao)
                .HasForeignKey(e => e.id_nfce_configuracao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_configuracao>()
                .HasMany(e => e.nfce_configuracao_leitor_ser)
                .WithRequired(e => e.nfce_configuracao)
                .HasForeignKey(e => e.id_nfce_configuracao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_configuracao_balanca>()
                .Property(e => e.identificador)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_balanca>()
                .Property(e => e.porta)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_leitor_ser>()
                .Property(e => e.usa)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_leitor_ser>()
                .Property(e => e.porta)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_leitor_ser>()
                .Property(e => e.usar_fila)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_leitor_ser>()
                .Property(e => e.hard_flow)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_leitor_ser>()
                .Property(e => e.soft_flow)
                .IsFixedLength();

            modelBuilder.Entity<nfce_configuracao_leitor_ser>()
                .Property(e => e.excluir_sufixo)
                .IsFixedLength();

            modelBuilder.Entity<nfce_fechamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_suprimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_sangria)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_nao_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.total_cancelado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_movimento>()
                .Property(e => e.status_movimento)
                .IsFixedLength();

            modelBuilder.Entity<nfce_movimento>()
                .HasMany(e => e.nfce_fechamento)
                .WithRequired(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_movimento>()
                .HasMany(e => e.nfce_sangria)
                .WithRequired(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_movimento>()
                .HasMany(e => e.nfce_suprimento)
                .WithRequired(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_movimento>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento);

            modelBuilder.Entity<nfce_operador>()
                .Property(e => e.nivel_autorizacao)
                .IsFixedLength();

            modelBuilder.Entity<nfce_operador>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.nfce_operador)
                .HasForeignKey(e => e.id_nfce_operador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_resolucao>()
                .HasMany(e => e.nfce_configuracao)
                .WithRequired(e => e.nfce_resolucao)
                .HasForeignKey(e => e.id_nfce_resolucao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_resolucao>()
                .HasMany(e => e.nfce_posicao_componentes)
                .WithRequired(e => e.nfce_resolucao)
                .HasForeignKey(e => e.id_nfce_resolucao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_sangria>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_suprimento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfce_tipo_pagamento>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<nfce_tipo_pagamento>()
                .Property(e => e.permite_troco)
                .IsFixedLength();

            modelBuilder.Entity<nfce_tipo_pagamento>()
                .Property(e => e.gera_parcelas)
                .IsFixedLength();

            modelBuilder.Entity<nfce_tipo_pagamento>()
                .HasMany(e => e.nfe_forma_pagamento)
                .WithRequired(e => e.nfce_tipo_pagamento)
                .HasForeignKey(e => e.id_nfce_tipo_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfce_turno>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.nfce_turno)
                .HasForeignKey(e => e.id_nfce_turno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.codigo_modelo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.digito_chave_acesso)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_icms_desonerado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_imposto_importacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_despesas_acessorias)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_servicos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.base_calculo_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_pis_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_cofins_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_deducao_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.outras_retencoes_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.desconto_incondicionado_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.desconto_condicionado_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.total_retencao_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_retido_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_retido_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_retido_csll)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.base_calculo_irrf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_retido_irrf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.base_calculo_previdencia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_retido_previdencia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.comex_uf_embarque)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.indicador_presenca)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_fcp_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_ipi_devolvido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.codigo_status_resposta)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_icms_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_icms_inter_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .Property(e => e.valor_icms_inter_uf_remetente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_acesso_xml)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_cana)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_cte_referenciado)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_cupom_fiscal_referenciado)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_destinatario)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_detalhe)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_duplicata)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_emitente)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_fatura)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_forma_pagamento)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_local_entrega)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_local_retirada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_nf_referenciada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_processo_referenciado)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_prod_rural_referenciada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_referenciada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.nfe_transporte)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cabecalho>()
                .HasMany(e => e.produto_lote)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cana>()
                .HasMany(e => e.nfe_cana_deducoes_safra)
                .WithRequired(e => e.nfe_cana)
                .HasForeignKey(e => e.id_nfe_cana)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cana>()
                .HasMany(e => e.nfe_cana_fornecimento_diario)
                .WithRequired(e => e.nfe_cana)
                .HasForeignKey(e => e.id_nfe_cana)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_cana_deducoes_safra>()
                .Property(e => e.valor_deducao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_deducoes_safra>()
                .Property(e => e.valor_fornecimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_deducoes_safra>()
                .Property(e => e.valor_total_deducao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_deducoes_safra>()
                .Property(e => e.valor_liquido_fornecimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_fornecimento_diario>()
                .Property(e => e.dia)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cana_fornecimento_diario>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_fornecimento_diario>()
                .Property(e => e.quantidade_total_mes)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_fornecimento_diario>()
                .Property(e => e.quantidade_total_anterior)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_cana_fornecimento_diario>()
                .Property(e => e.quantidade_total_geral)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_configuracao>()
                .Property(e => e.salvar_xml)
                .IsFixedLength();

            modelBuilder.Entity<nfe_configuracao>()
                .Property(e => e.webservice_uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_configuracao>()
                .Property(e => e.webservice_visualizar)
                .IsFixedLength();

            modelBuilder.Entity<nfe_configuracao>()
                .Property(e => e.email_autentica_ssl)
                .IsFixedLength();

            modelBuilder.Entity<nfe_cupom_fiscal_referenciado>()
                .Property(e => e.modelo_documento_fiscal)
                .IsFixedLength();

            modelBuilder.Entity<nfe_declaracao_importacao>()
                .Property(e => e.uf_desembaraco)
                .IsFixedLength();

            modelBuilder.Entity<nfe_declaracao_importacao>()
                .Property(e => e.valor_afrmm)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_declaracao_importacao>()
                .Property(e => e.uf_terceiro)
                .IsFixedLength();

            modelBuilder.Entity<nfe_declaracao_importacao>()
                .HasMany(e => e.nfe_importacao_detalhe)
                .WithRequired(e => e.nfe_declaracao_importacao)
                .HasForeignKey(e => e.id_nfe_declaracao_importacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_destinatario>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.quantidade_temp_ambiente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.uf_consumo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.base_calculo_cide)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.aliquota_cide)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.valor_cide)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.percentual_petroleo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.percentual_nacional)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.percentual_importado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.valor_partida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.valor_encerrante_inicio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_combustivel>()
                .Property(e => e.valor_encerrante_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_medicamento>()
                .Property(e => e.preco_maximo_consumidor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.tipo_operacao)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.tipo_combustivel)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.ano_modelo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.ano_fabricacao)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.tipo_pintura)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.tipo_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.especie_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.condicao_vin)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.condicao_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.codigo_cor)
                .IsFixedLength();

            modelBuilder.Entity<nfe_det_especifico_veiculo>()
                .Property(e => e.restricao)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.quantidade_comercial)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_unitario_comercial)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_bruto_produto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.quantidade_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_unitario_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_outras_despesas)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_total_tributos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.percentual_devolvido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.valor_ipi_devolvido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe>()
                .Property(e => e.indicador_escala_relevante)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_declaracao_importacao)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_det_especifico_armamento)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_det_especifico_combustivel)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_det_especifico_medicamento)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_det_especifico_veiculo)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_cofins)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_icms)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_ii)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_ipi)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_issqn)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_pis)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_detalhe_rastro)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe>()
                .HasMany(e => e.nfe_exportacao)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_detalhe_imposto_cofins>()
                .Property(e => e.cst_cofins)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_cofins>()
                .Property(e => e.quantidade_vendida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_cofins>()
                .Property(e => e.base_calculo_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_cofins>()
                .Property(e => e.aliquota_cofins_percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_cofins>()
                .Property(e => e.aliquota_cofins_reais)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_cofins>()
                .Property(e => e.valor_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.cst_icms)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.csosn)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.taxa_reducao_bc_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.aliquota_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_operacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_diferimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_diferido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_desonerado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_mva_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_reducao_bc_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.aliquota_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_icms_st_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_st_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.aliquota_credito_icms_sn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_credito_icms_sn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_bc_operacao_propria)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.uf_st)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_bc_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.fcp_consumidor_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_fcp_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_bc_fcp_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_fcp_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_bc_icms_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.aliquota_interna_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.aliquota_interestadual_ufs)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.percentual_provisorio_partilha)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_inter_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_icms>()
                .Property(e => e.valor_icms_inter_uf_remetente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ii>()
                .Property(e => e.valor_bc_ii)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ii>()
                .Property(e => e.valor_despesas_aduaneiras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ii>()
                .Property(e => e.valor_imposto_importacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ii>()
                .Property(e => e.valor_iof)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.enquadramento_legal_ipi)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.cst_ipi)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.valor_base_calculo_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.aliquota_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.quantidade_unidade_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.valor_unidade_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_ipi>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.base_calculo_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.aliquota_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.valor_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.valor_deducao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.valor_outras_retencoes)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.valor_desconto_incondicionado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.valor_desconto_condicionado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_issqn>()
                .Property(e => e.valor_retencao_iss)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_pis>()
                .Property(e => e.cst_pis)
                .IsFixedLength();

            modelBuilder.Entity<nfe_detalhe_imposto_pis>()
                .Property(e => e.quantidade_vendida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_pis>()
                .Property(e => e.valor_base_calculo_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_pis>()
                .Property(e => e.aliquota_pis_percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_pis>()
                .Property(e => e.aliquota_pis_reais)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_imposto_pis>()
                .Property(e => e.valor_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_detalhe_rastro>()
                .Property(e => e.quantidade_lote)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_duplicata>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_emitente>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_emitente>()
                .Property(e => e.crt)
                .IsFixedLength();

            modelBuilder.Entity<nfe_exportacao>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_fatura>()
                .Property(e => e.valor_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_fatura>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_fatura>()
                .Property(e => e.valor_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_forma_pagamento>()
                .Property(e => e.forma)
                .IsFixedLength();

            modelBuilder.Entity<nfe_forma_pagamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_forma_pagamento>()
                .Property(e => e.cartao_tipo_integracao)
                .IsFixedLength();

            modelBuilder.Entity<nfe_forma_pagamento>()
                .Property(e => e.bandeira)
                .IsFixedLength();

            modelBuilder.Entity<nfe_forma_pagamento>()
                .Property(e => e.estorno)
                .IsFixedLength();

            modelBuilder.Entity<nfe_forma_pagamento>()
                .Property(e => e.troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_importacao_detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_local_entrega>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_local_retirada>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_nf_referenciada>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_nf_referenciada>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<nfe_numero>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<nfe_numero_inutilizado>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<nfe_processo_referenciado>()
                .Property(e => e.origem)
                .IsFixedLength();

            modelBuilder.Entity<nfe_prod_rural_referenciada>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_prod_rural_referenciada>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<nfe_transporte>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_transporte>()
                .Property(e => e.valor_servico)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_transporte>()
                .Property(e => e.valor_bc_retencao_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_transporte>()
                .Property(e => e.aliquota_retencao_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_transporte>()
                .Property(e => e.valor_icms_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_transporte>()
                .Property(e => e.uf_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<nfe_transporte>()
                .HasMany(e => e.nfe_transporte_reboque)
                .WithRequired(e => e.nfe_transporte)
                .HasForeignKey(e => e.id_nfe_transporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_transporte>()
                .HasMany(e => e.nfe_transporte_volume)
                .WithRequired(e => e.nfe_transporte)
                .HasForeignKey(e => e.id_nfe_transporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nfe_transporte_reboque>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<nfe_transporte_volume>()
                .Property(e => e.peso_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_transporte_volume>()
                .Property(e => e.peso_bruto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<nfe_transporte_volume>()
                .HasMany(e => e.nfe_transporte_volume_lacre)
                .WithRequired(e => e.nfe_transporte_volume)
                .HasForeignKey(e => e.id_nfe_transporte_volume)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nivel_formacao>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.nivel_formacao)
                .HasForeignKey(e => e.id_nivel_formacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nota_fiscal_modelo>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<nota_fiscal_modelo>()
                .HasMany(e => e.nota_fiscal_tipo)
                .WithRequired(e => e.nota_fiscal_modelo)
                .HasForeignKey(e => e.id_nota_fiscal_modelo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<nota_fiscal_tipo>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<nota_fiscal_tipo>()
                .Property(e => e.serie_scan)
                .IsFixedLength();

            modelBuilder.Entity<nota_fiscal_tipo>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.nota_fiscal_tipo)
                .HasForeignKey(e => e.id_tipo_nota_fiscal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<operadora_cartao>()
                .Property(e => e.taxa_adm)
                .HasPrecision(18, 6);

            modelBuilder.Entity<operadora_cartao>()
                .Property(e => e.taxa_adm_debito)
                .HasPrecision(18, 6);

            modelBuilder.Entity<operadora_cartao>()
                .Property(e => e.valor_aluguel_pos_pin)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pais>()
                .Property(e => e.sigla2)
                .IsFixedLength();

            modelBuilder.Entity<Pais>()
                .Property(e => e.sigla3)
                .IsFixedLength();

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.indice_economico)
                .WithRequired(e => e.pai)
                .HasForeignKey(e => e.id_pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.ufs)
                .WithRequired(e => e.pai)
                .HasForeignKey(e => e.id_pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<papel>()
                .Property(e => e.acesso_completo)
                .IsFixedLength();

            modelBuilder.Entity<papel>()
                .HasMany(e => e.papel_funcao)
                .WithRequired(e => e.papel)
                .HasForeignKey(e => e.id_papel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<papel>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.papel)
                .HasForeignKey(e => e.id_papel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<papel_funcao>()
                .Property(e => e.pode_consultar)
                .IsFixedLength();

            modelBuilder.Entity<papel_funcao>()
                .Property(e => e.pode_inserir)
                .IsFixedLength();

            modelBuilder.Entity<papel_funcao>()
                .Property(e => e.pode_alterar)
                .IsFixedLength();

            modelBuilder.Entity<papel_funcao>()
                .Property(e => e.pode_excluir)
                .IsFixedLength();

            modelBuilder.Entity<papel_funcao>()
                .Property(e => e.habilitado)
                .IsFixedLength();

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.cliente)
                .IsFixedLength();

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.fornecedor)
                .IsFixedLength();

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.colaborador)
                .IsFixedLength();

            modelBuilder.Entity<Pessoa>()
                .Property(e => e.transportadora)
                .IsFixedLength();

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.clientes)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.dav_cabecalho)
                .WithOptional(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.empresa_pessoa)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.fin_cheque_recebido)
                .WithOptional(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.fornecedors)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pessoa_alteracao)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pessoa_contato)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pessoa_endereco)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pessoa_fisica)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pessoa_juridica)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pessoa_telefone)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.pre_venda_cabecalho)
                .WithOptional(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa);

            modelBuilder.Entity<Pessoa>()
                .HasMany(e => e.transportadoras)
                .WithRequired(e => e.pessoa)
                .HasForeignKey(e => e.id_pessoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PessoaEndereco>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<PessoaEndereco>()
                .Property(e => e.principal)
                .IsFixedLength();

            modelBuilder.Entity<PessoaEndereco>()
                .Property(e => e.entrega)
                .IsFixedLength();

            modelBuilder.Entity<PessoaEndereco>()
                .Property(e => e.cobranca)
                .IsFixedLength();

            modelBuilder.Entity<PessoaEndereco>()
                .Property(e => e.correspondencia)
                .IsFixedLength();

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.sexo)
                .IsFixedLength();

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.raca)
                .IsFixedLength();

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.tipo_sangue)
                .IsFixedLength();

            modelBuilder.Entity<PessoaFisica>()
                .Property(e => e.cnh_categoria)
                .IsFixedLength();

            modelBuilder.Entity<PessoaJuridica>()
                .Property(e => e.tipo_regime)
                .IsFixedLength();

            modelBuilder.Entity<PessoaJuridica>()
                .Property(e => e.crt)
                .IsFixedLength();

            modelBuilder.Entity<plano_centro_resultado>()
                .HasMany(e => e.centro_resultado)
                .WithRequired(e => e.plano_centro_resultado)
                .HasForeignKey(e => e.id_plano_centro_resultado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<plano_natureza_financeira>()
                .HasMany(e => e.natureza_financeira)
                .WithRequired(e => e.plano_natureza_financeira)
                .HasForeignKey(e => e.id_plano_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_cabecalho>()
                .HasMany(e => e.pre_venda_detalhe)
                .WithRequired(e => e.pre_venda_cabecalho)
                .HasForeignKey(e => e.id_pre_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pre_venda_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<pre_venda_detalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.valor_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.valor_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.preco_venda_minimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.preco_sugerido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.custo_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.custo_producao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.custo_medio_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.preco_lucro_zero)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.preco_lucro_minimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.preco_lucro_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.markup)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.quantidade_estoque)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.quantidade_estoque_anterior)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.estoque_minimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.estoque_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.estoque_ideal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.excluido)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.inativo)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.ex_tipi)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.codigo_lst)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.classe_abc)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.iat)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.ippt)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.tipo_item_sped)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.peso)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.porcento_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.ponto_pedido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.lote_economico_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.aliquota_icms_paf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.aliquota_issqn_paf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Produto>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .Property(e => e.servico)
                .IsFixedLength();

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.comissao_objetivo)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.id_produto);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.compra_cotacao_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.compra_pedido_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.compra_requisicao_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.dav_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.empresa_produto)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.estoque_grade)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.id_produto);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.estoque_reajuste_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.ficha_tecnica)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.fornecedor_produto)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.inventario_contagem_det)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.nfe_detalhe)
                .WithOptional(e => e.produto)
                .HasForeignKey(e => e.id_produto);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.pre_venda_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.produto_alteracao_item)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.produto_codigo_adicional)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.produto_combo_item)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.produto_lacre_entrada)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.produto_lote)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.produto_promocao)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.requisicao_interna_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.tabela_preco_produto)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.unidade_conversao)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.venda_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.venda_orcamento_detalhe)
                .WithRequired(e => e.produto)
                .HasForeignKey(e => e.id_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoCombo>()
                .HasMany(e => e.produto_combo_item)
                .WithRequired(e => e.produto_combo)
                .HasForeignKey(e => e.id_produto_combo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoComboItem>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProdutoGrupo>()
                .HasMany(e => e.produto_subgrupo)
                .WithRequired(e => e.produto_grupo)
                .HasForeignKey(e => e.id_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoLacre>()
                .HasMany(e => e.produto_lacre_entrada)
                .WithRequired(e => e.produto_lacre)
                .HasForeignKey(e => e.id_lacre_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdutoLote>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProdutoLote>()
                .Property(e => e.preco_maximo_consumidor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProdutoMarca>()
                .HasMany(e => e.produtoes)
                .WithOptional(e => e.produto_marca)
                .HasForeignKey(e => e.id_marca_produto);

            modelBuilder.Entity<ProdutoPromocao>()
                .Property(e => e.quantidade_em_promocao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProdutoPromocao>()
                .Property(e => e.quantidade_maxima_cliente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProdutoPromocao>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ProdutoSubGrupo>()
                .HasMany(e => e.produtoes)
                .WithRequired(e => e.produto_subgrupo)
                .HasForeignKey(e => e.id_subgrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<quadro_societario>()
                .Property(e => e.capital_social)
                .HasPrecision(18, 6);

            modelBuilder.Entity<quadro_societario>()
                .Property(e => e.valor_quota)
                .HasPrecision(18, 6);

            modelBuilder.Entity<quadro_societario>()
                .HasMany(e => e.socios)
                .WithRequired(e => e.quadro_societario)
                .HasForeignKey(e => e.id_quadro_societario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<regiao>()
                .HasMany(e => e.ceps)
                .WithOptional(e => e.regiao)
                .HasForeignKey(e => e.id_regiao);

            modelBuilder.Entity<regiao>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.regiao)
                .HasForeignKey(e => e.id_regiao);

            modelBuilder.Entity<regiao>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.regiao)
                .HasForeignKey(e => e.id_regiao);

            modelBuilder.Entity<requisicao_interna_cabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<requisicao_interna_cabecalho>()
                .HasMany(e => e.requisicao_interna_detalhe)
                .WithRequired(e => e.requisicao_interna_cabecalho)
                .HasForeignKey(e => e.id_req_interna_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<requisicao_interna_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<setor>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.setor)
                .HasForeignKey(e => e.id_setor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sindicato>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<sindicato>()
                .Property(e => e.tipo_sindicato)
                .IsFixedLength();

            modelBuilder.Entity<sindicato>()
                .Property(e => e.piso_salarial)
                .HasPrecision(18, 6);

            modelBuilder.Entity<sindicato>()
                .HasMany(e => e.colaboradors)
                .WithOptional(e => e.sindicato)
                .HasForeignKey(e => e.id_sindicato);

            modelBuilder.Entity<sindicato>()
                .HasMany(e => e.contrib_sind_patronal_cab)
                .WithRequired(e => e.sindicato)
                .HasForeignKey(e => e.id_sindicato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sindicato>()
                .HasMany(e => e.empresas)
                .WithOptional(e => e.sindicato)
                .HasForeignKey(e => e.id_sindicato_patronal);

            modelBuilder.Entity<situacao_colaborador>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<situacao_colaborador>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.situacao_colaborador)
                .HasForeignKey(e => e.id_situacao_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<situacao_for_cli>()
                .HasMany(e => e.clientes)
                .WithRequired(e => e.situacao_for_cli)
                .HasForeignKey(e => e.id_situacao_for_cli)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<situacao_for_cli>()
                .HasMany(e => e.fornecedors)
                .WithRequired(e => e.situacao_for_cli)
                .HasForeignKey(e => e.id_situacao_for_cli)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<socio>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<socio>()
                .Property(e => e.participacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<socio>()
                .Property(e => e.integralizar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<socio>()
                .HasMany(e => e.socio_dependente)
                .WithRequired(e => e.socio)
                .HasForeignKey(e => e.id_socio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<socio>()
                .HasMany(e => e.socio_participacao_societaria)
                .WithRequired(e => e.socio)
                .HasForeignKey(e => e.id_socio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<socio_participacao_societaria>()
                .Property(e => e.participacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<socio_participacao_societaria>()
                .Property(e => e.dirigente)
                .IsFixedLength();

            modelBuilder.Entity<tabela_preco>()
                .Property(e => e.coeficiente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tabela_preco>()
                .Property(e => e.principal)
                .IsFixedLength();

            modelBuilder.Entity<tabela_preco>()
                .Property(e => e.base_custo)
                .IsFixedLength();

            modelBuilder.Entity<tabela_preco>()
                .Property(e => e.metodo_utilizacao)
                .IsFixedLength();

            modelBuilder.Entity<tabela_preco>()
                .Property(e => e.comissao_vendedor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tabela_preco>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco);

            modelBuilder.Entity<tabela_preco>()
                .HasMany(e => e.comissao_objetivo)
                .WithOptional(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco);

            modelBuilder.Entity<tabela_preco>()
                .HasMany(e => e.tabela_preco_produto)
                .WithRequired(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tabela_preco>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco);

            modelBuilder.Entity<tabela_preco_produto>()
                .Property(e => e.preco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<talonario_cheque>()
                .Property(e => e.status_talao)
                .IsFixedLength();

            modelBuilder.Entity<talonario_cheque>()
                .HasMany(e => e.cheques)
                .WithRequired(e => e.talonario_cheque)
                .HasForeignKey(e => e.id_talonario_cheque)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_admissao>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<tipo_admissao>()
                .HasMany(e => e.colaboradors)
                .WithOptional(e => e.tipo_admissao)
                .HasForeignKey(e => e.id_tipo_admissao);

            modelBuilder.Entity<tipo_colaborador>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.tipo_colaborador)
                .HasForeignKey(e => e.id_tipo_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_item_sped>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<tipo_receita_dipi>()
                .HasMany(e => e.tribut_ipi_dipi)
                .WithOptional(e => e.tipo_receita_dipi)
                .HasForeignKey(e => e.id_tipo_receita_dipi);

            modelBuilder.Entity<tipo_relacionamento>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<tipo_relacionamento>()
                .HasMany(e => e.colaborador_relacionamento)
                .WithRequired(e => e.tipo_relacionamento)
                .HasForeignKey(e => e.id_tipo_relacionamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_relacionamento>()
                .HasMany(e => e.socio_dependente)
                .WithRequired(e => e.tipo_relacionamento)
                .HasForeignKey(e => e.id_tipo_relacionamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<transportadora>()
                .HasMany(e => e.nfe_transporte)
                .WithOptional(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora);

            modelBuilder.Entity<transportadora>()
                .HasMany(e => e.transportadora_municipio)
                .WithRequired(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<transportadora>()
                .HasMany(e => e.venda_cabecalho)
                .WithOptional(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora);

            modelBuilder.Entity<transportadora>()
                .HasMany(e => e.venda_frete)
                .WithRequired(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<transportadora>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithOptional(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora);

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.cst_cofins)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.efd_tabela_435)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.modalidade_base_calculo)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.porcento_base_calculo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.aliquota_porcento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.aliquota_unidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_CofinsCodigoApuracao>()
                .Property(e => e.valor_pauta_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ConfiguraOperacaoFiscalGrupoTributario>()
                .HasMany(e => e.tribut_cofins_cod_apuracao)
                .WithRequired(e => e.tribut_configura_of_gt)
                .HasForeignKey(e => e.id_tribut_configura_of_gt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_ConfiguraOperacaoFiscalGrupoTributario>()
                .HasMany(e => e.tribut_icms_uf)
                .WithRequired(e => e.tribut_configura_of_gt)
                .HasForeignKey(e => e.id_tribut_configura_of_gt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_ConfiguraOperacaoFiscalGrupoTributario>()
                .HasMany(e => e.tribut_ipi_dipi)
                .WithRequired(e => e.tribut_configura_of_gt)
                .HasForeignKey(e => e.id_tribut_configura_of_gt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_ConfiguraOperacaoFiscalGrupoTributario>()
                .HasMany(e => e.tribut_pis_cod_apuracao)
                .WithRequired(e => e.tribut_configura_of_gt)
                .HasForeignKey(e => e.id_tribut_configura_of_gt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_GrupoTributario>()
                .Property(e => e.origem_mercadoria)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_GrupoTributario>()
                .HasMany(e => e.produtoes)
                .WithOptional(e => e.tribut_grupo_tributario)
                .HasForeignKey(e => e.id_grupo_tributario);

            modelBuilder.Entity<Tribut_GrupoTributario>()
                .HasMany(e => e.tribut_configura_of_gt)
                .WithRequired(e => e.tribut_grupo_tributario)
                .HasForeignKey(e => e.id_tribut_grupo_tributario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_ICMSCustomCabecalho>()
                .Property(e => e.origem_mercadoria)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomCabecalho>()
                .HasMany(e => e.produtoes)
                .WithOptional(e => e.tribut_icms_custom_cab)
                .HasForeignKey(e => e.id_tribut_icms_custom_cab);

            modelBuilder.Entity<Tribut_ICMSCustomCabecalho>()
                .HasMany(e => e.tribut_icms_custom_det)
                .WithRequired(e => e.tribut_icms_custom_cab)
                .HasForeignKey(e => e.id_tribut_icms_custom_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.uf_destino)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.csosn_b)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.cst_b)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.modalidade_bc)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.aliquota)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.valor_pauta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.mva)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.porcento_bc)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.modalidade_bc_st)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.aliquota_interna_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.aliquota_interestadual_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.porcento_bc_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.aliquota_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.valor_pauta_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomDetalhe>()
                .Property(e => e.valor_preco_maximo_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.uf_destino)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.csosn_b)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.cst_b)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.modalidade_bc)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.aliquota)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.valor_pauta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.mva)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.porcento_bc)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.modalidade_bc_st)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.aliquota_interna_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.aliquota_interestadual_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.porcento_bc_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.aliquota_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.valor_pauta_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.valor_preco_maximo_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMS_UF>()
                .Property(e => e.fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.cst_ipi)
                .IsFixedLength();

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.modalidade_base_calculo)
                .IsFixedLength();

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.porcento_base_calculo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.aliquota_porcento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.aliquota_unidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<tribut_ipi_dipi>()
                .Property(e => e.valor_pauta_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.modalidade_base_calculo)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.porcento_base_calculo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.aliquota_porcento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.aliquota_unidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.valor_pauta_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ISS>()
                .Property(e => e.codigo_tributacao)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_OperacaoFiscal>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.tribut_operacao_fiscal)
                .HasForeignKey(e => e.id_operacao_fiscal);

            modelBuilder.Entity<Tribut_OperacaoFiscal>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.tribut_operacao_fiscal)
                .HasForeignKey(e => e.id_tribut_operacao_fiscal);

            modelBuilder.Entity<Tribut_OperacaoFiscal>()
                .HasMany(e => e.tribut_configura_of_gt)
                .WithRequired(e => e.tribut_operacao_fiscal)
                .HasForeignKey(e => e.id_tribut_operacao_fiscal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_OperacaoFiscal>()
                .HasMany(e => e.tribut_iss)
                .WithRequired(e => e.tribut_operacao_fiscal)
                .HasForeignKey(e => e.id_tribut_operacao_fiscal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.cst_pis)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.efd_tabela_435)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.modalidade_base_calculo)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.porcento_base_calculo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.aliquota_porcento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.aliquota_unidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_PIS_CodigoApuracao>()
                .Property(e => e.valor_pauta_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<UF>()
                .Property(e => e.sigla)
                .IsFixedLength();

            modelBuilder.Entity<UF>()
                .HasMany(e => e.municipios)
                .WithRequired(e => e.uf)
                .HasForeignKey(e => e.id_uf)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<unidade_conversao>()
                .Property(e => e.fator_conversao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<unidade_conversao>()
                .Property(e => e.acao)
                .IsFixedLength();

            modelBuilder.Entity<UnidadeProduto>()
                .Property(e => e.pode_fracionar)
                .IsFixedLength();

            modelBuilder.Entity<UnidadeProduto>()
                .HasMany(e => e.produtoes)
                .WithRequired(e => e.unidade_produto)
                .HasForeignKey(e => e.id_unidade_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UnidadeProduto>()
                .HasMany(e => e.unidade_conversao)
                .WithRequired(e => e.unidade_produto)
                .HasForeignKey(e => e.id_unidade_produto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.administrador)
                .IsFixedLength();

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.auditorias)
                .WithRequired(e => e.usuario)
                .HasForeignKey(e => e.id_usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.forma_pagamento)
                .IsFixedLength();

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_cabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<venda_cabecalho>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho);

            modelBuilder.Entity<venda_cabecalho>()
                .HasMany(e => e.venda_comissao)
                .WithRequired(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_cabecalho>()
                .HasMany(e => e.venda_detalhe)
                .WithRequired(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_cabecalho>()
                .HasMany(e => e.venda_frete)
                .WithRequired(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_comissao>()
                .Property(e => e.valor_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_comissao>()
                .Property(e => e.tipo_contabil)
                .IsFixedLength();

            modelBuilder.Entity<venda_comissao>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_comissao>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .Property(e => e.faturamento_minimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .Property(e => e.faturamento_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .Property(e => e.indice_correcao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .Property(e => e.valor_tolerancia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .Property(e => e.vista_prazo)
                .IsFixedLength();

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.venda_condicoes_pagamento)
                .HasForeignKey(e => e.id_venda_condicoes_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .HasMany(e => e.venda_condicoes_parcelas)
                .WithRequired(e => e.venda_condicoes_pagamento)
                .HasForeignKey(e => e.id_venda_condicoes_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_condicoes_pagamento>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithRequired(e => e.venda_condicoes_pagamento)
                .HasForeignKey(e => e.id_venda_condicoes_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_condicoes_parcelas>()
                .Property(e => e.taxa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_detalhe>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_frete>()
                .Property(e => e.responsavel)
                .IsFixedLength();

            modelBuilder.Entity<venda_frete>()
                .Property(e => e.uf_placa)
                .IsFixedLength();

            modelBuilder.Entity<venda_frete>()
                .Property(e => e.quantidade_volume)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_frete>()
                .Property(e => e.peso_bruto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_frete>()
                .Property(e => e.peso_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .HasMany(e => e.venda_cabecalho)
                .WithOptional(e => e.venda_orcamento_cabecalho)
                .HasForeignKey(e => e.id_venda_orcamento_cabecalho);

            modelBuilder.Entity<venda_orcamento_cabecalho>()
                .HasMany(e => e.venda_orcamento_detalhe)
                .WithRequired(e => e.venda_orcamento_cabecalho)
                .HasForeignKey(e => e.id_venda_orcamento_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<venda_orcamento_detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_detalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_detalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_orcamento_detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<venda_romaneio_entrega>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<venda_romaneio_entrega>()
                .HasMany(e => e.venda_cabecalho)
                .WithOptional(e => e.venda_romaneio_entrega)
                .HasForeignKey(e => e.id_venda_romaneio_entrega);

            modelBuilder.Entity<vendedor>()
                .Property(e => e.comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<vendedor>()
                .Property(e => e.meta_vendas)
                .HasPrecision(18, 6);

            modelBuilder.Entity<vendedor>()
                .Property(e => e.gerente)
                .IsFixedLength();

            modelBuilder.Entity<vendedor>()
                .Property(e => e.taxa_gerente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<vendedor>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor);

            modelBuilder.Entity<vendedor>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vendedor>()
                .HasMany(e => e.venda_comissao)
                .WithRequired(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<vendedor>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithRequired(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor)
                .WillCascadeOnDelete(false);
        }
    }
}
