namespace Entity.Retaguarda.Model
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

        public virtual DbSet<ADM_Modulo> adm_modulo { get; set; }
        public virtual DbSet<ADM_Parametro> adm_parametro { get; set; }
        public virtual DbSet<AgenciaBanco> agencia_banco { get; set; }
        public virtual DbSet<Almoxarifado> almoxarifadoes { get; set; }
        public virtual DbSet<AtividadeFornecedorCliente> atividade_for_cli { get; set; }
        public virtual DbSet<Auditoria> auditorias { get; set; }
        public virtual DbSet<Banco> bancoes { get; set; }
        public virtual DbSet<Cargo> cargoes { get; set; }
        public virtual DbSet<CentroResultado> centro_resultado { get; set; }
        public virtual DbSet<CEP> ceps { get; set; }
        public virtual DbSet<CEST> cests { get; set; }
        public virtual DbSet<CFOP> cfops { get; set; }
        public virtual DbSet<Cheque> cheques { get; set; }
        public virtual DbSet<Cliente> clientes { get; set; }
        public virtual DbSet<CNAE> cnaes { get; set; }
        public virtual DbSet<Colaborador> colaboradors { get; set; }
        public virtual DbSet<ColaboradorRelacionamento> colaborador_relacionamento { get; set; }
        public virtual DbSet<ComissaoObjetivo> comissao_objetivo { get; set; }
        public virtual DbSet<ComissaoPerfil> comissao_perfil { get; set; }
        public virtual DbSet<CompraCotacao> compra_cotacao { get; set; }
        public virtual DbSet<CompraCotacaoDetalhe> compra_cotacao_detalhe { get; set; }
        public virtual DbSet<CompraCotacaoPedidoDetalhe> compra_cotacao_pedido_detalhe { get; set; }
        public virtual DbSet<CompraFornecedorCotacao> compra_fornecedor_cotacao { get; set; }
        public virtual DbSet<CompraPedido> compra_pedido { get; set; }
        public virtual DbSet<CompraPedidoDetalhe> compra_pedido_detalhe { get; set; }
        public virtual DbSet<CompraRequisicaoCotacaoDetalhe> compra_req_cotacao_detalhe { get; set; }
        public virtual DbSet<CompraRequisicao> compra_requisicao { get; set; }
        public virtual DbSet<CompraRequisicaoDetalhe> compra_requisicao_detalhe { get; set; }
        public virtual DbSet<CompraTipoPedido> compra_tipo_pedido { get; set; }
        public virtual DbSet<CompraTipoRequisicao> compra_tipo_requisicao { get; set; }
        public virtual DbSet<ContaCaixa> conta_caixa { get; set; }
        public virtual DbSet<ContabilConta> contabil_conta { get; set; }
        public virtual DbSet<Contador> contadors { get; set; }
        public virtual DbSet<ContribuicaoSindicalPatronalCabecalho> contrib_sind_patronal_cab { get; set; }
        public virtual DbSet<ContribuicaoSindicalPatronalDetalhe> contrib_sind_patronal_det { get; set; }
        public virtual DbSet<Convenio> convenios { get; set; }
        public virtual DbSet<CSOSN_A> csosn_a { get; set; }
        public virtual DbSet<CSOSN_B> csosn_b { get; set; }
        public virtual DbSet<CST_Cofins> cst_cofins { get; set; }
        public virtual DbSet<CST_ICMS_A> cst_icms_a { get; set; }
        public virtual DbSet<CST_ICMS_B> cst_icms_b { get; set; }
        public virtual DbSet<CST_IPI> cst_ipi { get; set; }
        public virtual DbSet<CST_PIS> cst_pis { get; set; }
        public virtual DbSet<CentroResultadoNaturezaFinanceira> ct_resultado_nt_financeira { get; set; }
        public virtual DbSet<CTe_Aereo> cte_aereo { get; set; }
        public virtual DbSet<CTe_Aquaviario> cte_aquaviario { get; set; }
        public virtual DbSet<CTe_AquaviarioBalsa> cte_aquaviario_balsa { get; set; }
        public virtual DbSet<CTe_Cabecalho> cte_cabecalho { get; set; }
        public virtual DbSet<CTe_Carga> cte_carga { get; set; }
        public virtual DbSet<CTe_Componente> cte_componente { get; set; }
        public virtual DbSet<CTe_Configuracao> cte_configuracao { get; set; }
        public virtual DbSet<CTe_Destinatario> cte_destinatario { get; set; }
        public virtual DbSet<CTe_DocumentoAnterior> cte_documento_anterior { get; set; }
        public virtual DbSet<CTe_DocumentoAnteriorID> cte_documento_anterior_id { get; set; }
        public virtual DbSet<CTe_Duplicata> cte_duplicata { get; set; }
        public virtual DbSet<CTe_Dutoviario> cte_dutoviario { get; set; }
        public virtual DbSet<CTe_Emitente> cte_emitente { get; set; }
        public virtual DbSet<CTe_Expedidor> cte_expedidor { get; set; }
        public virtual DbSet<CTe_Fatura> cte_fatura { get; set; }
        public virtual DbSet<CTe_Ferroviario> cte_ferroviario { get; set; }
        public virtual DbSet<CTe_FerroviarioFerrovia> cte_ferroviario_ferrovia { get; set; }
        public virtual DbSet<CTe_FerroviarioVagao> cte_ferroviario_vagao { get; set; }
        public virtual DbSet<CTe_InformacaoNotaFiscalCargaLacre> cte_inf_nf_carga_lacre { get; set; }
        public virtual DbSet<CTe_InformacaoNotaFiscalTransporteLacre> cte_inf_nf_transporte_lacre { get; set; }
        public virtual DbSet<CTe_InformacaoNotaFiscalCarga> cte_informacao_nf_carga { get; set; }
        public virtual DbSet<CTe_InformacaoNotaFiscalOutros> cte_informacao_nf_outros { get; set; }
        public virtual DbSet<CTe_InformacaoNotaFiscalTransporte> cte_informacao_nf_transporte { get; set; }
        public virtual DbSet<CTe_LocalColeta> cte_local_coleta { get; set; }
        public virtual DbSet<CTe_LocalEntrega> cte_local_entrega { get; set; }
        public virtual DbSet<CTe_Multimodal> cte_multimodal { get; set; }
        public virtual DbSet<CTe_Passagem> cte_passagem { get; set; }
        public virtual DbSet<CTe_Perigoso> cte_perigoso { get; set; }
        public virtual DbSet<CTe_Recebedor> cte_recebedor { get; set; }
        public virtual DbSet<CTe_Remetente> cte_remetente { get; set; }
        public virtual DbSet<CTe_Rodoviario> cte_rodoviario { get; set; }
        public virtual DbSet<CTe_RodoviarioLacre> cte_rodoviario_lacre { get; set; }
        public virtual DbSet<CTe_RodoviarioMotorista> cte_rodoviario_motorista { get; set; }
        public virtual DbSet<CTe_RodoviarioOcc> cte_rodoviario_occ { get; set; }
        public virtual DbSet<CTe_RodoviarioPedagio> cte_rodoviario_pedagio { get; set; }
        public virtual DbSet<CTe_RodoviarioVeiculo> cte_rodoviario_veiculo { get; set; }
        public virtual DbSet<CTe_Seguro> cte_seguro { get; set; }
        public virtual DbSet<CTe_Tomador> cte_tomador { get; set; }
        public virtual DbSet<CTe_VeiculoNovo> cte_veiculo_novo { get; set; }
        public virtual DbSet<DAV_Cabecalho> dav_cabecalho { get; set; }
        public virtual DbSet<DAV_Detalhe> dav_detalhe { get; set; }
        public virtual DbSet<DAV_DetalheAlteracao> dav_detalhe_alteracao { get; set; }
        public virtual DbSet<ECF_Aliquotas> ecf_aliquotas { get; set; }
        public virtual DbSet<ECF_Caixa> ecf_caixa { get; set; }
        public virtual DbSet<ECF_Configuracao> ecf_configuracao { get; set; }
        public virtual DbSet<ECF_DocumentosEmitidos> ecf_documentos_emitidos { get; set; }
        public virtual DbSet<ECF_e3> ecf_e3 { get; set; }
        public virtual DbSet<ECF_Fechamento> ecf_fechamento { get; set; }
        public virtual DbSet<ECF_Impressora> ecf_impressora { get; set; }
        public virtual DbSet<ECF_Movimento> ecf_movimento { get; set; }
        public virtual DbSet<ECF_NotaFiscalCabecalho> ecf_nota_fiscal_cabecalho { get; set; }
        public virtual DbSet<ECF_NotaFiscalDetalhe> ecf_nota_fiscal_detalhe { get; set; }
        public virtual DbSet<ECF_PosicaoComponentes> ecf_posicao_componentes { get; set; }
        public virtual DbSet<ECF_r02> ecf_r02 { get; set; }
        public virtual DbSet<ECF_r03> ecf_r03 { get; set; }
        public virtual DbSet<ECF_r06> ecf_r06 { get; set; }
        public virtual DbSet<ECF_r07> ecf_r07 { get; set; }
        public virtual DbSet<ECF_RecebimentoNaoFiscal> ecf_recebimento_nao_fiscal { get; set; }
        public virtual DbSet<ECF_Resolucao> ecf_resolucao { get; set; }
        public virtual DbSet<ECF_Sangria> ecf_sangria { get; set; }
        public virtual DbSet<ECF_Sintegra_60a> ecf_sintegra_60a { get; set; }
        public virtual DbSet<ECF_Sintegra_60m> ecf_sintegra_60m { get; set; }
        public virtual DbSet<ECF_Suprimento> ecf_suprimento { get; set; }
        public virtual DbSet<ECF_TipoPagamento> ecf_tipo_pagamento { get; set; }
        public virtual DbSet<ECF_TotalTipoPagamento> ecf_total_tipo_pagamento { get; set; }
        public virtual DbSet<ECF_Turno> ecf_turno { get; set; }
        public virtual DbSet<ECF_VendaCabecalho> ecf_venda_cabecalho { get; set; }
        public virtual DbSet<ECF_VendaDetalhe> ecf_venda_detalhe { get; set; }
        public virtual DbSet<EFC_Tabela_4310> efd_tabela_4310 { get; set; }
        public virtual DbSet<EFD_Tabela_4313> efd_tabela_4313 { get; set; }
        public virtual DbSet<EFD_Tabela_4314> efd_tabela_4314 { get; set; }
        public virtual DbSet<EFD_Tabela_4315> efd_tabela_4315 { get; set; }
        public virtual DbSet<EFD_Tabela_4316> efd_tabela_4316 { get; set; }
        public virtual DbSet<EFD_Tabela_436> efd_tabela_436 { get; set; }
        public virtual DbSet<EFD_Tabela_437> efd_tabela_437 { get; set; }
        public virtual DbSet<EFD_Tabela_439> efd_tabela_439 { get; set; }
        public virtual DbSet<Empresa> empresas { get; set; }
        public virtual DbSet<EmpresaCNAE> empresa_cnae { get; set; }
        public virtual DbSet<EmpresaContato> empresa_contato { get; set; }
        public virtual DbSet<EmpresaEndereco> empresa_endereco { get; set; }
        public virtual DbSet<EmpresaPessoa> empresa_pessoa { get; set; }
        public virtual DbSet<EmpresaProduto> empresa_produto { get; set; }
        public virtual DbSet<EmpresaTelefone> empresa_telefone { get; set; }
        public virtual DbSet<EstadoCivil> estado_civil { get; set; }
        public virtual DbSet<EstoqueCor> estoque_cor { get; set; }
        public virtual DbSet<EstoqueGrade> estoque_grade { get; set; }
        public virtual DbSet<EstoqueMarca> estoque_marca { get; set; }
        public virtual DbSet<EstoqueReajusteCabecalho> estoque_reajuste_cabecalho { get; set; }
        public virtual DbSet<EstoqueReajusteDetalhe> estoque_reajuste_detalhe { get; set; }
        public virtual DbSet<EstoqueSabor> estoque_sabor { get; set; }
        public virtual DbSet<EstoqueTamanho> estoque_tamanho { get; set; }
        public virtual DbSet<Feriado> feriados { get; set; }
        public virtual DbSet<FichaTecnica> ficha_tecnica { get; set; }
        public virtual DbSet<FIN_ChequeEmitido> fin_cheque_emitido { get; set; }
        public virtual DbSet<FIN_ChequeRecebido> fin_cheque_recebido { get; set; }
        public virtual DbSet<FIN_ClienteGrupoCabecalho> fin_cliente_grupo_cab { get; set; }
        public virtual DbSet<FIN_ClienteGrupoDetalhe> fin_cliente_grupo_det { get; set; }
        public virtual DbSet<FIN_Cobranca> fin_cobranca { get; set; }
        public virtual DbSet<FIN_CobrancaParcelaReceber> fin_cobranca_parcela_receber { get; set; }
        public virtual DbSet<FIN_ConfiguracaoBoleto> fin_configuracao_boleto { get; set; }
        public virtual DbSet<FIN_DocumentoOrigem> fin_documento_origem { get; set; }
        public virtual DbSet<FIN_ExtratoContaBanco> fin_extrato_conta_banco { get; set; }
        public virtual DbSet<FIN_FechamentoCaixaBanco> fin_fechamento_caixa_banco { get; set; }
        public virtual DbSet<FIN_LancamentoPagar> fin_lancamento_pagar { get; set; }
        public virtual DbSet<FIN_LancamentoReceber> fin_lancamento_receber { get; set; }
        public virtual DbSet<FIN_LancamentoPagarNotaFinanceira> fin_lcto_pagar_nt_financeira { get; set; }
        public virtual DbSet<FIN_LancamentoReceberNotaFinanceira> fin_lcto_receber_nt_financeira { get; set; }
        public virtual DbSet<FIN_PagamentoFixo> fin_pagamento_fixo { get; set; }
        public virtual DbSet<FIN_ParcelaPagamento> fin_parcela_pagamento { get; set; }
        public virtual DbSet<FIN_ParcelaPagar> fin_parcela_pagar { get; set; }
        public virtual DbSet<FIN_ParcelaReceber> fin_parcela_receber { get; set; }
        public virtual DbSet<FIN_ParcelaRecebimento> fin_parcela_recebimento { get; set; }
        public virtual DbSet<FIN_StatusParcela> fin_status_parcela { get; set; }
        public virtual DbSet<FIN_TipoPagamento> fin_tipo_pagamento { get; set; }
        public virtual DbSet<FIN_TipoRecebimento> fin_tipo_recebimento { get; set; }
        public virtual DbSet<Fornecedor> fornecedors { get; set; }
        public virtual DbSet<FornecedorProduto> fornecedor_produto { get; set; }
        public virtual DbSet<Funcao> funcaos { get; set; }
        public virtual DbSet<IBPT> ibpts { get; set; }
        public virtual DbSet<IndiceEconomico> indice_economico { get; set; }
        public virtual DbSet<IntegracaoPDV> integracao_pdv { get; set; }
        public virtual DbSet<InventarioContagemCabecalho> inventario_contagem_cab { get; set; }
        public virtual DbSet<InventarioContagemDetalhe> inventario_contagem_det { get; set; }
        public virtual DbSet<LogExportacao> log_exportacao { get; set; }
        public virtual DbSet<LogImportacao> log_importacao { get; set; }
        public virtual DbSet<Logss> logsses { get; set; }
        public virtual DbSet<Municipio> municipios { get; set; }
        public virtual DbSet<NaturezaFinanceira> natureza_financeira { get; set; }
        public virtual DbSet<NCM> ncms { get; set; }
        public virtual DbSet<NFCe_Caixa> nfce_caixa { get; set; }
        public virtual DbSet<NFCe_Configuracao> nfce_configuracao { get; set; }
        public virtual DbSet<NFCe_ConfiguracaoBalanca> nfce_configuracao_balanca { get; set; }
        public virtual DbSet<NFCe_ConfiguracaoLeitorSerial> nfce_configuracao_leitor_ser { get; set; }
        public virtual DbSet<NFCe_Fechamento> nfce_fechamento { get; set; }
        public virtual DbSet<NFCe_Movimento> nfce_movimento { get; set; }
        public virtual DbSet<NFCe_Operador> nfce_operador { get; set; }
        public virtual DbSet<NFCe_PosicaoComponentes> nfce_posicao_componentes { get; set; }
        public virtual DbSet<NFCe_Resolucao> nfce_resolucao { get; set; }
        public virtual DbSet<NFCe_Sangria> nfce_sangria { get; set; }
        public virtual DbSet<NFCe_Suprimento> nfce_suprimento { get; set; }
        public virtual DbSet<NFCe_TipoPagamento> nfce_tipo_pagamento { get; set; }
        public virtual DbSet<NFCe_Turno> nfce_turno { get; set; }
        public virtual DbSet<NFe_AcessoXML> nfe_acesso_xml { get; set; }
        public virtual DbSet<NFe_Cabecalho> nfe_cabecalho { get; set; }
        public virtual DbSet<NFe_Cana> nfe_cana { get; set; }
        public virtual DbSet<NFe_CanaDeducoesSafra> nfe_cana_deducoes_safra { get; set; }
        public virtual DbSet<NFe_CanaFornecimentoDiario> nfe_cana_fornecimento_diario { get; set; }
        public virtual DbSet<NFe_Configuracao> nfe_configuracao { get; set; }
        public virtual DbSet<NFe_CTe_Referenciado> nfe_cte_referenciado { get; set; }
        public virtual DbSet<NFe_CupomFiscalReferenciado> nfe_cupom_fiscal_referenciado { get; set; }
        public virtual DbSet<NFe_DeclaracaoImportacao> nfe_declaracao_importacao { get; set; }
        public virtual DbSet<NFe_Destinatario> nfe_destinatario { get; set; }
        public virtual DbSet<NFe_DetalheEspecificoArmamento> nfe_det_especifico_armamento { get; set; }
        public virtual DbSet<NFe_DetalheEspecificoCombustivel> nfe_det_especifico_combustivel { get; set; }
        public virtual DbSet<NFe_DetalheEspecificoMedicamento> nfe_det_especifico_medicamento { get; set; }
        public virtual DbSet<NFe_DetalheEspecificoVeiculo> nfe_det_especifico_veiculo { get; set; }
        public virtual DbSet<NFe_Detalhe> nfe_detalhe { get; set; }
        public virtual DbSet<NFe_DetalheImpostoCofins> nfe_detalhe_imposto_cofins { get; set; }
        public virtual DbSet<NFe_DetalheImpostoICMS> nfe_detalhe_imposto_icms { get; set; }
        public virtual DbSet<NFe_DetalheImposto_II> nfe_detalhe_imposto_ii { get; set; }
        public virtual DbSet<NFe_DetalheImpostoIPI> nfe_detalhe_imposto_ipi { get; set; }
        public virtual DbSet<NFe_DetalheImpostoISSQN> nfe_detalhe_imposto_issqn { get; set; }
        public virtual DbSet<NFe_DetalheImpostoPIS> nfe_detalhe_imposto_pis { get; set; }
        public virtual DbSet<NFe_DetalheRastro> nfe_detalhe_rastro { get; set; }
        public virtual DbSet<NFe_Duplicata> nfe_duplicata { get; set; }
        public virtual DbSet<NFe_Emitente> nfe_emitente { get; set; }
        public virtual DbSet<NFe_Exportacao> nfe_exportacao { get; set; }
        public virtual DbSet<NFe_Fatura> nfe_fatura { get; set; }
        public virtual DbSet<NFe_FormaPagamento> nfe_forma_pagamento { get; set; }
        public virtual DbSet<NFe_ImportacaoDetalhe> nfe_importacao_detalhe { get; set; }
        public virtual DbSet<NFe_LocalEntrega> nfe_local_entrega { get; set; }
        public virtual DbSet<NFe_LocalRetirada> nfe_local_retirada { get; set; }
        public virtual DbSet<NFe_NotaFiscalReferenciada> nfe_nf_referenciada { get; set; }
        public virtual DbSet<NFe_Numero> nfe_numero { get; set; }
        public virtual DbSet<NFe_NumeroInutilizado> nfe_numero_inutilizado { get; set; }
        public virtual DbSet<NFe_ProcessoReferenciado> nfe_processo_referenciado { get; set; }
        public virtual DbSet<NFe_ProdutorRuralReferenciada> nfe_prod_rural_referenciada { get; set; }
        public virtual DbSet<NFe_Referenciada> nfe_referenciada { get; set; }
        public virtual DbSet<NFe_Transporte> nfe_transporte { get; set; }
        public virtual DbSet<NFe_TransporteReboque> nfe_transporte_reboque { get; set; }
        public virtual DbSet<NFe_TransporteVolume> nfe_transporte_volume { get; set; }
        public virtual DbSet<NFe_TransporteVolumeLacre> nfe_transporte_volume_lacre { get; set; }
        public virtual DbSet<NivelFormacao> nivel_formacao { get; set; }
        public virtual DbSet<NotaFiscalModelo> nota_fiscal_modelo { get; set; }
        public virtual DbSet<NotaFiscalTipo> nota_fiscal_tipo { get; set; }
        public virtual DbSet<OperadoraCartao> operadora_cartao { get; set; }
        public virtual DbSet<OperadoraPlanoSaude> operadora_plano_saude { get; set; }
        public virtual DbSet<Pai> pais { get; set; }
        public virtual DbSet<Papel> papels { get; set; }
        public virtual DbSet<PapelFuncao> papel_funcao { get; set; }
        public virtual DbSet<Pessoa> pessoas { get; set; }
        public virtual DbSet<PessoaAlteracao> pessoa_alteracao { get; set; }
        public virtual DbSet<PessoaContato> pessoa_contato { get; set; }
        public virtual DbSet<PessoaEndereco> pessoa_endereco { get; set; }
        public virtual DbSet<PessoaFisica> pessoa_fisica { get; set; }
        public virtual DbSet<PessoaJuridica> pessoa_juridica { get; set; }
        public virtual DbSet<PessoaTelefone> pessoa_telefone { get; set; }
        public virtual DbSet<PlanoCentroResultado> plano_centro_resultado { get; set; }
        public virtual DbSet<PlanoNaturezaFinanceira> plano_natureza_financeira { get; set; }
        public virtual DbSet<PreVendaCabecalho> pre_venda_cabecalho { get; set; }
        public virtual DbSet<PreVendaDetalhe> pre_venda_detalhe { get; set; }
        public virtual DbSet<Produto> produtoes { get; set; }
        public virtual DbSet<ProdutoAlteracaoItem> produto_alteracao_item { get; set; }
        public virtual DbSet<ProdutoCodigoAdicional> produto_codigo_adicional { get; set; }
        public virtual DbSet<ProdutoCombo> produto_combo { get; set; }
        public virtual DbSet<ProdutoComboItem> produto_combo_item { get; set; }
        public virtual DbSet<ProdutoGrupo> produto_grupo { get; set; }
        public virtual DbSet<ProdutoLacre> produto_lacre { get; set; }
        public virtual DbSet<ProdutoLacreEntrada> produto_lacre_entrada { get; set; }
        public virtual DbSet<ProdutoLote> produto_lote { get; set; }
        public virtual DbSet<ProdutoMarca> produto_marca { get; set; }
        public virtual DbSet<ProdutoPromocao> produto_promocao { get; set; }
        public virtual DbSet<ProdutoSubgrupo> produto_subgrupo { get; set; }
        public virtual DbSet<QuadroSocietario> quadro_societario { get; set; }
        public virtual DbSet<Regiao> regiaos { get; set; }
        public virtual DbSet<RequisicaoInternaCabecalho> requisicao_interna_cabecalho { get; set; }
        public virtual DbSet<RequisicaoInternaDetalhe> requisicao_interna_detalhe { get; set; }
        public virtual DbSet<Setor> setors { get; set; }
        public virtual DbSet<Sindicato> sindicatoes { get; set; }
        public virtual DbSet<SituacaoColaborador> situacao_colaborador { get; set; }
        public virtual DbSet<SituacaoDocumento> situacao_documento { get; set; }
        public virtual DbSet<SituacaoFornecedorCliente> situacao_for_cli { get; set; }
        public virtual DbSet<Socio> socios { get; set; }
        public virtual DbSet<SocioDependente> socio_dependente { get; set; }
        public virtual DbSet<SocioParticipacaoSocietaria> socio_participacao_societaria { get; set; }
        public virtual DbSet<TabelaPreco> tabela_preco { get; set; }
        public virtual DbSet<TabelaPrecoProduto> tabela_preco_produto { get; set; }
        public virtual DbSet<TalonarioCheque> talonario_cheque { get; set; }
        public virtual DbSet<TipoAdmissao> tipo_admissao { get; set; }
        public virtual DbSet<TipoColaborador> tipo_colaborador { get; set; }
        public virtual DbSet<TipoItemSped> tipo_item_sped { get; set; }
        public virtual DbSet<TipoReceitaDipi> tipo_receita_dipi { get; set; }
        public virtual DbSet<TipoRelacionamento> tipo_relacionamento { get; set; }
        public virtual DbSet<Transportadora> transportadoras { get; set; }
        public virtual DbSet<TransportadoraMunicipio> transportadora_municipio { get; set; }
        public virtual DbSet<Tribut_CofinsCodigoApuracao> tribut_cofins_cod_apuracao { get; set; }
        public virtual DbSet<Tribut_ConfiguraOperacaoFiscalGrupoTributario> tribut_configura_of_gt { get; set; }
        public virtual DbSet<Tribut_GrupoTributario> tribut_grupo_tributario { get; set; }
        public virtual DbSet<Tribut_ICMSCustomizadoCabecalho> tribut_icms_custom_cab { get; set; }
        public virtual DbSet<Tribut_ICMSCustomizadoDetalhe> tribut_icms_custom_det { get; set; }
        public virtual DbSet<Tribut_ICMS_UF> tribut_icms_uf { get; set; }
        public virtual DbSet<Tribut_IPI_DIPI> tribut_ipi_dipi { get; set; }
        public virtual DbSet<Tribut_ISS> tribut_iss { get; set; }
        public virtual DbSet<Tribut_OperacaoFiscal> tribut_operacao_fiscal { get; set; }
        public virtual DbSet<Tribut_PIS_CodigoApuracao> tribut_pis_cod_apuracao { get; set; }
        public virtual DbSet<UF> ufs { get; set; }
        public virtual DbSet<UnidadeConversao> unidade_conversao { get; set; }
        public virtual DbSet<UnidadeProduto> unidade_produto { get; set; }
        public virtual DbSet<Usuario> usuarios { get; set; }
        public virtual DbSet<VendaCabecalho> venda_cabecalho { get; set; }
        public virtual DbSet<VendaComissao> venda_comissao { get; set; }
        public virtual DbSet<VendaCondicoesPagamento> venda_condicoes_pagamento { get; set; }
        public virtual DbSet<VendaCondicoesParcelas> venda_condicoes_parcelas { get; set; }
        public virtual DbSet<VendaDetalhe> venda_detalhe { get; set; }
        public virtual DbSet<VendaFrete> venda_frete { get; set; }
        public virtual DbSet<VendaOrcamentoCabecalho> venda_orcamento_cabecalho { get; set; }
        public virtual DbSet<VendaOrcamentoDetalhe> venda_orcamento_detalhe { get; set; }
        public virtual DbSet<VendaRomaneioEntrega> venda_romaneio_entrega { get; set; }
        public virtual DbSet<Vendedor> vendedors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADM_Modulo>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<ADM_Modulo>()
                .Property(e => e.ativo)
                .IsFixedLength();

            modelBuilder.Entity<AgenciaBanco>()
                .Property(e => e.digito)
                .IsFixedLength();

            modelBuilder.Entity<AgenciaBanco>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<AgenciaBanco>()
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

            modelBuilder.Entity<CentroResultado>()
                .Property(e => e.sofre_rateiro)
                .IsFixedLength();

            modelBuilder.Entity<CentroResultado>()
                .HasMany(e => e.ct_resultado_nt_financeira)
                .WithRequired(e => e.centro_resultado)
                .HasForeignKey(e => e.id_centro_resultado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CEST>()
                .Property(e => e.sigla_unidade)
                .IsFixedLength();

            modelBuilder.Entity<Cheque>()
                .Property(e => e.status_cheque)
                .IsFixedLength();

            modelBuilder.Entity<Cheque>()
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

            modelBuilder.Entity<CNAE>()
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

            modelBuilder.Entity<ColaboradorRelacionamento>()
                .Property(e => e.salario_familia)
                .IsFixedLength();

            modelBuilder.Entity<ComissaoObjetivo>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<ComissaoObjetivo>()
                .Property(e => e.forma_pagamento)
                .IsFixedLength();

            modelBuilder.Entity<ComissaoObjetivo>()
                .Property(e => e.taxa_pagamento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ComissaoObjetivo>()
                .Property(e => e.valor_pagamento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ComissaoObjetivo>()
                .Property(e => e.valor_meta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ComissaoObjetivo>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ComissaoPerfil>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<ComissaoPerfil>()
                .HasMany(e => e.comissao_objetivo)
                .WithRequired(e => e.comissao_perfil)
                .HasForeignKey(e => e.id_comissao_perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ComissaoPerfil>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.comissao_perfil)
                .HasForeignKey(e => e.id_comissao_perfil);

            modelBuilder.Entity<CompraCotacao>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<CompraCotacao>()
                .HasMany(e => e.compra_fornecedor_cotacao)
                .WithRequired(e => e.compra_cotacao)
                .HasForeignKey(e => e.id_compra_cotacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraCotacao>()
                .HasMany(e => e.compra_req_cotacao_detalhe)
                .WithRequired(e => e.compra_cotacao)
                .HasForeignKey(e => e.id_compra_cotacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.quantidade_pedida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraCotacaoDetalhe>()
                .HasMany(e => e.compra_cotacao_pedido_detalhe)
                .WithRequired(e => e.compra_cotacao_detalhe)
                .HasForeignKey(e => e.id_compra_cotacao_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraCotacaoPedidoDetalhe>()
                .Property(e => e.quantidade_pedida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraFornecedorCotacao>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraFornecedorCotacao>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraFornecedorCotacao>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraFornecedorCotacao>()
                .Property(e => e.total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraFornecedorCotacao>()
                .HasMany(e => e.compra_cotacao_detalhe)
                .WithRequired(e => e.compra_fornecedor_cotacao)
                .HasForeignKey(e => e.id_compra_fornecedor_cotacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_total_pedido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.forma_pagamento)
                .IsFixedLength();

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_outras_despesas)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .Property(e => e.valor_total_nf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedido>()
                .HasMany(e => e.compra_cotacao_pedido_detalhe)
                .WithRequired(e => e.compra_pedido)
                .HasForeignKey(e => e.id_compra_pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraPedido>()
                .HasMany(e => e.compra_pedido_detalhe)
                .WithRequired(e => e.compra_pedido)
                .HasForeignKey(e => e.id_compra_pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.cst_csosn)
                .IsFixedLength();

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.aliquota_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraPedidoDetalhe>()
                .Property(e => e.aliquota_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraRequisicaoCotacaoDetalhe>()
                .Property(e => e.quantidade_cotada)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraRequisicao>()
                .HasMany(e => e.compra_requisicao_detalhe)
                .WithRequired(e => e.compra_requisicao)
                .HasForeignKey(e => e.id_compra_requisicao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraRequisicaoDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraRequisicaoDetalhe>()
                .Property(e => e.quantidade_cotada)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CompraRequisicaoDetalhe>()
                .Property(e => e.item_cotado)
                .IsFixedLength();

            modelBuilder.Entity<CompraRequisicaoDetalhe>()
                .HasMany(e => e.compra_req_cotacao_detalhe)
                .WithRequired(e => e.compra_requisicao_detalhe)
                .HasForeignKey(e => e.id_compra_requisicao_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraTipoPedido>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CompraTipoPedido>()
                .HasMany(e => e.compra_pedido)
                .WithRequired(e => e.compra_tipo_pedido)
                .HasForeignKey(e => e.id_compra_tipo_pedido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompraTipoRequisicao>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CompraTipoRequisicao>()
                .HasMany(e => e.compra_requisicao)
                .WithRequired(e => e.compra_tipo_requisicao)
                .HasForeignKey(e => e.id_compra_tipo_requisicao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .Property(e => e.digito)
                .IsFixedLength();

            modelBuilder.Entity<ContaCaixa>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<ContaCaixa>()
                .Property(e => e.limite_credito)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContaCaixa>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContaCaixa>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContaCaixa>()
                .Property(e => e.desconto_maximo_permitido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_cheque_recebido)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_configuracao_boleto)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_extrato_conta_banco)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_fechamento_caixa_banco)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_parcela_pagar)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_parcela_receber)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.fin_tipo_recebimento)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.operadora_cartao)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContaCaixa>()
                .HasMany(e => e.talonario_cheque)
                .WithRequired(e => e.conta_caixa)
                .HasForeignKey(e => e.id_conta_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContabilConta>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<ContabilConta>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<ContabilConta>()
                .Property(e => e.natureza)
                .IsFixedLength();

            modelBuilder.Entity<ContabilConta>()
                .Property(e => e.patrimonio_resultado)
                .IsFixedLength();

            modelBuilder.Entity<ContabilConta>()
                .Property(e => e.livro_caixa)
                .IsFixedLength();

            modelBuilder.Entity<ContabilConta>()
                .Property(e => e.dfc)
                .IsFixedLength();

            modelBuilder.Entity<ContabilConta>()
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

            modelBuilder.Entity<ContribuicaoSindicalPatronalCabecalho>()
                .Property(e => e.vigencia_ano)
                .IsFixedLength();

            modelBuilder.Entity<ContribuicaoSindicalPatronalCabecalho>()
                .HasMany(e => e.contrib_sind_patronal_det)
                .WithRequired(e => e.contrib_sind_patronal_cab)
                .HasForeignKey(e => e.id_contrib_sind_patronal_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContribuicaoSindicalPatronalDetalhe>()
                .Property(e => e.de)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContribuicaoSindicalPatronalDetalhe>()
                .Property(e => e.ate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContribuicaoSindicalPatronalDetalhe>()
                .Property(e => e.percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ContribuicaoSindicalPatronalDetalhe>()
                .Property(e => e.valor_adicionar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Convenio>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Convenio>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<Convenio>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.convenio)
                .HasForeignKey(e => e.id_convenio);

            modelBuilder.Entity<CSOSN_A>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CSOSN_B>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CST_Cofins>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CST_ICMS_A>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CST_ICMS_B>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CST_IPI>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CST_PIS>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<CentroResultadoNaturezaFinanceira>()
                .Property(e => e.percentual_rateio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Aereo>()
                .Property(e => e.tarifa_classe)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Aereo>()
                .Property(e => e.tarifa_valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Aereo>()
                .Property(e => e.carga_especial)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Aquaviario>()
                .Property(e => e.valor_prestacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Aquaviario>()
                .Property(e => e.afrmm)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Aquaviario>()
                .HasMany(e => e.cte_aquaviario_balsa)
                .WithRequired(e => e.cte_aquaviario)
                .HasForeignKey(e => e.id_cte_aquaviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_AquaviarioBalsa>()
                .Property(e => e.direcao)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.digito_chave_acesso)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.uf_envio)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.modal)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.uf_ini_prestacao)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.uf_fim_prestacao)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_total_servico)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_receber)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.cst)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.aliquota_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.percentual_reducao_bc_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_bc_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.aliquota_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_credito_presumido_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.percentual_bc_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_bc_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.aliquota_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_icms_outra_uf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.simples_nacional_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_total_carga)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_bc_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.percentual_fcp_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.aliquota_icms_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.aliquota_interestadual_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.percentual_partilha_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_icms_fcp_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_icms_partilha_uf_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_icms_partilha_uf_ini)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.valor_carga_averbacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Cabecalho>()
                .Property(e => e.codigo_status_resposta)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_aereo)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_aquaviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_carga)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_componente)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_destinatario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_documento_anterior)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_duplicata)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_dutoviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_emitente)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_expedidor)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_fatura)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_ferroviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_informacao_nf_outros)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_local_coleta)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_local_entrega)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_multimodal)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_passagem)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_perigoso)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_recebedor)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_remetente)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_rodoviario)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_seguro)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_tomador)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Cabecalho>()
                .HasMany(e => e.cte_veiculo_novo)
                .WithRequired(e => e.cte_cabecalho)
                .HasForeignKey(e => e.id_cte_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Carga>()
                .Property(e => e.codigo_unidade_medida)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Carga>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Componente>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Configuracao>()
                .Property(e => e.salvar_xml)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Configuracao>()
                .Property(e => e.webservice_uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Configuracao>()
                .Property(e => e.webservice_visualizar)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Configuracao>()
                .Property(e => e.email_autentica_ssl)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Destinatario>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_DocumentoAnterior>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_DocumentoAnterior>()
                .HasMany(e => e.cte_documento_anterior_id)
                .WithRequired(e => e.cte_documento_anterior)
                .HasForeignKey(e => e.id_cte_documento_anterior)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_DocumentoAnteriorID>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<CTe_DocumentoAnteriorID>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<CTe_DocumentoAnteriorID>()
                .Property(e => e.subserie)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Duplicata>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Dutoviario>()
                .Property(e => e.valor_tarifa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Emitente>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Expedidor>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Fatura>()
                .Property(e => e.valor_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Fatura>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Fatura>()
                .Property(e => e.valor_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Ferroviario>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Ferroviario>()
                .HasMany(e => e.cte_ferroviario_ferrovia)
                .WithRequired(e => e.cte_ferroviario)
                .HasForeignKey(e => e.id_cte_ferroviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Ferroviario>()
                .HasMany(e => e.cte_ferroviario_vagao)
                .WithRequired(e => e.cte_ferroviario)
                .HasForeignKey(e => e.id_cte_ferroviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_FerroviarioFerrovia>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_FerroviarioVagao>()
                .Property(e => e.capacidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_FerroviarioVagao>()
                .Property(e => e.tipo_vagao)
                .IsFixedLength();

            modelBuilder.Entity<CTe_FerroviarioVagao>()
                .Property(e => e.peso_real)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_FerroviarioVagao>()
                .Property(e => e.peso_bc)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalCargaLacre>()
                .Property(e => e.quantidade_rateada)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalCarga>()
                .HasMany(e => e.cte_inf_nf_carga_lacre)
                .WithRequired(e => e.cte_informacao_nf_carga)
                .HasForeignKey(e => e.id_cte_informacao_nf_carga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.codigo_modelo)
                .IsFixedLength();

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.valor_total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.peso_total_kg)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.outro_tipo_doc_orig)
                .IsFixedLength();

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .Property(e => e.outro_valor_documento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .HasMany(e => e.cte_informacao_nf_carga)
                .WithRequired(e => e.cte_informacao_nf_outros)
                .HasForeignKey(e => e.id_cte_informacao_nf)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalOutros>()
                .HasMany(e => e.cte_informacao_nf_transporte)
                .WithRequired(e => e.cte_informacao_nf_outros)
                .HasForeignKey(e => e.id_cte_informacao_nf)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_InformacaoNotaFiscalTransporte>()
                .HasMany(e => e.cte_inf_nf_transporte_lacre)
                .WithRequired(e => e.cte_informacao_nf_transporte)
                .HasForeignKey(e => e.id_cte_informacao_nf_transp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_LocalColeta>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_LocalEntrega>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Recebedor>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Remetente>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Rodoviario>()
                .HasMany(e => e.cte_rodoviario_lacre)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Rodoviario>()
                .HasMany(e => e.cte_rodoviario_motorista)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Rodoviario>()
                .HasMany(e => e.cte_rodoviario_occ)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Rodoviario>()
                .HasMany(e => e.cte_rodoviario_pedagio)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_Rodoviario>()
                .HasMany(e => e.cte_rodoviario_veiculo)
                .WithRequired(e => e.cte_rodoviario)
                .HasForeignKey(e => e.id_cte_rodoviario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTe_RodoviarioOcc>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<CTe_RodoviarioOcc>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_RodoviarioPedagio>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_RodoviarioVeiculo>()
                .Property(e => e.tipo_propriedade)
                .IsFixedLength();

            modelBuilder.Entity<CTe_RodoviarioVeiculo>()
                .Property(e => e.tipo_rodado)
                .IsFixedLength();

            modelBuilder.Entity<CTe_RodoviarioVeiculo>()
                .Property(e => e.tipo_carroceria)
                .IsFixedLength();

            modelBuilder.Entity<CTe_RodoviarioVeiculo>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_RodoviarioVeiculo>()
                .Property(e => e.proprietario_uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_Seguro>()
                .Property(e => e.valor_carga)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_Tomador>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<CTe_VeiculoNovo>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTe_VeiculoNovo>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Cabecalho>()
                .Property(e => e.impresso)
                .IsFixedLength();

            modelBuilder.Entity<DAV_Cabecalho>()
                .HasMany(e => e.dav_detalhe)
                .WithRequired(e => e.dav_cabecalho)
                .HasForeignKey(e => e.id_dav_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAV_Detalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Detalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_Detalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<DAV_Detalhe>()
                .Property(e => e.mescla_produto)
                .IsFixedLength();

            modelBuilder.Entity<DAV_Detalhe>()
                .HasMany(e => e.dav_detalhe_alteracao)
                .WithRequired(e => e.dav_detalhe)
                .HasForeignKey(e => e.id_dav_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAV_DetalheAlteracao>()
                .Property(e => e.tipo_alteracao)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Aliquotas>()
                .Property(e => e.paf_p_st)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Configuracao>()
                .Property(e => e.porta_ecf)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Configuracao>()
                .Property(e => e.tipo_tef)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Configuracao>()
                .Property(e => e.marketing_ativo)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Configuracao>()
                .Property(e => e.pesquisa_parte)
                .IsFixedLength();

            modelBuilder.Entity<ECF_DocumentosEmitidos>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<ECF_e3>()
                .Property(e => e.mf_adicional)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Fechamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.mc)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.md)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.vr)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.modelo_documento_fiscal)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.le)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.lef)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.mfd)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Impressora>()
                .Property(e => e.lacre_na_mfd)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_suprimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_sangria)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_nao_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.total_cancelado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Movimento>()
                .Property(e => e.status_movimento)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.subserie)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.total_nf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.icms_outras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.acrescimo_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.desconto_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.cancelada)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalCabecalho>()
                .Property(e => e.tipo_nota)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.icms_outras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.icms_isento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.taxa_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.cst)
                .IsFixedLength();

            modelBuilder.Entity<ECF_NotaFiscalDetalhe>()
                .Property(e => e.movimenta_estoque)
                .IsFixedLength();

            modelBuilder.Entity<ECF_r02>()
                .Property(e => e.venda_bruta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_r02>()
                .Property(e => e.grande_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_r03>()
                .Property(e => e.valor_acumulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_r06>()
                .Property(e => e.denominacao)
                .IsFixedLength();

            modelBuilder.Entity<ECF_r07>()
                .Property(e => e.valor_pagamento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_r07>()
                .Property(e => e.estorno)
                .IsFixedLength();

            modelBuilder.Entity<ECF_r07>()
                .Property(e => e.valor_estorno)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_RecebimentoNaoFiscal>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Sangria>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Sintegra_60a>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Sintegra_60m>()
                .Property(e => e.modelo_documento_fiscal)
                .IsFixedLength();

            modelBuilder.Entity<ECF_Sintegra_60m>()
                .Property(e => e.valor_venda_bruta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Sintegra_60m>()
                .Property(e => e.valor_grande_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_Suprimento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_TipoPagamento>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TipoPagamento>()
                .Property(e => e.tef)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TipoPagamento>()
                .Property(e => e.imprime_vinculado)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TipoPagamento>()
                .Property(e => e.permite_troco)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TipoPagamento>()
                .Property(e => e.tef_tipo_gp)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TipoPagamento>()
                .Property(e => e.gera_parcelas)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TotalTipoPagamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_TotalTipoPagamento>()
                .Property(e => e.estorno)
                .IsFixedLength();

            modelBuilder.Entity<ECF_TotalTipoPagamento>()
                .Property(e => e.cartao_dc)
                .IsFixedLength();

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.valor_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.valor_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.valor_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.valor_cancelado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.total_documento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.icms_outras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.acrescimo_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.desconto_itens)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.status_venda)
                .IsFixedLength();

            modelBuilder.Entity<ECF_VendaCabecalho>()
                .Property(e => e.cupom_cancelado)
                .IsFixedLength();

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.total_item)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.base_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.taxa_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.taxa_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.taxa_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.taxa_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.acrescimo_rateio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.desconto_rateio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.cst)
                .IsFixedLength();

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.cancelado)
                .IsFixedLength();

            modelBuilder.Entity<ECF_VendaDetalhe>()
                .Property(e => e.movimenta_estoque)
                .IsFixedLength();

            modelBuilder.Entity<EFD_Tabela_437>()
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

            modelBuilder.Entity<EstoqueCor>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<EstoqueCor>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_cor)
                .HasForeignKey(e => e.id_estoque_cor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstoqueGrade>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueMarca>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<EstoqueMarca>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_marca)
                .HasForeignKey(e => e.id_estoque_marca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstoqueReajusteCabecalho>()
                .Property(e => e.porcentagem)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueReajusteCabecalho>()
                .Property(e => e.tipo_reajuste)
                .IsFixedLength();

            modelBuilder.Entity<EstoqueReajusteCabecalho>()
                .Property(e => e.quantidade_fixa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueReajusteCabecalho>()
                .Property(e => e.campo_reajuste)
                .IsFixedLength();

            modelBuilder.Entity<EstoqueReajusteCabecalho>()
                .HasMany(e => e.estoque_reajuste_detalhe)
                .WithRequired(e => e.estoque_reajuste_cabecalho)
                .HasForeignKey(e => e.id_estoque_reajuste_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstoqueReajusteDetalhe>()
                .Property(e => e.valor_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueReajusteDetalhe>()
                .Property(e => e.valor_reajuste)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueReajusteDetalhe>()
                .Property(e => e.quantidade_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueReajusteDetalhe>()
                .Property(e => e.quantidade_reajuste)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueSabor>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<EstoqueSabor>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_sabor)
                .HasForeignKey(e => e.id_estoque_sabor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstoqueTamanho>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<EstoqueTamanho>()
                .Property(e => e.altura)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueTamanho>()
                .Property(e => e.comprimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueTamanho>()
                .Property(e => e.largura)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EstoqueTamanho>()
                .HasMany(e => e.estoque_grade)
                .WithRequired(e => e.estoque_tamanho)
                .HasForeignKey(e => e.id_estoque_tamanho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feriado>()
                .Property(e => e.ano)
                .IsFixedLength();

            modelBuilder.Entity<Feriado>()
                .Property(e => e.abrangencia)
                .IsFixedLength();

            modelBuilder.Entity<Feriado>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<Feriado>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<FichaTecnica>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeEmitido>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeEmitido>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithOptional(e => e.fin_cheque_emitido)
                .HasForeignKey(e => e.id_fin_cheque_emitido);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .Property(e => e.custodia_tarifa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .Property(e => e.custodia_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .Property(e => e.desconto_tarifa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .Property(e => e.desconto_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .Property(e => e.valor_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ChequeRecebido>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithOptional(e => e.fin_cheque_recebido)
                .HasForeignKey(e => e.id_fin_cheque_recebido);

            modelBuilder.Entity<FIN_ClienteGrupoCabecalho>()
                .HasMany(e => e.fin_cliente_grupo_det)
                .WithRequired(e => e.fin_cliente_grupo_cab)
                .HasForeignKey(e => e.id_fin_cliente_grupo_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_ClienteGrupoDetalhe>()
                .Property(e => e.dia_lancamento)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ClienteGrupoDetalhe>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ClienteGrupoDetalhe>()
                .Property(e => e.gera_boleto)
                .IsFixedLength();

            modelBuilder.Entity<FIN_Cobranca>()
                .Property(e => e.total_receber_na_data)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_Cobranca>()
                .HasMany(e => e.fin_cobranca_parcela_receber)
                .WithRequired(e => e.fin_cobranca)
                .HasForeignKey(e => e.id_fin_cobranca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_parcela)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_juro_simulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_multa_simulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_receber_simulado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_juro_acordo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_multa_acordo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CobrancaParcelaReceber>()
                .Property(e => e.valor_receber_acordo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ConfiguracaoBoleto>()
                .Property(e => e.layout_remessa)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ConfiguracaoBoleto>()
                .Property(e => e.aceite)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ConfiguracaoBoleto>()
                .Property(e => e.especie)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ConfiguracaoBoleto>()
                .Property(e => e.carteira)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ConfiguracaoBoleto>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ConfiguracaoBoleto>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_DocumentoOrigem>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<FIN_DocumentoOrigem>()
                .Property(e => e.sigla_documento)
                .IsFixedLength();

            modelBuilder.Entity<FIN_DocumentoOrigem>()
                .HasMany(e => e.fin_lancamento_pagar)
                .WithRequired(e => e.fin_documento_origem)
                .HasForeignKey(e => e.id_fin_documento_origem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_DocumentoOrigem>()
                .HasMany(e => e.fin_lancamento_receber)
                .WithRequired(e => e.fin_documento_origem)
                .HasForeignKey(e => e.id_fin_documento_origem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_DocumentoOrigem>()
                .HasMany(e => e.fin_pagamento_fixo)
                .WithRequired(e => e.fin_documento_origem)
                .HasForeignKey(e => e.id_fin_documento_origem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_ExtratoContaBanco>()
                .Property(e => e.mes)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ExtratoContaBanco>()
                .Property(e => e.ano)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ExtratoContaBanco>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ExtratoContaBanco>()
                .Property(e => e.conciliado)
                .IsFixedLength();

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.mes)
                .IsFixedLength();

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.ano)
                .IsFixedLength();

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.saldo_anterior)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.recebimentos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.pagamentos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.saldo_conta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.cheque_nao_compensado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FechamentoCaixaBanco>()
                .Property(e => e.saldo_disponivel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoPagar>()
                .Property(e => e.pagamento_compartilhado)
                .IsFixedLength();

            modelBuilder.Entity<FIN_LancamentoPagar>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoPagar>()
                .Property(e => e.valor_a_pagar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoPagar>()
                .Property(e => e.codigo_modulo_lcto)
                .IsFixedLength();

            modelBuilder.Entity<FIN_LancamentoPagar>()
                .HasMany(e => e.fin_lcto_pagar_nt_financeira)
                .WithRequired(e => e.fin_lancamento_pagar)
                .HasForeignKey(e => e.id_fin_lancamento_pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LancamentoPagar>()
                .HasMany(e => e.fin_parcela_pagar)
                .WithRequired(e => e.fin_lancamento_pagar)
                .HasForeignKey(e => e.id_fin_lancamento_pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .Property(e => e.valor_desconto_convenio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .Property(e => e.valor_a_receber)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .Property(e => e.codigo_modulo_lcto)
                .IsFixedLength();

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .HasMany(e => e.fin_lcto_receber_nt_financeira)
                .WithRequired(e => e.fin_lancamento_receber)
                .HasForeignKey(e => e.id_fin_lancamento_receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LancamentoReceber>()
                .HasMany(e => e.fin_parcela_receber)
                .WithRequired(e => e.fin_lancamento_receber)
                .HasForeignKey(e => e.id_fin_lancamento_receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LancamentoPagarNotaFinanceira>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoPagarNotaFinanceira>()
                .Property(e => e.percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceberNotaFinanceira>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LancamentoReceberNotaFinanceira>()
                .Property(e => e.percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PagamentoFixo>()
                .Property(e => e.pagamento_compartilhado)
                .IsFixedLength();

            modelBuilder.Entity<FIN_PagamentoFixo>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PagamentoFixo>()
                .Property(e => e.valor_a_pagar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagamento>()
                .Property(e => e.valor_pago)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.sofre_retencao)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaPagar>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithRequired(e => e.fin_parcela_pagar)
                .HasForeignKey(e => e.id_fin_parcela_pagar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .Property(e => e.emitiu_boleto)
                .IsFixedLength();

            modelBuilder.Entity<FIN_ParcelaReceber>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithRequired(e => e.fin_parcela_receber)
                .HasForeignKey(e => e.id_fin_parcela_receber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.taxa_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.taxa_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.valor_juro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.valor_multa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_ParcelaRecebimento>()
                .Property(e => e.valor_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_StatusParcela>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<FIN_StatusParcela>()
                .HasMany(e => e.fin_parcela_pagar)
                .WithRequired(e => e.fin_status_parcela)
                .HasForeignKey(e => e.id_fin_status_parcela)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_StatusParcela>()
                .HasMany(e => e.fin_parcela_receber)
                .WithRequired(e => e.fin_status_parcela)
                .HasForeignKey(e => e.id_fin_status_parcela)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_TipoPagamento>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<FIN_TipoPagamento>()
                .HasMany(e => e.fin_parcela_pagamento)
                .WithRequired(e => e.fin_tipo_pagamento)
                .HasForeignKey(e => e.id_fin_tipo_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_TipoRecebimento>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<FIN_TipoRecebimento>()
                .HasMany(e => e.fin_parcela_recebimento)
                .WithRequired(e => e.fin_tipo_recebimento)
                .HasForeignKey(e => e.id_fin_tipo_recebimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_TipoRecebimento>()
                .HasMany(e => e.venda_condicoes_pagamento)
                .WithRequired(e => e.fin_tipo_recebimento)
                .HasForeignKey(e => e.id_fin_tipo_recebimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.optante_simples_nacional)
                .IsFixedLength();

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.localizacao)
                .IsFixedLength();

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.sofre_retencao)
                .IsFixedLength();

            modelBuilder.Entity<Fornecedor>()
                .Property(e => e.gera_faturamento)
                .IsFixedLength();

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.compra_fornecedor_cotacao)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.compra_pedido)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.fin_lancamento_pagar)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.fin_pagamento_fixo)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.fornecedor_produto)
                .WithRequired(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Fornecedor>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.fornecedor)
                .HasForeignKey(e => e.id_fornecedor);

            modelBuilder.Entity<FornecedorProduto>()
                .Property(e => e.preco_ultima_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FornecedorProduto>()
                .Property(e => e.lote_minimo_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FornecedorProduto>()
                .Property(e => e.menor_embalagem_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FornecedorProduto>()
                .Property(e => e.custo_ultima_compra)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Funcao>()
                .HasMany(e => e.papel_funcao)
                .WithRequired(e => e.funcao)
                .HasForeignKey(e => e.id_funcao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.ex)
                .IsFixedLength();

            modelBuilder.Entity<IBPT>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<IBPT>()
                .Property(e => e.nacional_federal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.importados_federal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.estadual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.municipal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InventarioContagemCabecalho>()
                .Property(e => e.estoque_atualizado)
                .IsFixedLength();

            modelBuilder.Entity<InventarioContagemCabecalho>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<InventarioContagemCabecalho>()
                .HasMany(e => e.inventario_contagem_det)
                .WithRequired(e => e.inventario_contagem_cab)
                .HasForeignKey(e => e.id_inventario_contagem_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.contagem01)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.contagem02)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.contagem03)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.fechado_contagem)
                .IsFixedLength();

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.quantidade_sistema)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.acuracidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<InventarioContagemDetalhe>()
                .Property(e => e.divergencia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Municipio>()
                .Property(e => e.uf_sigla)
                .IsFixedLength();

            modelBuilder.Entity<Municipio>()
                .HasMany(e => e.transportadora_municipio)
                .WithRequired(e => e.municipio)
                .HasForeignKey(e => e.id_municipio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaturezaFinanceira>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<NaturezaFinanceira>()
                .Property(e => e.aparece_a_pagar)
                .IsFixedLength();

            modelBuilder.Entity<NaturezaFinanceira>()
                .Property(e => e.aparece_a_receber)
                .IsFixedLength();

            modelBuilder.Entity<NaturezaFinanceira>()
                .HasMany(e => e.ct_resultado_nt_financeira)
                .WithRequired(e => e.natureza_financeira)
                .HasForeignKey(e => e.id_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaturezaFinanceira>()
                .HasMany(e => e.fin_lcto_pagar_nt_financeira)
                .WithRequired(e => e.natureza_financeira)
                .HasForeignKey(e => e.id_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaturezaFinanceira>()
                .HasMany(e => e.fin_lcto_receber_nt_financeira)
                .WithRequired(e => e.natureza_financeira)
                .HasForeignKey(e => e.id_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Caixa>()
                .HasMany(e => e.nfce_configuracao)
                .WithRequired(e => e.nfce_caixa)
                .HasForeignKey(e => e.id_nfce_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Caixa>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.nfce_caixa)
                .HasForeignKey(e => e.id_nfce_caixa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Configuracao>()
                .Property(e => e.marketing_ativo)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Configuracao>()
                .Property(e => e.imprime_parcela)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Configuracao>()
                .Property(e => e.salvar_xml)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Configuracao>()
                .Property(e => e.webservice_uf)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Configuracao>()
                .Property(e => e.webservice_visualizar)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Configuracao>()
                .Property(e => e.email_autentica_ssl)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Configuracao>()
                .HasMany(e => e.nfce_configuracao_balanca)
                .WithRequired(e => e.nfce_configuracao)
                .HasForeignKey(e => e.id_nfce_configuracao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Configuracao>()
                .HasMany(e => e.nfce_configuracao_leitor_ser)
                .WithRequired(e => e.nfce_configuracao)
                .HasForeignKey(e => e.id_nfce_configuracao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_ConfiguracaoBalanca>()
                .Property(e => e.identificador)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoBalanca>()
                .Property(e => e.porta)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoLeitorSerial>()
                .Property(e => e.usa)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoLeitorSerial>()
                .Property(e => e.porta)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoLeitorSerial>()
                .Property(e => e.usar_fila)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoLeitorSerial>()
                .Property(e => e.hard_flow)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoLeitorSerial>()
                .Property(e => e.soft_flow)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_ConfiguracaoLeitorSerial>()
                .Property(e => e.excluir_sufixo)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Fechamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_suprimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_sangria)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_nao_fiscal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_recebido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.total_cancelado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Movimento>()
                .Property(e => e.status_movimento)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Movimento>()
                .HasMany(e => e.nfce_fechamento)
                .WithRequired(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Movimento>()
                .HasMany(e => e.nfce_sangria)
                .WithRequired(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Movimento>()
                .HasMany(e => e.nfce_suprimento)
                .WithRequired(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Movimento>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.nfce_movimento)
                .HasForeignKey(e => e.id_nfce_movimento);

            modelBuilder.Entity<NFCe_Operador>()
                .Property(e => e.nivel_autorizacao)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_Operador>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.nfce_operador)
                .HasForeignKey(e => e.id_nfce_operador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Resolucao>()
                .HasMany(e => e.nfce_configuracao)
                .WithRequired(e => e.nfce_resolucao)
                .HasForeignKey(e => e.id_nfce_resolucao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Resolucao>()
                .HasMany(e => e.nfce_posicao_componentes)
                .WithRequired(e => e.nfce_resolucao)
                .HasForeignKey(e => e.id_nfce_resolucao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Sangria>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_Suprimento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCe_TipoPagamento>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_TipoPagamento>()
                .Property(e => e.permite_troco)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_TipoPagamento>()
                .Property(e => e.gera_parcelas)
                .IsFixedLength();

            modelBuilder.Entity<NFCe_TipoPagamento>()
                .HasMany(e => e.nfe_forma_pagamento)
                .WithRequired(e => e.nfce_tipo_pagamento)
                .HasForeignKey(e => e.id_nfce_tipo_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCe_Turno>()
                .HasMany(e => e.nfce_movimento)
                .WithRequired(e => e.nfce_turno)
                .HasForeignKey(e => e.id_nfce_turno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.codigo_modelo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.digito_chave_acesso)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_icms_desonerado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_total_produtos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_imposto_importacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_despesas_acessorias)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_servicos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.base_calculo_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_pis_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_cofins_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_deducao_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.outras_retencoes_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.desconto_incondicionado_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.desconto_condicionado_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.total_retencao_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_retido_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_retido_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_retido_csll)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.base_calculo_irrf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_retido_irrf)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.base_calculo_previdencia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_retido_previdencia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.comex_uf_embarque)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.indicador_presenca)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_fcp_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_ipi_devolvido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.codigo_status_resposta)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_icms_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_icms_inter_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .Property(e => e.valor_icms_inter_uf_remetente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_acesso_xml)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_cana)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_cte_referenciado)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_cupom_fiscal_referenciado)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_destinatario)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_detalhe)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_duplicata)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_emitente)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_fatura)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_forma_pagamento)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_local_entrega)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_local_retirada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_nf_referenciada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_processo_referenciado)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_prod_rural_referenciada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_referenciada)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.nfe_transporte)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cabecalho>()
                .HasMany(e => e.produto_lote)
                .WithRequired(e => e.nfe_cabecalho)
                .HasForeignKey(e => e.id_nfe_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cana>()
                .HasMany(e => e.nfe_cana_deducoes_safra)
                .WithRequired(e => e.nfe_cana)
                .HasForeignKey(e => e.id_nfe_cana)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Cana>()
                .HasMany(e => e.nfe_cana_fornecimento_diario)
                .WithRequired(e => e.nfe_cana)
                .HasForeignKey(e => e.id_nfe_cana)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_CanaDeducoesSafra>()
                .Property(e => e.valor_deducao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaDeducoesSafra>()
                .Property(e => e.valor_fornecimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaDeducoesSafra>()
                .Property(e => e.valor_total_deducao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaDeducoesSafra>()
                .Property(e => e.valor_liquido_fornecimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaFornecimentoDiario>()
                .Property(e => e.dia)
                .IsFixedLength();

            modelBuilder.Entity<NFe_CanaFornecimentoDiario>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaFornecimentoDiario>()
                .Property(e => e.quantidade_total_mes)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaFornecimentoDiario>()
                .Property(e => e.quantidade_total_anterior)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_CanaFornecimentoDiario>()
                .Property(e => e.quantidade_total_geral)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Configuracao>()
                .Property(e => e.salvar_xml)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Configuracao>()
                .Property(e => e.webservice_uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Configuracao>()
                .Property(e => e.webservice_visualizar)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Configuracao>()
                .Property(e => e.email_autentica_ssl)
                .IsFixedLength();

            modelBuilder.Entity<NFe_CupomFiscalReferenciado>()
                .Property(e => e.modelo_documento_fiscal)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DeclaracaoImportacao>()
                .Property(e => e.uf_desembaraco)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DeclaracaoImportacao>()
                .Property(e => e.valor_afrmm)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DeclaracaoImportacao>()
                .Property(e => e.uf_terceiro)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DeclaracaoImportacao>()
                .HasMany(e => e.nfe_importacao_detalhe)
                .WithRequired(e => e.nfe_declaracao_importacao)
                .HasForeignKey(e => e.id_nfe_declaracao_importacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Destinatario>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.quantidade_temp_ambiente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.uf_consumo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.base_calculo_cide)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.aliquota_cide)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.valor_cide)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.percentual_petroleo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.percentual_nacional)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.percentual_importado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.valor_partida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.valor_encerrante_inicio)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoCombustivel>()
                .Property(e => e.valor_encerrante_fim)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoMedicamento>()
                .Property(e => e.preco_maximo_consumidor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.tipo_operacao)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.tipo_combustivel)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.ano_modelo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.ano_fabricacao)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.tipo_pintura)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.tipo_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.especie_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.condicao_vin)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.condicao_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.codigo_cor)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheEspecificoVeiculo>()
                .Property(e => e.restricao)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.quantidade_comercial)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_unitario_comercial)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_bruto_produto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.quantidade_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_unitario_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_outras_despesas)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_total_tributos)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.percentual_devolvido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.valor_ipi_devolvido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Detalhe>()
                .Property(e => e.indicador_escala_relevante)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_declaracao_importacao)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_det_especifico_armamento)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_det_especifico_combustivel)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_det_especifico_medicamento)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_det_especifico_veiculo)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_cofins)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_icms)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_ii)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_ipi)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_issqn)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_imposto_pis)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_detalhe_rastro)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Detalhe>()
                .HasMany(e => e.nfe_exportacao)
                .WithRequired(e => e.nfe_detalhe)
                .HasForeignKey(e => e.id_nfe_detalhe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_DetalheImpostoCofins>()
                .Property(e => e.cst_cofins)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoCofins>()
                .Property(e => e.quantidade_vendida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoCofins>()
                .Property(e => e.base_calculo_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoCofins>()
                .Property(e => e.aliquota_cofins_percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoCofins>()
                .Property(e => e.aliquota_cofins_reais)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoCofins>()
                .Property(e => e.valor_cofins)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.cst_icms)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.csosn)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.taxa_reducao_bc_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.base_calculo_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.aliquota_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_operacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_diferimento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_diferido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_desonerado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_mva_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_reducao_bc_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_base_calculo_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.aliquota_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_st_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_icms_st_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_st_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.aliquota_credito_icms_sn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_credito_icms_sn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_bc_operacao_propria)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.uf_st)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_fcp)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_bc_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_fcp_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.fcp_consumidor_final)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_fcp_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_bc_fcp_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_fcp_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_bc_icms_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.aliquota_interna_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.aliquota_interestadual_ufs)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.percentual_provisorio_partilha)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_fcp_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_inter_uf_destino)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoICMS>()
                .Property(e => e.valor_icms_inter_uf_remetente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImposto_II>()
                .Property(e => e.valor_bc_ii)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImposto_II>()
                .Property(e => e.valor_despesas_aduaneiras)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImposto_II>()
                .Property(e => e.valor_imposto_importacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImposto_II>()
                .Property(e => e.valor_iof)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.enquadramento_legal_ipi)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.cst_ipi)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.valor_base_calculo_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.aliquota_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.quantidade_unidade_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.valor_unidade_tributavel)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoIPI>()
                .Property(e => e.valor_ipi)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.base_calculo_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.aliquota_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.valor_issqn)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.valor_deducao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.valor_outras_retencoes)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.valor_desconto_incondicionado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.valor_desconto_condicionado)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoISSQN>()
                .Property(e => e.valor_retencao_iss)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoPIS>()
                .Property(e => e.cst_pis)
                .IsFixedLength();

            modelBuilder.Entity<NFe_DetalheImpostoPIS>()
                .Property(e => e.quantidade_vendida)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoPIS>()
                .Property(e => e.valor_base_calculo_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoPIS>()
                .Property(e => e.aliquota_pis_percentual)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoPIS>()
                .Property(e => e.aliquota_pis_reais)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheImpostoPIS>()
                .Property(e => e.valor_pis)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_DetalheRastro>()
                .Property(e => e.quantidade_lote)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Duplicata>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Emitente>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Emitente>()
                .Property(e => e.crt)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Exportacao>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Fatura>()
                .Property(e => e.valor_original)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Fatura>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Fatura>()
                .Property(e => e.valor_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_FormaPagamento>()
                .Property(e => e.forma)
                .IsFixedLength();

            modelBuilder.Entity<NFe_FormaPagamento>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_FormaPagamento>()
                .Property(e => e.cartao_tipo_integracao)
                .IsFixedLength();

            modelBuilder.Entity<NFe_FormaPagamento>()
                .Property(e => e.bandeira)
                .IsFixedLength();

            modelBuilder.Entity<NFe_FormaPagamento>()
                .Property(e => e.estorno)
                .IsFixedLength();

            modelBuilder.Entity<NFe_FormaPagamento>()
                .Property(e => e.troco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_ImportacaoDetalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_LocalEntrega>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_LocalRetirada>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_NotaFiscalReferenciada>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_NotaFiscalReferenciada>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Numero>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<NFe_NumeroInutilizado>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<NFe_ProcessoReferenciado>()
                .Property(e => e.origem)
                .IsFixedLength();

            modelBuilder.Entity<NFe_ProdutorRuralReferenciada>()
                .Property(e => e.modelo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_ProdutorRuralReferenciada>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Transporte>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Transporte>()
                .Property(e => e.valor_servico)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Transporte>()
                .Property(e => e.valor_bc_retencao_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Transporte>()
                .Property(e => e.aliquota_retencao_icms)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Transporte>()
                .Property(e => e.valor_icms_retido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_Transporte>()
                .Property(e => e.uf_veiculo)
                .IsFixedLength();

            modelBuilder.Entity<NFe_Transporte>()
                .HasMany(e => e.nfe_transporte_reboque)
                .WithRequired(e => e.nfe_transporte)
                .HasForeignKey(e => e.id_nfe_transporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_Transporte>()
                .HasMany(e => e.nfe_transporte_volume)
                .WithRequired(e => e.nfe_transporte)
                .HasForeignKey(e => e.id_nfe_transporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFe_TransporteReboque>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<NFe_TransporteVolume>()
                .Property(e => e.peso_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_TransporteVolume>()
                .Property(e => e.peso_bruto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFe_TransporteVolume>()
                .HasMany(e => e.nfe_transporte_volume_lacre)
                .WithRequired(e => e.nfe_transporte_volume)
                .HasForeignKey(e => e.id_nfe_transporte_volume)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NivelFormacao>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.nivel_formacao)
                .HasForeignKey(e => e.id_nivel_formacao)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaFiscalModelo>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<NotaFiscalModelo>()
                .HasMany(e => e.nota_fiscal_tipo)
                .WithRequired(e => e.nota_fiscal_modelo)
                .HasForeignKey(e => e.id_nota_fiscal_modelo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaFiscalTipo>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<NotaFiscalTipo>()
                .Property(e => e.serie_scan)
                .IsFixedLength();

            modelBuilder.Entity<NotaFiscalTipo>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.nota_fiscal_tipo)
                .HasForeignKey(e => e.id_tipo_nota_fiscal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperadoraCartao>()
                .Property(e => e.taxa_adm)
                .HasPrecision(18, 6);

            modelBuilder.Entity<OperadoraCartao>()
                .Property(e => e.taxa_adm_debito)
                .HasPrecision(18, 6);

            modelBuilder.Entity<OperadoraCartao>()
                .Property(e => e.valor_aluguel_pos_pin)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Pai>()
                .Property(e => e.sigla2)
                .IsFixedLength();

            modelBuilder.Entity<Pai>()
                .Property(e => e.sigla3)
                .IsFixedLength();

            modelBuilder.Entity<Pai>()
                .HasMany(e => e.indice_economico)
                .WithRequired(e => e.pai)
                .HasForeignKey(e => e.id_pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pai>()
                .HasMany(e => e.ufs)
                .WithRequired(e => e.pai)
                .HasForeignKey(e => e.id_pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Papel>()
                .Property(e => e.acesso_completo)
                .IsFixedLength();

            modelBuilder.Entity<Papel>()
                .HasMany(e => e.papel_funcao)
                .WithRequired(e => e.papel)
                .HasForeignKey(e => e.id_papel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Papel>()
                .HasMany(e => e.usuarios)
                .WithRequired(e => e.papel)
                .HasForeignKey(e => e.id_papel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PapelFuncao>()
                .Property(e => e.pode_consultar)
                .IsFixedLength();

            modelBuilder.Entity<PapelFuncao>()
                .Property(e => e.pode_inserir)
                .IsFixedLength();

            modelBuilder.Entity<PapelFuncao>()
                .Property(e => e.pode_alterar)
                .IsFixedLength();

            modelBuilder.Entity<PapelFuncao>()
                .Property(e => e.pode_excluir)
                .IsFixedLength();

            modelBuilder.Entity<PapelFuncao>()
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

            modelBuilder.Entity<PlanoCentroResultado>()
                .HasMany(e => e.centro_resultado)
                .WithRequired(e => e.plano_centro_resultado)
                .HasForeignKey(e => e.id_plano_centro_resultado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlanoNaturezaFinanceira>()
                .HasMany(e => e.natureza_financeira)
                .WithRequired(e => e.plano_natureza_financeira)
                .HasForeignKey(e => e.id_plano_natureza_financeira)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.valor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.taxa_acrescimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaCabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaCabecalho>()
                .HasMany(e => e.pre_venda_detalhe)
                .WithRequired(e => e.pre_venda_cabecalho)
                .HasForeignKey(e => e.id_pre_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PreVendaDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PreVendaDetalhe>()
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

            modelBuilder.Entity<ProdutoSubgrupo>()
                .HasMany(e => e.produtoes)
                .WithRequired(e => e.produto_subgrupo)
                .HasForeignKey(e => e.id_subgrupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuadroSocietario>()
                .Property(e => e.capital_social)
                .HasPrecision(18, 6);

            modelBuilder.Entity<QuadroSocietario>()
                .Property(e => e.valor_quota)
                .HasPrecision(18, 6);

            modelBuilder.Entity<QuadroSocietario>()
                .HasMany(e => e.socios)
                .WithRequired(e => e.quadro_societario)
                .HasForeignKey(e => e.id_quadro_societario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regiao>()
                .HasMany(e => e.ceps)
                .WithOptional(e => e.regiao)
                .HasForeignKey(e => e.id_regiao);

            modelBuilder.Entity<Regiao>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.regiao)
                .HasForeignKey(e => e.id_regiao);

            modelBuilder.Entity<Regiao>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.regiao)
                .HasForeignKey(e => e.id_regiao);

            modelBuilder.Entity<RequisicaoInternaCabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<RequisicaoInternaCabecalho>()
                .HasMany(e => e.requisicao_interna_detalhe)
                .WithRequired(e => e.requisicao_interna_cabecalho)
                .HasForeignKey(e => e.id_req_interna_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RequisicaoInternaDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Setor>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.setor)
                .HasForeignKey(e => e.id_setor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sindicato>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<Sindicato>()
                .Property(e => e.tipo_sindicato)
                .IsFixedLength();

            modelBuilder.Entity<Sindicato>()
                .Property(e => e.piso_salarial)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Sindicato>()
                .HasMany(e => e.colaboradors)
                .WithOptional(e => e.sindicato)
                .HasForeignKey(e => e.id_sindicato);

            modelBuilder.Entity<Sindicato>()
                .HasMany(e => e.contrib_sind_patronal_cab)
                .WithRequired(e => e.sindicato)
                .HasForeignKey(e => e.id_sindicato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sindicato>()
                .HasMany(e => e.empresas)
                .WithOptional(e => e.sindicato)
                .HasForeignKey(e => e.id_sindicato_patronal);

            modelBuilder.Entity<SituacaoColaborador>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<SituacaoColaborador>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.situacao_colaborador)
                .HasForeignKey(e => e.id_situacao_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacaoFornecedorCliente>()
                .HasMany(e => e.clientes)
                .WithRequired(e => e.situacao_for_cli)
                .HasForeignKey(e => e.id_situacao_for_cli)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituacaoFornecedorCliente>()
                .HasMany(e => e.fornecedors)
                .WithRequired(e => e.situacao_for_cli)
                .HasForeignKey(e => e.id_situacao_for_cli)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Socio>()
                .Property(e => e.uf)
                .IsFixedLength();

            modelBuilder.Entity<Socio>()
                .Property(e => e.participacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Socio>()
                .Property(e => e.integralizar)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Socio>()
                .HasMany(e => e.socio_dependente)
                .WithRequired(e => e.socio)
                .HasForeignKey(e => e.id_socio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Socio>()
                .HasMany(e => e.socio_participacao_societaria)
                .WithRequired(e => e.socio)
                .HasForeignKey(e => e.id_socio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SocioParticipacaoSocietaria>()
                .Property(e => e.participacao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SocioParticipacaoSocietaria>()
                .Property(e => e.dirigente)
                .IsFixedLength();

            modelBuilder.Entity<TabelaPreco>()
                .Property(e => e.coeficiente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TabelaPreco>()
                .Property(e => e.principal)
                .IsFixedLength();

            modelBuilder.Entity<TabelaPreco>()
                .Property(e => e.base_custo)
                .IsFixedLength();

            modelBuilder.Entity<TabelaPreco>()
                .Property(e => e.metodo_utilizacao)
                .IsFixedLength();

            modelBuilder.Entity<TabelaPreco>()
                .Property(e => e.comissao_vendedor)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TabelaPreco>()
                .HasMany(e => e.clientes)
                .WithOptional(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco);

            modelBuilder.Entity<TabelaPreco>()
                .HasMany(e => e.comissao_objetivo)
                .WithOptional(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco);

            modelBuilder.Entity<TabelaPreco>()
                .HasMany(e => e.tabela_preco_produto)
                .WithRequired(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TabelaPreco>()
                .HasMany(e => e.vendedors)
                .WithOptional(e => e.tabela_preco)
                .HasForeignKey(e => e.id_tabela_preco);

            modelBuilder.Entity<TabelaPrecoProduto>()
                .Property(e => e.preco)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TalonarioCheque>()
                .Property(e => e.status_talao)
                .IsFixedLength();

            modelBuilder.Entity<TalonarioCheque>()
                .HasMany(e => e.cheques)
                .WithRequired(e => e.talonario_cheque)
                .HasForeignKey(e => e.id_talonario_cheque)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoAdmissao>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<TipoAdmissao>()
                .HasMany(e => e.colaboradors)
                .WithOptional(e => e.tipo_admissao)
                .HasForeignKey(e => e.id_tipo_admissao);

            modelBuilder.Entity<TipoColaborador>()
                .HasMany(e => e.colaboradors)
                .WithRequired(e => e.tipo_colaborador)
                .HasForeignKey(e => e.id_tipo_colaborador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoItemSped>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<TipoReceitaDipi>()
                .HasMany(e => e.tribut_ipi_dipi)
                .WithOptional(e => e.tipo_receita_dipi)
                .HasForeignKey(e => e.id_tipo_receita_dipi);

            modelBuilder.Entity<TipoRelacionamento>()
                .Property(e => e.codigo)
                .IsFixedLength();

            modelBuilder.Entity<TipoRelacionamento>()
                .HasMany(e => e.colaborador_relacionamento)
                .WithRequired(e => e.tipo_relacionamento)
                .HasForeignKey(e => e.id_tipo_relacionamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoRelacionamento>()
                .HasMany(e => e.socio_dependente)
                .WithRequired(e => e.tipo_relacionamento)
                .HasForeignKey(e => e.id_tipo_relacionamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.nfe_transporte)
                .WithOptional(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.transportadora_municipio)
                .WithRequired(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.venda_cabecalho)
                .WithOptional(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora);

            modelBuilder.Entity<Transportadora>()
                .HasMany(e => e.venda_frete)
                .WithRequired(e => e.transportadora)
                .HasForeignKey(e => e.id_transportadora)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transportadora>()
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

            modelBuilder.Entity<Tribut_ICMSCustomizadoCabecalho>()
                .Property(e => e.origem_mercadoria)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomizadoCabecalho>()
                .HasMany(e => e.produtoes)
                .WithOptional(e => e.tribut_icms_custom_cab)
                .HasForeignKey(e => e.id_tribut_icms_custom_cab);

            modelBuilder.Entity<Tribut_ICMSCustomizadoCabecalho>()
                .HasMany(e => e.tribut_icms_custom_det)
                .WithRequired(e => e.tribut_icms_custom_cab)
                .HasForeignKey(e => e.id_tribut_icms_custom_cab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.uf_destino)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.csosn_b)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.cst_b)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.modalidade_bc)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.aliquota)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.valor_pauta)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.mva)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.porcento_bc)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.modalidade_bc_st)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.aliquota_interna_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.aliquota_interestadual_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.porcento_bc_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.aliquota_icms_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
                .Property(e => e.valor_pauta_st)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_ICMSCustomizadoDetalhe>()
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

            modelBuilder.Entity<Tribut_IPI_DIPI>()
                .Property(e => e.cst_ipi)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_IPI_DIPI>()
                .Property(e => e.modalidade_base_calculo)
                .IsFixedLength();

            modelBuilder.Entity<Tribut_IPI_DIPI>()
                .Property(e => e.porcento_base_calculo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_IPI_DIPI>()
                .Property(e => e.aliquota_porcento)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_IPI_DIPI>()
                .Property(e => e.aliquota_unidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_IPI_DIPI>()
                .Property(e => e.valor_preco_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Tribut_IPI_DIPI>()
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

            modelBuilder.Entity<UnidadeConversao>()
                .Property(e => e.fator_conversao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<UnidadeConversao>()
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

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.forma_pagamento)
                .IsFixedLength();

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.valor_seguro)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<VendaCabecalho>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho);

            modelBuilder.Entity<VendaCabecalho>()
                .HasMany(e => e.venda_comissao)
                .WithRequired(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaCabecalho>()
                .HasMany(e => e.venda_detalhe)
                .WithRequired(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaCabecalho>()
                .HasMany(e => e.venda_frete)
                .WithRequired(e => e.venda_cabecalho)
                .HasForeignKey(e => e.id_venda_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaComissao>()
                .Property(e => e.valor_venda)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaComissao>()
                .Property(e => e.tipo_contabil)
                .IsFixedLength();

            modelBuilder.Entity<VendaComissao>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaComissao>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .Property(e => e.faturamento_minimo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .Property(e => e.faturamento_maximo)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .Property(e => e.indice_correcao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .Property(e => e.valor_tolerancia)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .Property(e => e.vista_prazo)
                .IsFixedLength();

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.venda_condicoes_pagamento)
                .HasForeignKey(e => e.id_venda_condicoes_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .HasMany(e => e.venda_condicoes_parcelas)
                .WithRequired(e => e.venda_condicoes_pagamento)
                .HasForeignKey(e => e.id_venda_condicoes_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaCondicoesPagamento>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithRequired(e => e.venda_condicoes_pagamento)
                .HasForeignKey(e => e.id_venda_condicoes_pagamento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaCondicoesParcelas>()
                .Property(e => e.taxa)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaDetalhe>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaFrete>()
                .Property(e => e.responsavel)
                .IsFixedLength();

            modelBuilder.Entity<VendaFrete>()
                .Property(e => e.uf_placa)
                .IsFixedLength();

            modelBuilder.Entity<VendaFrete>()
                .Property(e => e.quantidade_volume)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaFrete>()
                .Property(e => e.peso_bruto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaFrete>()
                .Property(e => e.peso_liquido)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.tipo)
                .IsFixedLength();

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.tipo_frete)
                .IsFixedLength();

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.valor_frete)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.taxa_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.valor_comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .HasMany(e => e.venda_cabecalho)
                .WithOptional(e => e.venda_orcamento_cabecalho)
                .HasForeignKey(e => e.id_venda_orcamento_cabecalho);

            modelBuilder.Entity<VendaOrcamentoCabecalho>()
                .HasMany(e => e.venda_orcamento_detalhe)
                .WithRequired(e => e.venda_orcamento_cabecalho)
                .HasForeignKey(e => e.id_venda_orcamento_cabecalho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VendaOrcamentoDetalhe>()
                .Property(e => e.quantidade)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoDetalhe>()
                .Property(e => e.valor_unitario)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoDetalhe>()
                .Property(e => e.valor_subtotal)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoDetalhe>()
                .Property(e => e.taxa_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoDetalhe>()
                .Property(e => e.valor_desconto)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaOrcamentoDetalhe>()
                .Property(e => e.valor_total)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VendaRomaneioEntrega>()
                .Property(e => e.situacao)
                .IsFixedLength();

            modelBuilder.Entity<VendaRomaneioEntrega>()
                .HasMany(e => e.venda_cabecalho)
                .WithOptional(e => e.venda_romaneio_entrega)
                .HasForeignKey(e => e.id_venda_romaneio_entrega);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.comissao)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.meta_vendas)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.gerente)
                .IsFixedLength();

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.taxa_gerente)
                .HasPrecision(18, 6);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.nfe_cabecalho)
                .WithOptional(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.venda_cabecalho)
                .WithRequired(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.venda_comissao)
                .WithRequired(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.venda_orcamento_cabecalho)
                .WithRequired(e => e.vendedor)
                .HasForeignKey(e => e.id_vendedor)
                .WillCascadeOnDelete(false);
        }
    }
}
