namespace ModelEF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextoT2TiERP : DbContext
    {
        public ContextoT2TiERP()
            : base("name=ContextoT2TiERP")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<ADM_MODULO> ADM_MODULO { get; set; }
        public virtual DbSet<ADM_PARAMETRO> ADM_PARAMETRO { get; set; }
        public virtual DbSet<AGENCIA_BANCO> AGENCIA_BANCO { get; set; }
        public virtual DbSet<ALMOXARIFADO> ALMOXARIFADO { get; set; }
        public virtual DbSet<ATIVIDADE_FOR_CLI> ATIVIDADE_FOR_CLI { get; set; }
        public virtual DbSet<AUDITORIA> AUDITORIA { get; set; }
        public virtual DbSet<BANCO> BANCO { get; set; }
        public virtual DbSet<CARGO> CARGO { get; set; }
        public virtual DbSet<CENTRO_RESULTADO> CENTRO_RESULTADO { get; set; }
        public virtual DbSet<CEP> CEP { get; set; }
        public virtual DbSet<CEST> CEST { get; set; }
        public virtual DbSet<CFOP> CFOP { get; set; }
        public virtual DbSet<CHEQUE> CHEQUE { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<CNAE> CNAE { get; set; }
        public virtual DbSet<COLABORADOR> COLABORADOR { get; set; }
        public virtual DbSet<COLABORADOR_RELACIONAMENTO> COLABORADOR_RELACIONAMENTO { get; set; }
        public virtual DbSet<COMISSAO_OBJETIVO> COMISSAO_OBJETIVO { get; set; }
        public virtual DbSet<COMISSAO_PERFIL> COMISSAO_PERFIL { get; set; }
        public virtual DbSet<COMPRA_COTACAO> COMPRA_COTACAO { get; set; }
        public virtual DbSet<COMPRA_COTACAO_DETALHE> COMPRA_COTACAO_DETALHE { get; set; }
        public virtual DbSet<COMPRA_COTACAO_PEDIDO_DETALHE> COMPRA_COTACAO_PEDIDO_DETALHE { get; set; }
        public virtual DbSet<COMPRA_FORNECEDOR_COTACAO> COMPRA_FORNECEDOR_COTACAO { get; set; }
        public virtual DbSet<COMPRA_PEDIDO> COMPRA_PEDIDO { get; set; }
        public virtual DbSet<COMPRA_PEDIDO_DETALHE> COMPRA_PEDIDO_DETALHE { get; set; }
        public virtual DbSet<COMPRA_REQ_COTACAO_DETALHE> COMPRA_REQ_COTACAO_DETALHE { get; set; }
        public virtual DbSet<COMPRA_REQUISICAO> COMPRA_REQUISICAO { get; set; }
        public virtual DbSet<COMPRA_REQUISICAO_DETALHE> COMPRA_REQUISICAO_DETALHE { get; set; }
        public virtual DbSet<COMPRA_TIPO_PEDIDO> COMPRA_TIPO_PEDIDO { get; set; }
        public virtual DbSet<COMPRA_TIPO_REQUISICAO> COMPRA_TIPO_REQUISICAO { get; set; }
        public virtual DbSet<CONTA_CAIXA> CONTA_CAIXA { get; set; }
        public virtual DbSet<CONTADOR> CONTADOR { get; set; }
        public virtual DbSet<CONTRIB_SIND_PATRONAL_CAB> CONTRIB_SIND_PATRONAL_CAB { get; set; }
        public virtual DbSet<CONTRIB_SIND_PATRONAL_DET> CONTRIB_SIND_PATRONAL_DET { get; set; }
        public virtual DbSet<CONVENIO> CONVENIO { get; set; }
        public virtual DbSet<CSOSN_A> CSOSN_A { get; set; }
        public virtual DbSet<CSOSN_B> CSOSN_B { get; set; }
        public virtual DbSet<CST_COFINS> CST_COFINS { get; set; }
        public virtual DbSet<CST_ICMS_A> CST_ICMS_A { get; set; }
        public virtual DbSet<CST_ICMS_B> CST_ICMS_B { get; set; }
        public virtual DbSet<CST_IPI> CST_IPI { get; set; }
        public virtual DbSet<CST_PIS> CST_PIS { get; set; }
        public virtual DbSet<CT_RESULTADO_NT_FINANCEIRA> CT_RESULTADO_NT_FINANCEIRA { get; set; }
        public virtual DbSet<CTE_AEREO> CTE_AEREO { get; set; }
        public virtual DbSet<CTE_AQUAVIARIO> CTE_AQUAVIARIO { get; set; }
        public virtual DbSet<CTE_AQUAVIARIO_BALSA> CTE_AQUAVIARIO_BALSA { get; set; }
        public virtual DbSet<CTE_CABECALHO> CTE_CABECALHO { get; set; }
        public virtual DbSet<CTE_CARGA> CTE_CARGA { get; set; }
        public virtual DbSet<CTE_COMPONENTE> CTE_COMPONENTE { get; set; }
        public virtual DbSet<CTE_CONFIGURACAO> CTE_CONFIGURACAO { get; set; }
        public virtual DbSet<CTE_DESTINATARIO> CTE_DESTINATARIO { get; set; }
        public virtual DbSet<CTE_DOCUMENTO_ANTERIOR> CTE_DOCUMENTO_ANTERIOR { get; set; }
        public virtual DbSet<CTE_DOCUMENTO_ANTERIOR_ID> CTE_DOCUMENTO_ANTERIOR_ID { get; set; }
        public virtual DbSet<CTE_DUPLICATA> CTE_DUPLICATA { get; set; }
        public virtual DbSet<CTE_DUTOVIARIO> CTE_DUTOVIARIO { get; set; }
        public virtual DbSet<CTE_EMITENTE> CTE_EMITENTE { get; set; }
        public virtual DbSet<CTE_EXPEDIDOR> CTE_EXPEDIDOR { get; set; }
        public virtual DbSet<CTE_FATURA> CTE_FATURA { get; set; }
        public virtual DbSet<CTE_FERROVIARIO> CTE_FERROVIARIO { get; set; }
        public virtual DbSet<CTE_FERROVIARIO_FERROVIA> CTE_FERROVIARIO_FERROVIA { get; set; }
        public virtual DbSet<CTE_FERROVIARIO_VAGAO> CTE_FERROVIARIO_VAGAO { get; set; }
        public virtual DbSet<CTE_INF_NF_CARGA_LACRE> CTE_INF_NF_CARGA_LACRE { get; set; }
        public virtual DbSet<CTE_INF_NF_TRANSPORTE_LACRE> CTE_INF_NF_TRANSPORTE_LACRE { get; set; }
        public virtual DbSet<CTE_INFORMACAO_NF_CARGA> CTE_INFORMACAO_NF_CARGA { get; set; }
        public virtual DbSet<CTE_INFORMACAO_NF_OUTROS> CTE_INFORMACAO_NF_OUTROS { get; set; }
        public virtual DbSet<CTE_INFORMACAO_NF_TRANSPORTE> CTE_INFORMACAO_NF_TRANSPORTE { get; set; }
        public virtual DbSet<CTE_LOCAL_COLETA> CTE_LOCAL_COLETA { get; set; }
        public virtual DbSet<CTE_LOCAL_ENTREGA> CTE_LOCAL_ENTREGA { get; set; }
        public virtual DbSet<CTE_MULTIMODAL> CTE_MULTIMODAL { get; set; }
        public virtual DbSet<CTE_PASSAGEM> CTE_PASSAGEM { get; set; }
        public virtual DbSet<CTE_PERIGOSO> CTE_PERIGOSO { get; set; }
        public virtual DbSet<CTE_RECEBEDOR> CTE_RECEBEDOR { get; set; }
        public virtual DbSet<CTE_REMETENTE> CTE_REMETENTE { get; set; }
        public virtual DbSet<CTE_RODOVIARIO> CTE_RODOVIARIO { get; set; }
        public virtual DbSet<CTE_RODOVIARIO_LACRE> CTE_RODOVIARIO_LACRE { get; set; }
        public virtual DbSet<CTE_RODOVIARIO_MOTORISTA> CTE_RODOVIARIO_MOTORISTA { get; set; }
        public virtual DbSet<CTE_RODOVIARIO_OCC> CTE_RODOVIARIO_OCC { get; set; }
        public virtual DbSet<CTE_RODOVIARIO_PEDAGIO> CTE_RODOVIARIO_PEDAGIO { get; set; }
        public virtual DbSet<CTE_RODOVIARIO_VEICULO> CTE_RODOVIARIO_VEICULO { get; set; }
        public virtual DbSet<CTE_SEGURO> CTE_SEGURO { get; set; }
        public virtual DbSet<CTE_TOMADOR> CTE_TOMADOR { get; set; }
        public virtual DbSet<CTE_VEICULO_NOVO> CTE_VEICULO_NOVO { get; set; }
        public virtual DbSet<DAV_CABECALHO> DAV_CABECALHO { get; set; }
        public virtual DbSet<DAV_DETALHE> DAV_DETALHE { get; set; }
        public virtual DbSet<DAV_DETALHE_ALTERACAO> DAV_DETALHE_ALTERACAO { get; set; }
        public virtual DbSet<ECF_ALIQUOTAS> ECF_ALIQUOTAS { get; set; }
        public virtual DbSet<ECF_CAIXA> ECF_CAIXA { get; set; }
        public virtual DbSet<ECF_CONFIGURACAO> ECF_CONFIGURACAO { get; set; }
        public virtual DbSet<ECF_DOCUMENTOS_EMITIDOS> ECF_DOCUMENTOS_EMITIDOS { get; set; }
        public virtual DbSet<ECF_E3> ECF_E3 { get; set; }
        public virtual DbSet<ECF_FECHAMENTO> ECF_FECHAMENTO { get; set; }
        public virtual DbSet<ECF_IMPRESSORA> ECF_IMPRESSORA { get; set; }
        public virtual DbSet<ECF_MOVIMENTO> ECF_MOVIMENTO { get; set; }
        public virtual DbSet<ECF_NOTA_FISCAL_CABECALHO> ECF_NOTA_FISCAL_CABECALHO { get; set; }
        public virtual DbSet<ECF_NOTA_FISCAL_DETALHE> ECF_NOTA_FISCAL_DETALHE { get; set; }
        public virtual DbSet<ECF_POSICAO_COMPONENTES> ECF_POSICAO_COMPONENTES { get; set; }
        public virtual DbSet<ECF_R02> ECF_R02 { get; set; }
        public virtual DbSet<ECF_R03> ECF_R03 { get; set; }
        public virtual DbSet<ECF_R06> ECF_R06 { get; set; }
        public virtual DbSet<ECF_R07> ECF_R07 { get; set; }
        public virtual DbSet<ECF_RECEBIMENTO_NAO_FISCAL> ECF_RECEBIMENTO_NAO_FISCAL { get; set; }
        public virtual DbSet<ECF_RESOLUCAO> ECF_RESOLUCAO { get; set; }
        public virtual DbSet<ECF_SANGRIA> ECF_SANGRIA { get; set; }
        public virtual DbSet<ECF_SINTEGRA_60A> ECF_SINTEGRA_60A { get; set; }
        public virtual DbSet<ECF_SINTEGRA_60M> ECF_SINTEGRA_60M { get; set; }
        public virtual DbSet<ECF_SUPRIMENTO> ECF_SUPRIMENTO { get; set; }
        public virtual DbSet<ECF_TIPO_PAGAMENTO> ECF_TIPO_PAGAMENTO { get; set; }
        public virtual DbSet<ECF_TOTAL_TIPO_PAGAMENTO> ECF_TOTAL_TIPO_PAGAMENTO { get; set; }
        public virtual DbSet<ECF_TURNO> ECF_TURNO { get; set; }
        public virtual DbSet<ECF_VENDA_CABECALHO> ECF_VENDA_CABECALHO { get; set; }
        public virtual DbSet<ECF_VENDA_DETALHE> ECF_VENDA_DETALHE { get; set; }
        public virtual DbSet<EFD_TABELA_4310> EFD_TABELA_4310 { get; set; }
        public virtual DbSet<EFD_TABELA_4313> EFD_TABELA_4313 { get; set; }
        public virtual DbSet<EFD_TABELA_4314> EFD_TABELA_4314 { get; set; }
        public virtual DbSet<EFD_TABELA_4315> EFD_TABELA_4315 { get; set; }
        public virtual DbSet<EFD_TABELA_4316> EFD_TABELA_4316 { get; set; }
        public virtual DbSet<EFD_TABELA_436> EFD_TABELA_436 { get; set; }
        public virtual DbSet<EFD_TABELA_437> EFD_TABELA_437 { get; set; }
        public virtual DbSet<EFD_TABELA_439> EFD_TABELA_439 { get; set; }
        public virtual DbSet<EMPRESA> EMPRESA { get; set; }
        public virtual DbSet<EMPRESA_CNAE> EMPRESA_CNAE { get; set; }
        public virtual DbSet<EMPRESA_CONTATO> EMPRESA_CONTATO { get; set; }
        public virtual DbSet<EMPRESA_ENDERECO> EMPRESA_ENDERECO { get; set; }
        public virtual DbSet<EMPRESA_PESSOA> EMPRESA_PESSOA { get; set; }
        public virtual DbSet<EMPRESA_PRODUTO> EMPRESA_PRODUTO { get; set; }
        public virtual DbSet<EMPRESA_TELEFONE> EMPRESA_TELEFONE { get; set; }
        public virtual DbSet<ESTADO_CIVIL> ESTADO_CIVIL { get; set; }
        public virtual DbSet<ESTOQUE_COR> ESTOQUE_COR { get; set; }
        public virtual DbSet<ESTOQUE_GRADE> ESTOQUE_GRADE { get; set; }
        public virtual DbSet<ESTOQUE_MARCA> ESTOQUE_MARCA { get; set; }
        public virtual DbSet<ESTOQUE_REAJUSTE_CABECALHO> ESTOQUE_REAJUSTE_CABECALHO { get; set; }
        public virtual DbSet<ESTOQUE_REAJUSTE_DETALHE> ESTOQUE_REAJUSTE_DETALHE { get; set; }
        public virtual DbSet<ESTOQUE_SABOR> ESTOQUE_SABOR { get; set; }
        public virtual DbSet<ESTOQUE_TAMANHO> ESTOQUE_TAMANHO { get; set; }
        public virtual DbSet<FERIADOS> FERIADOS { get; set; }
        public virtual DbSet<FICHA_TECNICA> FICHA_TECNICA { get; set; }
        public virtual DbSet<FIN_CHEQUE_EMITIDO> FIN_CHEQUE_EMITIDO { get; set; }
        public virtual DbSet<FIN_CHEQUE_RECEBIDO> FIN_CHEQUE_RECEBIDO { get; set; }
        public virtual DbSet<FIN_CLIENTE_GRUPO_CAB> FIN_CLIENTE_GRUPO_CAB { get; set; }
        public virtual DbSet<FIN_CLIENTE_GRUPO_DET> FIN_CLIENTE_GRUPO_DET { get; set; }
        public virtual DbSet<FIN_COBRANCA> FIN_COBRANCA { get; set; }
        public virtual DbSet<FIN_COBRANCA_PARCELA_RECEBER> FIN_COBRANCA_PARCELA_RECEBER { get; set; }
        public virtual DbSet<FIN_CONFIGURACAO_BOLETO> FIN_CONFIGURACAO_BOLETO { get; set; }
        public virtual DbSet<FIN_DOCUMENTO_ORIGEM> FIN_DOCUMENTO_ORIGEM { get; set; }
        public virtual DbSet<FIN_EXTRATO_CONTA_BANCO> FIN_EXTRATO_CONTA_BANCO { get; set; }
        public virtual DbSet<FIN_FECHAMENTO_CAIXA_BANCO> FIN_FECHAMENTO_CAIXA_BANCO { get; set; }
        public virtual DbSet<FIN_LANCAMENTO_PAGAR> FIN_LANCAMENTO_PAGAR { get; set; }
        public virtual DbSet<FIN_LANCAMENTO_RECEBER> FIN_LANCAMENTO_RECEBER { get; set; }
        public virtual DbSet<FIN_LCTO_PAGAR_NT_FINANCEIRA> FIN_LCTO_PAGAR_NT_FINANCEIRA { get; set; }
        public virtual DbSet<FIN_LCTO_RECEBER_NT_FINANCEIRA> FIN_LCTO_RECEBER_NT_FINANCEIRA { get; set; }
        public virtual DbSet<FIN_PAGAMENTO_FIXO> FIN_PAGAMENTO_FIXO { get; set; }
        public virtual DbSet<FIN_PARCELA_PAGAMENTO> FIN_PARCELA_PAGAMENTO { get; set; }
        public virtual DbSet<FIN_PARCELA_PAGAR> FIN_PARCELA_PAGAR { get; set; }
        public virtual DbSet<FIN_PARCELA_RECEBER> FIN_PARCELA_RECEBER { get; set; }
        public virtual DbSet<FIN_PARCELA_RECEBIMENTO> FIN_PARCELA_RECEBIMENTO { get; set; }
        public virtual DbSet<FIN_STATUS_PARCELA> FIN_STATUS_PARCELA { get; set; }
        public virtual DbSet<FIN_TIPO_PAGAMENTO> FIN_TIPO_PAGAMENTO { get; set; }
        public virtual DbSet<FIN_TIPO_RECEBIMENTO> FIN_TIPO_RECEBIMENTO { get; set; }
        public virtual DbSet<FORNECEDOR> FORNECEDOR { get; set; }
        public virtual DbSet<FORNECEDOR_PRODUTO> FORNECEDOR_PRODUTO { get; set; }
        public virtual DbSet<FUNCAO> FUNCAO { get; set; }
        public virtual DbSet<IBPT> IBPT { get; set; }
        public virtual DbSet<INDICE_ECONOMICO> INDICE_ECONOMICO { get; set; }
        public virtual DbSet<INTEGRACAO_PDV> INTEGRACAO_PDV { get; set; }
        public virtual DbSet<INVENTARIO_CONTAGEM_CAB> INVENTARIO_CONTAGEM_CAB { get; set; }
        public virtual DbSet<INVENTARIO_CONTAGEM_DET> INVENTARIO_CONTAGEM_DET { get; set; }
        public virtual DbSet<LOG_EXPORTACAO> LOG_EXPORTACAO { get; set; }
        public virtual DbSet<LOG_IMPORTACAO> LOG_IMPORTACAO { get; set; }
        public virtual DbSet<LOGSS> LOGSS { get; set; }
        public virtual DbSet<MUNICIPIO> MUNICIPIO { get; set; }
        public virtual DbSet<NATUREZA_FINANCEIRA> NATUREZA_FINANCEIRA { get; set; }
        public virtual DbSet<NCM> NCM { get; set; }
        public virtual DbSet<NFCE_CAIXA> NFCE_CAIXA { get; set; }
        public virtual DbSet<NFCE_CONFIGURACAO> NFCE_CONFIGURACAO { get; set; }
        public virtual DbSet<NFCE_CONFIGURACAO_BALANCA> NFCE_CONFIGURACAO_BALANCA { get; set; }
        public virtual DbSet<NFCE_CONFIGURACAO_LEITOR_SER> NFCE_CONFIGURACAO_LEITOR_SER { get; set; }
        public virtual DbSet<NFCE_FECHAMENTO> NFCE_FECHAMENTO { get; set; }
        public virtual DbSet<NFCE_MOVIMENTO> NFCE_MOVIMENTO { get; set; }
        public virtual DbSet<NFCE_OPERADOR> NFCE_OPERADOR { get; set; }
        public virtual DbSet<NFCE_POSICAO_COMPONENTES> NFCE_POSICAO_COMPONENTES { get; set; }
        public virtual DbSet<NFCE_RESOLUCAO> NFCE_RESOLUCAO { get; set; }
        public virtual DbSet<NFCE_SANGRIA> NFCE_SANGRIA { get; set; }
        public virtual DbSet<NFCE_SUPRIMENTO> NFCE_SUPRIMENTO { get; set; }
        public virtual DbSet<NFCE_TIPO_PAGAMENTO> NFCE_TIPO_PAGAMENTO { get; set; }
        public virtual DbSet<NFCE_TURNO> NFCE_TURNO { get; set; }
        public virtual DbSet<NFE_ACESSO_XML> NFE_ACESSO_XML { get; set; }
        public virtual DbSet<NFE_CABECALHO> NFE_CABECALHO { get; set; }
        public virtual DbSet<NFE_CANA> NFE_CANA { get; set; }
        public virtual DbSet<NFE_CANA_DEDUCOES_SAFRA> NFE_CANA_DEDUCOES_SAFRA { get; set; }
        public virtual DbSet<NFE_CANA_FORNECIMENTO_DIARIO> NFE_CANA_FORNECIMENTO_DIARIO { get; set; }
        public virtual DbSet<NFE_CONFIGURACAO> NFE_CONFIGURACAO { get; set; }
        public virtual DbSet<NFE_CTE_REFERENCIADO> NFE_CTE_REFERENCIADO { get; set; }
        public virtual DbSet<NFE_CUPOM_FISCAL_REFERENCIADO> NFE_CUPOM_FISCAL_REFERENCIADO { get; set; }
        public virtual DbSet<NFE_DECLARACAO_IMPORTACAO> NFE_DECLARACAO_IMPORTACAO { get; set; }
        public virtual DbSet<NFE_DESTINATARIO> NFE_DESTINATARIO { get; set; }
        public virtual DbSet<NFE_DET_ESPECIFICO_ARMAMENTO> NFE_DET_ESPECIFICO_ARMAMENTO { get; set; }
        public virtual DbSet<NFE_DET_ESPECIFICO_COMBUSTIVEL> NFE_DET_ESPECIFICO_COMBUSTIVEL { get; set; }
        public virtual DbSet<NFE_DET_ESPECIFICO_MEDICAMENTO> NFE_DET_ESPECIFICO_MEDICAMENTO { get; set; }
        public virtual DbSet<NFE_DET_ESPECIFICO_VEICULO> NFE_DET_ESPECIFICO_VEICULO { get; set; }
        public virtual DbSet<NFE_DETALHE> NFE_DETALHE { get; set; }
        public virtual DbSet<NFE_DETALHE_IMPOSTO_COFINS> NFE_DETALHE_IMPOSTO_COFINS { get; set; }
        public virtual DbSet<NFE_DETALHE_IMPOSTO_ICMS> NFE_DETALHE_IMPOSTO_ICMS { get; set; }
        public virtual DbSet<NFE_DETALHE_IMPOSTO_II> NFE_DETALHE_IMPOSTO_II { get; set; }
        public virtual DbSet<NFE_DETALHE_IMPOSTO_IPI> NFE_DETALHE_IMPOSTO_IPI { get; set; }
        public virtual DbSet<NFE_DETALHE_IMPOSTO_ISSQN> NFE_DETALHE_IMPOSTO_ISSQN { get; set; }
        public virtual DbSet<NFE_DETALHE_IMPOSTO_PIS> NFE_DETALHE_IMPOSTO_PIS { get; set; }
        public virtual DbSet<NFE_DETALHE_RASTRO> NFE_DETALHE_RASTRO { get; set; }
        public virtual DbSet<NFE_DUPLICATA> NFE_DUPLICATA { get; set; }
        public virtual DbSet<NFE_EMITENTE> NFE_EMITENTE { get; set; }
        public virtual DbSet<NFE_EXPORTACAO> NFE_EXPORTACAO { get; set; }
        public virtual DbSet<NFE_FATURA> NFE_FATURA { get; set; }
        public virtual DbSet<NFE_FORMA_PAGAMENTO> NFE_FORMA_PAGAMENTO { get; set; }
        public virtual DbSet<NFE_IMPORTACAO_DETALHE> NFE_IMPORTACAO_DETALHE { get; set; }
        public virtual DbSet<NFE_LOCAL_ENTREGA> NFE_LOCAL_ENTREGA { get; set; }
        public virtual DbSet<NFE_LOCAL_RETIRADA> NFE_LOCAL_RETIRADA { get; set; }
        public virtual DbSet<NFE_NF_REFERENCIADA> NFE_NF_REFERENCIADA { get; set; }
        public virtual DbSet<NFE_NUMERO> NFE_NUMERO { get; set; }
        public virtual DbSet<NFE_NUMERO_INUTILIZADO> NFE_NUMERO_INUTILIZADO { get; set; }
        public virtual DbSet<NFE_PROCESSO_REFERENCIADO> NFE_PROCESSO_REFERENCIADO { get; set; }
        public virtual DbSet<NFE_PROD_RURAL_REFERENCIADA> NFE_PROD_RURAL_REFERENCIADA { get; set; }
        public virtual DbSet<NFE_REFERENCIADA> NFE_REFERENCIADA { get; set; }
        public virtual DbSet<NFE_TRANSPORTE> NFE_TRANSPORTE { get; set; }
        public virtual DbSet<NFE_TRANSPORTE_REBOQUE> NFE_TRANSPORTE_REBOQUE { get; set; }
        public virtual DbSet<NFE_TRANSPORTE_VOLUME> NFE_TRANSPORTE_VOLUME { get; set; }
        public virtual DbSet<NFE_TRANSPORTE_VOLUME_LACRE> NFE_TRANSPORTE_VOLUME_LACRE { get; set; }
        public virtual DbSet<NIVEL_FORMACAO> NIVEL_FORMACAO { get; set; }
        public virtual DbSet<NOTA_FISCAL_MODELO> NOTA_FISCAL_MODELO { get; set; }
        public virtual DbSet<NOTA_FISCAL_TIPO> NOTA_FISCAL_TIPO { get; set; }
        public virtual DbSet<OPERADORA_CARTAO> OPERADORA_CARTAO { get; set; }
        public virtual DbSet<OPERADORA_PLANO_SAUDE> OPERADORA_PLANO_SAUDE { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<PAPEL> PAPEL { get; set; }
        public virtual DbSet<PAPEL_FUNCAO> PAPEL_FUNCAO { get; set; }
        public virtual DbSet<PESSOA> PESSOA { get; set; }
        public virtual DbSet<PESSOA_ALTERACAO> PESSOA_ALTERACAO { get; set; }
        public virtual DbSet<PESSOA_CONTATO> PESSOA_CONTATO { get; set; }
        public virtual DbSet<PESSOA_ENDERECO> PESSOA_ENDERECO { get; set; }
        public virtual DbSet<PESSOA_FISICA> PESSOA_FISICA { get; set; }
        public virtual DbSet<PESSOA_JURIDICA> PESSOA_JURIDICA { get; set; }
        public virtual DbSet<PESSOA_TELEFONE> PESSOA_TELEFONE { get; set; }
        public virtual DbSet<PLANO_CENTRO_RESULTADO> PLANO_CENTRO_RESULTADO { get; set; }
        public virtual DbSet<PLANO_NATUREZA_FINANCEIRA> PLANO_NATUREZA_FINANCEIRA { get; set; }
        public virtual DbSet<PRE_VENDA_CABECALHO> PRE_VENDA_CABECALHO { get; set; }
        public virtual DbSet<PRE_VENDA_DETALHE> PRE_VENDA_DETALHE { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<PRODUTO_ALTERACAO_ITEM> PRODUTO_ALTERACAO_ITEM { get; set; }
        public virtual DbSet<PRODUTO_CODIGO_ADICIONAL> PRODUTO_CODIGO_ADICIONAL { get; set; }
        public virtual DbSet<PRODUTO_COMBO> PRODUTO_COMBO { get; set; }
        public virtual DbSet<PRODUTO_COMBO_ITEM> PRODUTO_COMBO_ITEM { get; set; }
        public virtual DbSet<PRODUTO_GRUPO> PRODUTO_GRUPO { get; set; }
        public virtual DbSet<PRODUTO_LACRE> PRODUTO_LACRE { get; set; }
        public virtual DbSet<PRODUTO_LACRE_ENTRADA> PRODUTO_LACRE_ENTRADA { get; set; }
        public virtual DbSet<PRODUTO_LOTE> PRODUTO_LOTE { get; set; }
        public virtual DbSet<PRODUTO_MARCA> PRODUTO_MARCA { get; set; }
        public virtual DbSet<PRODUTO_PROMOCAO> PRODUTO_PROMOCAO { get; set; }
        public virtual DbSet<PRODUTO_SUBGRUPO> PRODUTO_SUBGRUPO { get; set; }
        public virtual DbSet<QUADRO_SOCIETARIO> QUADRO_SOCIETARIO { get; set; }
        public virtual DbSet<REGIAO> REGIAO { get; set; }
        public virtual DbSet<REQUISICAO_INTERNA_CABECALHO> REQUISICAO_INTERNA_CABECALHO { get; set; }
        public virtual DbSet<REQUISICAO_INTERNA_DETALHE> REQUISICAO_INTERNA_DETALHE { get; set; }
        public virtual DbSet<SETOR> SETOR { get; set; }
        public virtual DbSet<SINDICATO> SINDICATO { get; set; }
        public virtual DbSet<SITUACAO_COLABORADOR> SITUACAO_COLABORADOR { get; set; }
        public virtual DbSet<SITUACAO_DOCUMENTO> SITUACAO_DOCUMENTO { get; set; }
        public virtual DbSet<SITUACAO_FOR_CLI> SITUACAO_FOR_CLI { get; set; }
        public virtual DbSet<SOCIO> SOCIO { get; set; }
        public virtual DbSet<SOCIO_DEPENDENTE> SOCIO_DEPENDENTE { get; set; }
        public virtual DbSet<SOCIO_PARTICIPACAO_SOCIETARIA> SOCIO_PARTICIPACAO_SOCIETARIA { get; set; }
        public virtual DbSet<TABELA_PRECO> TABELA_PRECO { get; set; }
        public virtual DbSet<TABELA_PRECO_PRODUTO> TABELA_PRECO_PRODUTO { get; set; }
        public virtual DbSet<TALONARIO_CHEQUE> TALONARIO_CHEQUE { get; set; }
        public virtual DbSet<TIPO_ADMISSAO> TIPO_ADMISSAO { get; set; }
        public virtual DbSet<TIPO_COLABORADOR> TIPO_COLABORADOR { get; set; }
        public virtual DbSet<TIPO_ITEM_SPED> TIPO_ITEM_SPED { get; set; }
        public virtual DbSet<TIPO_RECEITA_DIPI> TIPO_RECEITA_DIPI { get; set; }
        public virtual DbSet<TIPO_RELACIONAMENTO> TIPO_RELACIONAMENTO { get; set; }
        public virtual DbSet<TRANSPORTADORA> TRANSPORTADORA { get; set; }
        public virtual DbSet<TRANSPORTADORA_MUNICIPIO> TRANSPORTADORA_MUNICIPIO { get; set; }
        public virtual DbSet<TRIBUT_COFINS_COD_APURACAO> TRIBUT_COFINS_COD_APURACAO { get; set; }
        public virtual DbSet<TRIBUT_CONFIGURA_OF_GT> TRIBUT_CONFIGURA_OF_GT { get; set; }
        public virtual DbSet<TRIBUT_GRUPO_TRIBUTARIO> TRIBUT_GRUPO_TRIBUTARIO { get; set; }
        public virtual DbSet<TRIBUT_ICMS_CUSTOM_CAB> TRIBUT_ICMS_CUSTOM_CAB { get; set; }
        public virtual DbSet<TRIBUT_ICMS_CUSTOM_DET> TRIBUT_ICMS_CUSTOM_DET { get; set; }
        public virtual DbSet<TRIBUT_ICMS_UF> TRIBUT_ICMS_UF { get; set; }
        public virtual DbSet<TRIBUT_IPI_DIPI> TRIBUT_IPI_DIPI { get; set; }
        public virtual DbSet<TRIBUT_ISS> TRIBUT_ISS { get; set; }
        public virtual DbSet<TRIBUT_OPERACAO_FISCAL> TRIBUT_OPERACAO_FISCAL { get; set; }
        public virtual DbSet<TRIBUT_PIS_COD_APURACAO> TRIBUT_PIS_COD_APURACAO { get; set; }
        public virtual DbSet<UF> UF { get; set; }
        public virtual DbSet<UNIDADE_CONVERSAO> UNIDADE_CONVERSAO { get; set; }
        public virtual DbSet<UNIDADE_PRODUTO> UNIDADE_PRODUTO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }
        public virtual DbSet<VENDA_COMISSAO> VENDA_COMISSAO { get; set; }
        public virtual DbSet<VENDA_CONDICOES_PAGAMENTO> VENDA_CONDICOES_PAGAMENTO { get; set; }
        public virtual DbSet<VENDA_CONDICOES_PARCELAS> VENDA_CONDICOES_PARCELAS { get; set; }
        public virtual DbSet<VENDA_DETALHE> VENDA_DETALHE { get; set; }
        public virtual DbSet<VENDA_FRETE> VENDA_FRETE { get; set; }
        public virtual DbSet<VENDA_ORCAMENTO_CABECALHO> VENDA_ORCAMENTO_CABECALHO { get; set; }
        public virtual DbSet<VENDA_ORCAMENTO_DETALHE> VENDA_ORCAMENTO_DETALHE { get; set; }
        public virtual DbSet<VENDA_ROMANEIO_ENTREGA> VENDA_ROMANEIO_ENTREGA { get; set; }
        public virtual DbSet<VENDEDOR> VENDEDOR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADM_MODULO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ADM_MODULO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_MODULO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_MODULO>()
                .Property(e => e.ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.DIGITO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.GERENTE)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<AGENCIA_BANCO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);
            
            modelBuilder.Entity<AGENCIA_BANCO>()
                .HasMany(e => e.CONTA_CAIXA)
                .WithOptional(e => e.AGENCIA_BANCO)
                .HasForeignKey(e => e.ID_AGENCIA_BANCO);
                
            modelBuilder.Entity<ALMOXARIFADO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ALMOXARIFADO>()
                .HasMany(e => e.PRODUTO)
                .WithOptional(e => e.ALMOXARIFADO)
                .HasForeignKey(e => e.ID_ALMOXARIFADO);

            modelBuilder.Entity<ATIVIDADE_FOR_CLI>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ATIVIDADE_FOR_CLI>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ATIVIDADE_FOR_CLI>()
                .HasMany(e => e.CLIENTE)
                .WithRequired(e => e.ATIVIDADE_FOR_CLI)
                .HasForeignKey(e => e.ID_ATIVIDADE_FOR_CLI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ATIVIDADE_FOR_CLI>()
                .HasMany(e => e.FORNECEDOR)
                .WithRequired(e => e.ATIVIDADE_FOR_CLI)
                .HasForeignKey(e => e.ID_ATIVIDADE_FOR_CLI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.HORA_REGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.JANELA_CONTROLLER)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.ACAO)
                .IsUnicode(false);

            modelBuilder.Entity<AUDITORIA>()
                .Property(e => e.CONTEUDO)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<BANCO>()
                .HasMany(e => e.AGENCIA_BANCO)
                .WithRequired(e => e.BANCO)
                .HasForeignKey(e => e.ID_BANCO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.SALARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.CBO_1994)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .Property(e => e.CBO_2002)
                .IsUnicode(false);

            modelBuilder.Entity<CARGO>()
                .HasMany(e => e.COLABORADOR)
                .WithRequired(e => e.CARGO)
                .HasForeignKey(e => e.ID_CARGO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CENTRO_RESULTADO>()
                .Property(e => e.CLASSIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CENTRO_RESULTADO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CENTRO_RESULTADO>()
                .Property(e => e.SOFRE_RATEIRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CENTRO_RESULTADO>()
                .HasMany(e => e.CT_RESULTADO_NT_FINANCEIRA)
                .WithRequired(e => e.CENTRO_RESULTADO)
                .HasForeignKey(e => e.ID_CENTRO_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.CEP1)
                .IsUnicode(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CEP>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CEST>()
                .Property(e => e.CEST1)
                .IsUnicode(false);

            modelBuilder.Entity<CEST>()
                .Property(e => e.NCM_SH)
                .IsUnicode(false);

            modelBuilder.Entity<CEST>()
                .Property(e => e.DESCRICAO_SEGMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CEST>()
                .Property(e => e.DESCRICAO_CEST)
                .IsUnicode(false);

            modelBuilder.Entity<CEST>()
                .Property(e => e.SIGLA_UNIDADE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CEST>()
                .Property(e => e.DESCRICAO_UNIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<CFOP>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CFOP>()
                .Property(e => e.APLICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE>()
                .Property(e => e.STATUS_CHEQUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHEQUE>()
                .HasMany(e => e.FIN_CHEQUE_EMITIDO)
                .WithRequired(e => e.CHEQUE)
                .HasForeignKey(e => e.ID_CHEQUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CONTA_TOMADOR)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.GERA_FINANCEIRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.INDICADOR_PRECO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.PORCENTO_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.FORMA_DESCONTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.LIMITE_CREDITO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.TIPO_FRETE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.BLOQUEADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.FIN_CLIENTE_GRUPO_DET)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.FIN_COBRANCA)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.FIN_LANCAMENTO_RECEBER)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.VENDA_ORCAMENTO_CABECALHO)
                .WithRequired(e => e.CLIENTE)
                .HasForeignKey(e => e.ID_CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CNAE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE>()
                .Property(e => e.DENOMINACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CNAE>()
                .HasMany(e => e.EMPRESA_CNAE)
                .WithRequired(e => e.CNAE)
                .HasForeignKey(e => e.ID_CNAE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.MATRICULA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.FOTO_34)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.FGTS_OPTANTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PAGAMENTO_FORMA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PAGAMENTO_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PAGAMENTO_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PAGAMENTO_AGENCIA_DIGITO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PAGAMENTO_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PAGAMENTO_CONTA_DIGITO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PIS_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PIS_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PIS_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.PIS_AGENCIA_DIGITO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CTPS_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CTPS_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CTPS_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.DESCONTO_PLANO_SAUDE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.SAI_NA_RAIS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CATEGORIA_SEFIP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CODIGO_TURMA_PONTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CAGED_APRENDIZ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CAGED_DEFICIENCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.COLABORADOR_RELACIONAMENTO)
                .WithRequired(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.COMPRA_REQUISICAO)
                .WithRequired(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.ESTOQUE_REAJUSTE_CABECALHO)
                .WithRequired(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.REQUISICAO_INTERNA_CABECALHO)
                .WithRequired(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.VENDA_ROMANEIO_ENTREGA)
                .WithRequired(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COLABORADOR>()
                .HasMany(e => e.VENDEDOR)
                .WithOptional(e => e.COLABORADOR)
                .HasForeignKey(e => e.ID_COLABORADOR);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.REGISTRO_MATRICULA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.REGISTRO_CARTORIO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.REGISTRO_CARTORIO_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.REGISTRO_NUMERO_LIVRO)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.REGISTRO_NUMERO_FOLHA)
                .IsUnicode(false);

            modelBuilder.Entity<COLABORADOR_RELACIONAMENTO>()
                .Property(e => e.SALARIO_FAMILIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.FORMA_PAGAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.TAXA_PAGAMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.VALOR_PAGAMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.VALOR_META)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMISSAO_OBJETIVO>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMISSAO_PERFIL>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_PERFIL>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<COMISSAO_PERFIL>()
                .HasMany(e => e.COMISSAO_OBJETIVO)
                .WithRequired(e => e.COMISSAO_PERFIL)
                .HasForeignKey(e => e.ID_COMISSAO_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMISSAO_PERFIL>()
                .HasMany(e => e.VENDEDOR)
                .WithOptional(e => e.COMISSAO_PERFIL)
                .HasForeignKey(e => e.ID_COMISSAO_PERFIL);

            modelBuilder.Entity<COMPRA_COTACAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_COTACAO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_COTACAO>()
                .HasMany(e => e.COMPRA_FORNECEDOR_COTACAO)
                .WithRequired(e => e.COMPRA_COTACAO)
                .HasForeignKey(e => e.ID_COMPRA_COTACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_COTACAO>()
                .HasMany(e => e.COMPRA_REQ_COTACAO_DETALHE)
                .WithRequired(e => e.COMPRA_COTACAO)
                .HasForeignKey(e => e.ID_COMPRA_COTACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.QUANTIDADE_PEDIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_COTACAO_DETALHE>()
                .HasMany(e => e.COMPRA_COTACAO_PEDIDO_DETALHE)
                .WithRequired(e => e.COMPRA_COTACAO_DETALHE)
                .HasForeignKey(e => e.ID_COMPRA_COTACAO_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_COTACAO_PEDIDO_DETALHE>()
                .Property(e => e.QUANTIDADE_PEDIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .Property(e => e.PRAZO_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .Property(e => e.VENDA_CONDICOES_PAGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .Property(e => e.TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_FORNECEDOR_COTACAO>()
                .HasMany(e => e.COMPRA_COTACAO_DETALHE)
                .WithRequired(e => e.COMPRA_FORNECEDOR_COTACAO)
                .HasForeignKey(e => e.ID_COMPRA_FORNECEDOR_COTACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.LOCAL_COBRANCA)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_TOTAL_PEDIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.TIPO_FRETE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.FORMA_PAGAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.BASE_CALCULO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.BASE_CALCULO_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_TOTAL_PRODUTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_SEGURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_OUTRAS_DESPESAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .Property(e => e.VALOR_TOTAL_NF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .HasMany(e => e.COMPRA_COTACAO_PEDIDO_DETALHE)
                .WithRequired(e => e.COMPRA_PEDIDO)
                .HasForeignKey(e => e.ID_COMPRA_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_PEDIDO>()
                .HasMany(e => e.COMPRA_PEDIDO_DETALHE)
                .WithRequired(e => e.COMPRA_PEDIDO)
                .HasForeignKey(e => e.ID_COMPRA_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.CST_CSOSN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.BASE_CALCULO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.VALOR_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.VALOR_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.ALIQUOTA_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_PEDIDO_DETALHE>()
                .Property(e => e.ALIQUOTA_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_REQ_COTACAO_DETALHE>()
                .Property(e => e.QUANTIDADE_COTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_REQUISICAO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_REQUISICAO>()
                .HasMany(e => e.COMPRA_REQUISICAO_DETALHE)
                .WithRequired(e => e.COMPRA_REQUISICAO)
                .HasForeignKey(e => e.ID_COMPRA_REQUISICAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_REQUISICAO_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_REQUISICAO_DETALHE>()
                .Property(e => e.QUANTIDADE_COTADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<COMPRA_REQUISICAO_DETALHE>()
                .Property(e => e.ITEM_COTADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_REQUISICAO_DETALHE>()
                .HasMany(e => e.COMPRA_REQ_COTACAO_DETALHE)
                .WithRequired(e => e.COMPRA_REQUISICAO_DETALHE)
                .HasForeignKey(e => e.ID_COMPRA_REQUISICAO_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_TIPO_PEDIDO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_TIPO_PEDIDO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_TIPO_PEDIDO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_TIPO_PEDIDO>()
                .HasMany(e => e.COMPRA_PEDIDO)
                .WithRequired(e => e.COMPRA_TIPO_PEDIDO)
                .HasForeignKey(e => e.ID_COMPRA_TIPO_PEDIDO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA_TIPO_REQUISICAO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_TIPO_REQUISICAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_TIPO_REQUISICAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMPRA_TIPO_REQUISICAO>()
                .HasMany(e => e.COMPRA_REQUISICAO)
                .WithRequired(e => e.COMPRA_TIPO_REQUISICAO)
                .HasForeignKey(e => e.ID_COMPRA_TIPO_REQUISICAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.DIGITO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.LIMITE_CREDITO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.TAXA_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.TAXA_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTA_CAIXA>()
                .Property(e => e.DESCONTO_MAXIMO_PERMITIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_CHEQUE_RECEBIDO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_CONFIGURACAO_BOLETO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_EXTRATO_CONTA_BANCO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_FECHAMENTO_CAIXA_BANCO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_PARCELA_PAGAR)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_PARCELA_RECEBER)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_PARCELA_RECEBIMENTO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_PARCELA_PAGAMENTO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.FIN_TIPO_RECEBIMENTO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.OPERADORA_CARTAO)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTA_CAIXA>()
                .HasMany(e => e.TALONARIO_CHEQUE)
                .WithRequired(e => e.CONTA_CAIXA)
                .HasForeignKey(e => e.ID_CONTA_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.INSCRICAO_CRC)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.UF_CRC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.FONE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .Property(e => e.SITE)
                .IsUnicode(false);

            modelBuilder.Entity<CONTADOR>()
                .HasMany(e => e.EMPRESA)
                .WithOptional(e => e.CONTADOR)
                .HasForeignKey(e => e.ID_CONTADOR);

            modelBuilder.Entity<CONTRIB_SIND_PATRONAL_CAB>()
                .Property(e => e.VIGENCIA_ANO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONTRIB_SIND_PATRONAL_CAB>()
                .HasMany(e => e.CONTRIB_SIND_PATRONAL_DET)
                .WithRequired(e => e.CONTRIB_SIND_PATRONAL_CAB)
                .HasForeignKey(e => e.ID_CONTRIB_SIND_PATRONAL_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CONTRIB_SIND_PATRONAL_DET>()
                .Property(e => e.DE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRIB_SIND_PATRONAL_DET>()
                .Property(e => e.ATE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRIB_SIND_PATRONAL_DET>()
                .Property(e => e.PERCENTUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONTRIB_SIND_PATRONAL_DET>()
                .Property(e => e.VALOR_ADICIONAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.SITE)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .Property(e => e.CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<CONVENIO>()
                .HasMany(e => e.CLIENTE)
                .WithOptional(e => e.CONVENIO)
                .HasForeignKey(e => e.ID_CONVENIO);

            modelBuilder.Entity<CSOSN_A>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSOSN_A>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CSOSN_A>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CSOSN_B>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CSOSN_B>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CSOSN_B>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_COFINS>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CST_COFINS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_COFINS>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_ICMS_A>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CST_ICMS_A>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_ICMS_A>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_ICMS_B>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CST_ICMS_B>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_ICMS_B>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_IPI>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CST_IPI>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_IPI>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CST_PIS>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CST_PIS>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CT_RESULTADO_NT_FINANCEIRA>()
                .Property(e => e.PERCENTUAL_RATEIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.ID_EMISSOR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.ID_INTERNA_TOMADOR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.TARIFA_CLASSE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.TARIFA_CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.TARIFA_VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.CARGA_DIMENSAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AEREO>()
                .Property(e => e.CARGA_ESPECIAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO>()
                .Property(e => e.VALOR_PRESTACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_AQUAVIARIO>()
                .Property(e => e.AFRMM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_AQUAVIARIO>()
                .Property(e => e.NUMERO_BOOKING)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO>()
                .Property(e => e.NUMERO_CONTROLE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO>()
                .Property(e => e.ID_NAVIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO>()
                .HasMany(e => e.CTE_AQUAVIARIO_BALSA)
                .WithRequired(e => e.CTE_AQUAVIARIO)
                .HasForeignKey(e => e.ID_CTE_AQUAVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_AQUAVIARIO_BALSA>()
                .Property(e => e.ID_BALSA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO_BALSA>()
                .Property(e => e.DIRECAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO_BALSA>()
                .Property(e => e.PORTO_EMBARQUE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO_BALSA>()
                .Property(e => e.PORTO_TRANSBORDO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO_BALSA>()
                .Property(e => e.PORTO_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_AQUAVIARIO_BALSA>()
                .Property(e => e.IRIN)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CODIGO_NUMERICO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.NATUREZA_OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.MODELO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CHAVE_ACESSO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.DIGITO_CHAVE_ACESSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VERSAO_PROCESSO_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.NOME_MUNICIPIO_ENVIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.UF_ENVIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.MODAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.NOME_MUNICIPIO_INI_PRESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.UF_INI_PRESTACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.NOME_MUNICIPIO_FIM_PRESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.UF_FIM_PRESTACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.RETIRA_DETALHE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.JUSTIFICATIVA_CONTINGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CARAC_ADICIONAL_TRANSPORTE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CARAC_ADICIONAL_SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.FUNCIONARIO_EMISSOR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.FLUXO_ORIGEM)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ENTREGA_HORA_PROGRAMADA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ENTREGA_HORA_INICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ENTREGA_HORA_FINAL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.MUNICIPIO_ORIGEM_CALCULO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.MUNICIPIO_DESTINO_CALCULO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.OBSERVACOES_GERAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_TOTAL_SERVICO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_RECEBER)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.BASE_CALCULO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ALIQUOTA_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.PERCENTUAL_REDUCAO_BC_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_BC_ICMS_ST_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_ST_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ALIQUOTA_ICMS_ST_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_CREDITO_PRESUMIDO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.PERCENTUAL_BC_ICMS_OUTRA_UF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_BC_ICMS_OUTRA_UF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ALIQUOTA_ICMS_OUTRA_UF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_OUTRA_UF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.SIMPLES_NACIONAL_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.INFORMACOES_ADD_FISCO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_TOTAL_CARGA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.PRODUTO_PREDOMINANTE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CARGA_OUTRAS_CARACTERISTICAS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.CHAVE_CTE_SUBSTITUIDO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_BC_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.PERCENTUAL_FPC_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ALIQUOTA_ICMS_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.ALIQUOTA_INTERESTADUAL_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.PERCENTUAL_PARTILHA_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_FPC_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_PARTILHA_UF_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_PARTILHA_UF_INI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .Property(e => e.VALOR_CARGA_AVERBACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_AEREO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_AQUAVIARIO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_CARGA)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_COMPONENTE)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_DESTINATARIO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_DOCUMENTO_ANTERIOR)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_DUPLICATA)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_DUTOVIARIO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_EMITENTE)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_EXPEDIDOR)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_FATURA)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_FERROVIARIO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_INFORMACAO_NF_OUTROS)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_LOCAL_ENTREGA)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_LOCAL_COLETA)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_MULTIMODAL)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_PASSAGEM)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_PERIGOSO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_RECEBEDOR)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_REMETENTE)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_RODOVIARIO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_SEGURO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_TOMADOR)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CABECALHO>()
                .HasMany(e => e.CTE_VEICULO_NOVO)
                .WithRequired(e => e.CTE_CABECALHO)
                .HasForeignKey(e => e.ID_CTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_CARGA>()
                .Property(e => e.CODIGO_UNIDADE_MEDIDA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CARGA>()
                .Property(e => e.TIPO_MEDIDA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CARGA>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_COMPONENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_COMPONENTE>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_CAMINHO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.VERSAO_PROCESSO_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_LOGOMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.SALVAR_XML)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SALVAR_XML)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SCHEMAS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_ARQUIVO_DANFE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SALVAR_PDF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_HOST)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_VISUALIZAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.EMAIL_SERVIDOR_SMTP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.EMAIL_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.EMAIL_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.EMAIL_ASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.EMAIL_AUTENTICA_SSL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_CONFIGURACAO>()
                .Property(e => e.EMAIL_TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DESTINATARIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR>()
                .HasMany(e => e.CTE_DOCUMENTO_ANTERIOR_ID)
                .WithRequired(e => e.CTE_DOCUMENTO_ANTERIOR)
                .HasForeignKey(e => e.ID_CTE_DOCUMENTO_ANTERIOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR_ID>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR_ID>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR_ID>()
                .Property(e => e.SUBSERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR_ID>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DOCUMENTO_ANTERIOR_ID>()
                .Property(e => e.CHAVE_CTE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DUPLICATA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_DUPLICATA>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_DUTOVIARIO>()
                .Property(e => e.VALOR_TARIFA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.IEST)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EMITENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_EXPEDIDOR>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FATURA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FATURA>()
                .Property(e => e.VALOR_ORIGINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_FATURA>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_FATURA>()
                .Property(e => e.VALOR_LIQUIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_FERROVIARIO>()
                .Property(e => e.FLUXO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO>()
                .Property(e => e.ID_TREM)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_FERROVIARIO>()
                .HasMany(e => e.CTE_FERROVIARIO_FERROVIA)
                .WithRequired(e => e.CTE_FERROVIARIO)
                .HasForeignKey(e => e.ID_CTE_FERROVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_FERROVIARIO>()
                .HasMany(e => e.CTE_FERROVIARIO_VAGAO)
                .WithRequired(e => e.CTE_FERROVIARIO)
                .HasForeignKey(e => e.ID_CTE_FERROVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.CODIGO_INTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_FERROVIA>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_VAGAO>()
                .Property(e => e.CAPACIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_FERROVIARIO_VAGAO>()
                .Property(e => e.TIPO_VAGAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_FERROVIARIO_VAGAO>()
                .Property(e => e.PESO_REAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_FERROVIARIO_VAGAO>()
                .Property(e => e.PESO_BC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INF_NF_CARGA_LACRE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INF_NF_CARGA_LACRE>()
                .Property(e => e.QUANTIDADE_RATEADA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INF_NF_TRANSPORTE_LACRE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_CARGA>()
                .Property(e => e.ID_UNIDADE_CARGA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_CARGA>()
                .HasMany(e => e.CTE_INF_NF_CARGA_LACRE)
                .WithRequired(e => e.CTE_INFORMACAO_NF_CARGA)
                .HasForeignKey(e => e.ID_CTE_INFORMACAO_NF_CARGA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.NUMERO_ROMANEIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.NUMERO_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.CHAVE_ACESSO_NFE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.CODIGO_MODELO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.BASE_CALCULO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.VALOR_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.BASE_CALCULO_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.VALOR_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.VALOR_TOTAL_PRODUTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.PESO_TOTAL_KG)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.OUTRO_TIPO_DOC_ORIG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.OUTRO_DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .Property(e => e.OUTRO_VALOR_DOCUMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .HasMany(e => e.CTE_INFORMACAO_NF_CARGA)
                .WithRequired(e => e.CTE_INFORMACAO_NF_OUTROS)
                .HasForeignKey(e => e.ID_CTE_INFORMACAO_NF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_OUTROS>()
                .HasMany(e => e.CTE_INFORMACAO_NF_TRANSPORTE)
                .WithRequired(e => e.CTE_INFORMACAO_NF_OUTROS)
                .HasForeignKey(e => e.ID_CTE_INFORMACAO_NF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_TRANSPORTE>()
                .Property(e => e.ID_UNIDADE_TRANSPORTE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_INFORMACAO_NF_TRANSPORTE>()
                .HasMany(e => e.CTE_INF_NF_TRANSPORTE_LACRE)
                .WithRequired(e => e.CTE_INFORMACAO_NF_TRANSPORTE)
                .HasForeignKey(e => e.ID_CTE_INFORMACAO_NF_TRANSPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_COLETA>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_LOCAL_ENTREGA>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_MULTIMODAL>()
                .Property(e => e.COTM)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PASSAGEM>()
                .Property(e => e.SIGLA_PASSAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PASSAGEM>()
                .Property(e => e.SIGLA_DESTINO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PASSAGEM>()
                .Property(e => e.ROTA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.NUMERO_ONU)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.NOME_APROPRIADO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.CLASSE_RISCO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.GRUPO_EMBALAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.QUANTIDADE_TOTAL_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.QUANTIDADE_TIPO_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_PERIGOSO>()
                .Property(e => e.PONTO_FULGOR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RECEBEDOR>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_REMETENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO>()
                .Property(e => e.RNTRC)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO>()
                .HasMany(e => e.CTE_RODOVIARIO_MOTORISTA)
                .WithRequired(e => e.CTE_RODOVIARIO)
                .HasForeignKey(e => e.ID_CTE_RODOVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_RODOVIARIO>()
                .HasMany(e => e.CTE_RODOVIARIO_LACRE)
                .WithRequired(e => e.CTE_RODOVIARIO)
                .HasForeignKey(e => e.ID_CTE_RODOVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_RODOVIARIO>()
                .HasMany(e => e.CTE_RODOVIARIO_OCC)
                .WithRequired(e => e.CTE_RODOVIARIO)
                .HasForeignKey(e => e.ID_CTE_RODOVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_RODOVIARIO>()
                .HasMany(e => e.CTE_RODOVIARIO_PEDAGIO)
                .WithRequired(e => e.CTE_RODOVIARIO)
                .HasForeignKey(e => e.ID_CTE_RODOVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_RODOVIARIO>()
                .HasMany(e => e.CTE_RODOVIARIO_VEICULO)
                .WithRequired(e => e.CTE_RODOVIARIO)
                .HasForeignKey(e => e.ID_CTE_RODOVIARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTE_RODOVIARIO_LACRE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_MOTORISTA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_MOTORISTA>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_OCC>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_OCC>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_OCC>()
                .Property(e => e.CODIGO_INTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_OCC>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_OCC>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_OCC>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_PEDAGIO>()
                .Property(e => e.CNPJ_FORNECEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_PEDAGIO>()
                .Property(e => e.COMPROVANTE_COMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_PEDAGIO>()
                .Property(e => e.CNPJ_RESPONSAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_PEDAGIO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.CODIGO_INTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.RENAVAM)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.TIPO_PROPRIEDADE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.TIPO_RODADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.TIPO_CARROCERIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PROPRIETARIO_CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PROPRIETARIO_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PROPRIETARIO_RNTRC)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PROPRIETARIO_NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PROPRIETARIO_IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_RODOVIARIO_VEICULO>()
                .Property(e => e.PROPRIETARIO_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_SEGURO>()
                .Property(e => e.SEGURADORA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_SEGURO>()
                .Property(e => e.APOLICE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_SEGURO>()
                .Property(e => e.AVERBACAO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_SEGURO>()
                .Property(e => e.VALOR_CARGA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.IE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_TOMADOR>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_VEICULO_NOVO>()
                .Property(e => e.CHASSI)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_VEICULO_NOVO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_VEICULO_NOVO>()
                .Property(e => e.DESCRICAO_COR)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_VEICULO_NOVO>()
                .Property(e => e.CODIGO_MARCA_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<CTE_VEICULO_NOVO>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<CTE_VEICULO_NOVO>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.NUMERO_DAV)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.NUMERO_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.NOME_DESTINATARIO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.CPF_CNPJ_DESTINATARIO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.HORA_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.TAXA_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.IMPRESSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_CABECALHO>()
                .HasMany(e => e.DAV_DETALHE)
                .WithRequired(e => e.DAV_CABECALHO)
                .HasForeignKey(e => e.ID_DAV_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.NUMERO_DAV)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.CANCELADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.MESCLA_PRODUTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.GTIN_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.NOME_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.UNIDADE_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.TOTALIZADOR_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .Property(e => e.SERVICO_FORMULA)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE>()
                .HasMany(e => e.DAV_DETALHE_ALTERACAO)
                .WithRequired(e => e.DAV_DETALHE)
                .HasForeignKey(e => e.ID_DAV_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAV_DETALHE_ALTERACAO>()
                .Property(e => e.HORA_ALTERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE_ALTERACAO>()
                .Property(e => e.TIPO_ALTERACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAV_DETALHE_ALTERACAO>()
                .Property(e => e.OBJETO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_ALIQUOTAS>()
                .Property(e => e.TOTALIZADOR_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_ALIQUOTAS>()
                .Property(e => e.ECF_ICMS_ST)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_ALIQUOTAS>()
                .Property(e => e.PAF_P_ST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CAIXA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.MENSAGEM_CUPOM)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.PORTA_ECF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.IP_SERVIDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.IP_SITEF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.TIPO_TEF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.TITULO_TELA_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.CAMINHO_IMAGENS_PRODUTOS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.CAMINHO_IMAGENS_MARKETING)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.CAMINHO_IMAGENS_LAYOUT)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.COR_JANELAS_INTERNAS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.MARKETING_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.DESCRICAO_SUPRIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.DESCRICAO_SANGRIA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.PESQUISA_PARTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.CONFIGURACAO_BALANCA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.PARAMETROS_DIVERSOS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.LAUDO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.INDICE_GERENCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_CONFIGURACAO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_DOCUMENTOS_EMITIDOS>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_DOCUMENTOS_EMITIDOS>()
                .Property(e => e.HORA_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_DOCUMENTOS_EMITIDOS>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_DOCUMENTOS_EMITIDOS>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_E3>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_E3>()
                .Property(e => e.MF_ADICIONAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_E3>()
                .Property(e => e.TIPO_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_E3>()
                .Property(e => e.MARCA_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_E3>()
                .Property(e => e.MODELO_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_E3>()
                .Property(e => e.HORA_ESTOQUE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_FECHAMENTO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_FECHAMENTO>()
                .Property(e => e.TIPO_PAGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_FECHAMENTO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_FECHAMENTO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.IDENTIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.VR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MODELO_ACBR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MODELO_DOCUMENTO_FISCAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.VERSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.LE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.LEF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.MFD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.LACRE_NA_MFD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.HORA_INSTALACAO_SB)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.DOCTO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_IMPRESSORA>()
                .Property(e => e.ECF_IMPRESSORA1)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.HORA_ABERTURA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.HORA_FECHAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_SUPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_SANGRIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_NAO_FISCAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_FINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_RECEBIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_TROCO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.TOTAL_CANCELADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.STATUS_MOVIMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_MOVIMENTO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.CPF_CNPJ_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.HORA_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.SUBSERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.TOTAL_PRODUTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.TOTAL_NF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.BASE_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.ICMS_OUTRAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.TAXA_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.ACRESCIMO_ITENS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.DESCONTO_ITENS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.CANCELADA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.TIPO_NOTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_CABECALHO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.BASE_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.ICMS_OUTRAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.ICMS_ISENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.TAXA_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.CANCELADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.CST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.MOVIMENTA_ESTOQUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.ECF_ICMS_ST)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_NOTA_FISCAL_DETALHE>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_POSICAO_COMPONENTES>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_POSICAO_COMPONENTES>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_POSICAO_COMPONENTES>()
                .Property(e => e.TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_POSICAO_COMPONENTES>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.HORA_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.VENDA_BRUTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.GRANDE_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R02>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R03>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R03>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R03>()
                .Property(e => e.TOTALIZADOR_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R03>()
                .Property(e => e.VALOR_ACUMULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_R03>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R03>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R06>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R06>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R06>()
                .Property(e => e.DENOMINACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R06>()
                .Property(e => e.HORA_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R06>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R06>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.MEIO_PAGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.VALOR_PAGAMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.ESTORNO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.VALOR_ESTORNO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_R07>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RECEBIMENTO_NAO_FISCAL>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RECEBIMENTO_NAO_FISCAL>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RECEBIMENTO_NAO_FISCAL>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_RECEBIMENTO_NAO_FISCAL>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.RESOLUCAO_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.IMAGEM_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.IMAGEM_MENU)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.IMAGEM_SUBMENU)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.HOTTRACK_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.ITEM_STYLE_FONT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.ITEM_STYLE_FONT_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.ITEM_SEL_STYLE_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.LABEL_TOTAL_GERAL_FONT_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.ITEM_STYLE_FONT_STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.EDITS_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.EDITS_FONT_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.EDITS_DISABLED_COLOR)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.EDITS_FONT_NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.EDITS_FONT_STYLE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_RESOLUCAO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SANGRIA>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SANGRIA>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_SANGRIA>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60A>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60A>()
                .Property(e => e.SITUACAO_TRIBUTARIA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60A>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_SINTEGRA_60A>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60M>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60M>()
                .Property(e => e.NUMERO_SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60M>()
                .Property(e => e.MODELO_DOCUMENTO_FISCAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SINTEGRA_60M>()
                .Property(e => e.VALOR_VENDA_BRUTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_SINTEGRA_60M>()
                .Property(e => e.VALOR_GRANDE_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_SINTEGRA_60M>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SUPRIMENTO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_SUPRIMENTO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_SUPRIMENTO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.TEF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.IMPRIME_VINCULADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.PERMITE_TROCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.TEF_TIPO_GP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TIPO_PAGAMENTO>()
                .Property(e => e.GERA_PARCELAS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.NSU)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.ESTORNO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.REDE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.CARTAO_DC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TOTAL_TIPO_PAGAMENTO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TURNO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TURNO>()
                .Property(e => e.HORA_INICIO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_TURNO>()
                .Property(e => e.HORA_FIM)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.HORA_VENDA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.VALOR_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.TAXA_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.VALOR_FINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.VALOR_RECEBIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.TROCO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.VALOR_CANCELADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.TOTAL_PRODUTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.TOTAL_DOCUMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.BASE_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.ICMS_OUTRAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.ACRESCIMO_ITENS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.DESCONTO_ITENS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.STATUS_VENDA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.NOME_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.CPF_CNPJ_CLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.CUPOM_CANCELADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_CABECALHO>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.NOME_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.GTIN)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TOTAL_ITEM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.BASE_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TAXA_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TAXA_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TAXA_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TAXA_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TAXA_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.ACRESCIMO_RATEIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.DESCONTO_RATEIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.TOTALIZADOR_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.CST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.CANCELADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.MOVIMENTA_ESTOQUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.ECF_ICMS_ST)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.LOGSS)
                .IsUnicode(false);

            modelBuilder.Entity<ECF_VENDA_DETALHE>()
                .Property(e => e.HORA_SINCRONIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4310>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4310>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4313>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4313>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4314>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4314>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4315>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4315>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4316>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_4316>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_436>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_437>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_437>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_439>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<EFD_TABELA_439>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.NOME_FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.INSCRICAO_ESTADUAL_ST)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.INSCRICAO_MUNICIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.INSCRICAO_JUNTA_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.SUFRAMA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.IMAGEM_LOGOTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CRT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.TIPO_REGIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.ALIQUOTA_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.ALIQUOTA_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.ALIQUOTA_SAT)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CEI)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CODIGO_CNAE_PRINCIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.TIPO_CONTROLE_ESTOQUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.ADM_PARAMETRO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.ALMOXARIFADO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.CARGO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.COMISSAO_PERFIL)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.COMPRA_TIPO_REQUISICAO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.CONTA_CAIXA)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.CONVENIO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.CTE_CABECALHO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.CTE_CONFIGURACAO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.DAV_CABECALHO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA1)
                .WithOptional(e => e.EMPRESA2)
                .HasForeignKey(e => e.ID_EMPRESA);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA_CNAE)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA_CONTATO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA_ENDERECO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA_PRODUTO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA_PESSOA)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.EMPRESA_TELEFONE)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.FIN_CONFIGURACAO_BOLETO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.FIN_DOCUMENTO_ORIGEM)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.FIN_STATUS_PARCELA)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.FIN_TIPO_RECEBIMENTO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.FIN_TIPO_PAGAMENTO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.INVENTARIO_CONTAGEM_CAB)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NFCE_CONFIGURACAO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NFCE_MOVIMENTO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NFE_CONFIGURACAO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NFE_NUMERO_INUTILIZADO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NFE_NUMERO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.NOTA_FISCAL_TIPO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.PLANO_CENTRO_RESULTADO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.PLANO_NATUREZA_FINANCEIRA)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.PRE_VENDA_CABECALHO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.QUADRO_SOCIETARIO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.SETOR)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.TALONARIO_CHEQUE)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.TRIBUT_GRUPO_TRIBUTARIO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.TRIBUT_ICMS_CUSTOM_CAB)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.TRIBUT_OPERACAO_FISCAL)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.VENDA_CONDICOES_PAGAMENTO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA>()
                .HasMany(e => e.VENDA_ORCAMENTO_CABECALHO)
                .WithRequired(e => e.EMPRESA)
                .HasForeignKey(e => e.ID_EMPRESA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EMPRESA_CNAE>()
                .Property(e => e.PRINCIPAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CNAE>()
                .Property(e => e.RAMO_ATIVIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CNAE>()
                .Property(e => e.OBJETO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CONTATO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CONTATO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CONTATO>()
                .Property(e => e.FONE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CONTATO>()
                .Property(e => e.FONE_RESIDENCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_CONTATO>()
                .Property(e => e.FONE_CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.FONE)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.PRINCIPAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.ENTREGA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.COBRANCA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_ENDERECO>()
                .Property(e => e.CORRESPONDENCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_PESSOA>()
                .Property(e => e.RESPONSAVEL_LEGAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_PRODUTO>()
                .Property(e => e.QUANTIDADE_ESTOQUE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<EMPRESA_PRODUTO>()
                .HasMany(e => e.ESTOQUE_GRADE)
                .WithOptional(e => e.EMPRESA_PRODUTO)
                .HasForeignKey(e => e.ID_EMPRESA_PRODUTO);

            modelBuilder.Entity<EMPRESA_TELEFONE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA_TELEFONE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO_CIVIL>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO_CIVIL>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTADO_CIVIL>()
                .HasMany(e => e.PESSOA_FISICA)
                .WithRequired(e => e.ESTADO_CIVIL)
                .HasForeignKey(e => e.ID_ESTADO_CIVIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTOQUE_COR>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_COR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_COR>()
                .HasMany(e => e.ESTOQUE_GRADE)
                .WithRequired(e => e.ESTOQUE_COR)
                .HasForeignKey(e => e.ID_ESTOQUE_COR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTOQUE_GRADE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_GRADE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_MARCA>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_MARCA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_MARCA>()
                .HasMany(e => e.ESTOQUE_GRADE)
                .WithRequired(e => e.ESTOQUE_MARCA)
                .HasForeignKey(e => e.ID_ESTOQUE_MARCA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_CABECALHO>()
                .Property(e => e.PORCENTAGEM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_CABECALHO>()
                .Property(e => e.TIPO_REAJUSTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_CABECALHO>()
                .Property(e => e.JUSTIFICATIVA)
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_CABECALHO>()
                .Property(e => e.QUANTIDADE_FIXA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_CABECALHO>()
                .Property(e => e.CAMPO_REAJUSTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_CABECALHO>()
                .HasMany(e => e.ESTOQUE_REAJUSTE_DETALHE)
                .WithRequired(e => e.ESTOQUE_REAJUSTE_CABECALHO)
                .HasForeignKey(e => e.ID_ESTOQUE_REAJUSTE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_DETALHE>()
                .Property(e => e.VALOR_ORIGINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_DETALHE>()
                .Property(e => e.VALOR_REAJUSTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_DETALHE>()
                .Property(e => e.QUANTIDADE_ORIGINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_REAJUSTE_DETALHE>()
                .Property(e => e.QUANTIDADE_REAJUSTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_SABOR>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_SABOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_SABOR>()
                .HasMany(e => e.ESTOQUE_GRADE)
                .WithRequired(e => e.ESTOQUE_SABOR)
                .HasForeignKey(e => e.ID_ESTOQUE_SABOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ESTOQUE_TAMANHO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_TAMANHO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<ESTOQUE_TAMANHO>()
                .Property(e => e.ALTURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_TAMANHO>()
                .Property(e => e.COMPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_TAMANHO>()
                .Property(e => e.LARGURA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ESTOQUE_TAMANHO>()
                .HasMany(e => e.ESTOQUE_GRADE)
                .WithRequired(e => e.ESTOQUE_TAMANHO)
                .HasForeignKey(e => e.ID_ESTOQUE_TAMANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FERIADOS>()
                .Property(e => e.ANO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FERIADOS>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<FERIADOS>()
                .Property(e => e.ABRANGENCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FERIADOS>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FERIADOS>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_TECNICA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_TECNICA>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_EMITIDO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_EMITIDO>()
                .Property(e => e.NOMINAL_A)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CHEQUE_EMITIDO>()
                .HasMany(e => e.FIN_PARCELA_PAGAMENTO)
                .WithOptional(e => e.FIN_CHEQUE_EMITIDO)
                .HasForeignKey(e => e.ID_FIN_CHEQUE_EMITIDO);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.CODIGO_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.CODIGO_AGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.CUSTODIA_TARIFA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.CUSTODIA_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.DESCONTO_TARIFA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.DESCONTO_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .Property(e => e.VALOR_RECEBIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CHEQUE_RECEBIDO>()
                .HasMany(e => e.FIN_PARCELA_RECEBIMENTO)
                .WithOptional(e => e.FIN_CHEQUE_RECEBIDO)
                .HasForeignKey(e => e.ID_FIN_CHEQUE_RECEBIDO);

            modelBuilder.Entity<FIN_CLIENTE_GRUPO_CAB>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CLIENTE_GRUPO_CAB>()
                .HasMany(e => e.FIN_CLIENTE_GRUPO_DET)
                .WithRequired(e => e.FIN_CLIENTE_GRUPO_CAB)
                .HasForeignKey(e => e.ID_FIN_CLIENTE_GRUPO_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_CLIENTE_GRUPO_DET>()
                .Property(e => e.DIA_LANCAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CLIENTE_GRUPO_DET>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CLIENTE_GRUPO_DET>()
                .Property(e => e.GERA_BOLETO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_COBRANCA>()
                .Property(e => e.HORA_CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_COBRANCA>()
                .Property(e => e.TELEFONE_CONTATO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_COBRANCA>()
                .Property(e => e.TOTAL_RECEBER_NA_DATA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA>()
                .HasMany(e => e.FIN_COBRANCA_PARCELA_RECEBER)
                .WithRequired(e => e.FIN_COBRANCA)
                .HasForeignKey(e => e.ID_FIN_COBRANCA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_PARCELA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_JURO_SIMULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_MULTA_SIMULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_RECEBER_SIMULADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_JURO_ACORDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_MULTA_ACORDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_COBRANCA_PARCELA_RECEBER>()
                .Property(e => e.VALOR_RECEBER_ACORDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.INSTRUCAO01)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.INSTRUCAO02)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CAMINHO_ARQUIVO_REMESSA)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CAMINHO_ARQUIVO_RETORNO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CAMINHO_ARQUIVO_LOGOTIPO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CAMINHO_ARQUIVO_PDF)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.MENSAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.LOCAL_PAGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.LAYOUT_REMESSA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.ACEITE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.ESPECIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CARTEIRA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CODIGO_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.CODIGO_CEDENTE)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.TAXA_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.TAXA_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_CONFIGURACAO_BOLETO>()
                .Property(e => e.NOSSO_NUMERO_ANTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_DOCUMENTO_ORIGEM>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_DOCUMENTO_ORIGEM>()
                .Property(e => e.SIGLA_DOCUMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_DOCUMENTO_ORIGEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_DOCUMENTO_ORIGEM>()
                .HasMany(e => e.FIN_LANCAMENTO_PAGAR)
                .WithRequired(e => e.FIN_DOCUMENTO_ORIGEM)
                .HasForeignKey(e => e.ID_FIN_DOCUMENTO_ORIGEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_DOCUMENTO_ORIGEM>()
                .HasMany(e => e.FIN_LANCAMENTO_RECEBER)
                .WithRequired(e => e.FIN_DOCUMENTO_ORIGEM)
                .HasForeignKey(e => e.ID_FIN_DOCUMENTO_ORIGEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_DOCUMENTO_ORIGEM>()
                .HasMany(e => e.FIN_PAGAMENTO_FIXO)
                .WithRequired(e => e.FIN_DOCUMENTO_ORIGEM)
                .HasForeignKey(e => e.ID_FIN_DOCUMENTO_ORIGEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.MES_ANO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.MES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.ANO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.HISTORICO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.CONCILIADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_EXTRATO_CONTA_BANCO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.MES_ANO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.MES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.ANO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.SALDO_ANTERIOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.RECEBIMENTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.PAGAMENTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.SALDO_CONTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.CHEQUE_NAO_COMPENSADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_FECHAMENTO_CAIXA_BANCO>()
                .Property(e => e.SALDO_DISPONIVEL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.PAGAMENTO_COMPARTILHADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.VALOR_A_PAGAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.IMAGEM_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.CODIGO_MODULO_LCTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .Property(e => e.HASH_MODULO_LCTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .HasMany(e => e.FIN_LCTO_PAGAR_NT_FINANCEIRA)
                .WithRequired(e => e.FIN_LANCAMENTO_PAGAR)
                .HasForeignKey(e => e.ID_FIN_LANCAMENTO_PAGAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LANCAMENTO_PAGAR>()
                .HasMany(e => e.FIN_PARCELA_PAGAR)
                .WithRequired(e => e.FIN_LANCAMENTO_PAGAR)
                .HasForeignKey(e => e.ID_FIN_LANCAMENTO_PAGAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.VALOR_DESCONTO_CONVENIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.VALOR_A_RECEBER)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.TAXA_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.VALOR_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.CODIGO_MODULO_LCTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .Property(e => e.HASH_MODULO_LCTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .HasMany(e => e.FIN_LCTO_RECEBER_NT_FINANCEIRA)
                .WithRequired(e => e.FIN_LANCAMENTO_RECEBER)
                .HasForeignKey(e => e.ID_FIN_LANCAMENTO_RECEBER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LANCAMENTO_RECEBER>()
                .HasMany(e => e.FIN_PARCELA_RECEBER)
                .WithRequired(e => e.FIN_LANCAMENTO_RECEBER)
                .HasForeignKey(e => e.ID_FIN_LANCAMENTO_RECEBER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_LCTO_PAGAR_NT_FINANCEIRA>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LCTO_PAGAR_NT_FINANCEIRA>()
                .Property(e => e.PERCENTUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LCTO_RECEBER_NT_FINANCEIRA>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_LCTO_RECEBER_NT_FINANCEIRA>()
                .Property(e => e.PERCENTUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PAGAMENTO_FIXO>()
                .Property(e => e.PAGAMENTO_COMPARTILHADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PAGAMENTO_FIXO>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PAGAMENTO_FIXO>()
                .Property(e => e.VALOR_A_PAGAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PAGAMENTO_FIXO>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PAGAMENTO_FIXO>()
                .Property(e => e.IMAGEM_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.TAXA_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.TAXA_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.VALOR_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.VALOR_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.VALOR_PAGO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAMENTO>()
                .Property(e => e.HISTORICO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.SOFRE_RETENCAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.TAXA_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.TAXA_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.VALOR_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.VALOR_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_PAGAR>()
                .HasMany(e => e.FIN_PARCELA_PAGAMENTO)
                .WithRequired(e => e.FIN_PARCELA_PAGAR)
                .HasForeignKey(e => e.ID_FIN_PARCELA_PAGAR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.TAXA_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.TAXA_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.VALOR_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.VALOR_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.EMITIU_BOLETO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .Property(e => e.BOLETO_NOSSO_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_PARCELA_RECEBER>()
                .HasMany(e => e.FIN_PARCELA_RECEBIMENTO)
                .WithRequired(e => e.FIN_PARCELA_RECEBER)
                .HasForeignKey(e => e.ID_FIN_PARCELA_RECEBER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.TAXA_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.TAXA_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.VALOR_JURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.VALOR_MULTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.VALOR_RECEBIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FIN_PARCELA_RECEBIMENTO>()
                .Property(e => e.HISTORICO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_STATUS_PARCELA>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_STATUS_PARCELA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_STATUS_PARCELA>()
                .Property(e => e.PROCEDIMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_STATUS_PARCELA>()
                .HasMany(e => e.FIN_PARCELA_PAGAR)
                .WithRequired(e => e.FIN_STATUS_PARCELA)
                .HasForeignKey(e => e.ID_FIN_STATUS_PARCELA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_STATUS_PARCELA>()
                .HasMany(e => e.FIN_PARCELA_RECEBER)
                .WithRequired(e => e.FIN_STATUS_PARCELA)
                .HasForeignKey(e => e.ID_FIN_STATUS_PARCELA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_TIPO_PAGAMENTO>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TIPO_PAGAMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TIPO_PAGAMENTO>()
                .HasMany(e => e.FIN_PARCELA_PAGAMENTO)
                .WithRequired(e => e.FIN_TIPO_PAGAMENTO)
                .HasForeignKey(e => e.ID_FIN_TIPO_PAGAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_TIPO_RECEBIMENTO>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TIPO_RECEBIMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TIPO_RECEBIMENTO>()
                .HasMany(e => e.FIN_PARCELA_RECEBIMENTO)
                .WithRequired(e => e.FIN_TIPO_RECEBIMENTO)
                .HasForeignKey(e => e.ID_FIN_TIPO_RECEBIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FIN_TIPO_RECEBIMENTO>()
                .HasMany(e => e.VENDA_CONDICOES_PAGAMENTO)
                .WithRequired(e => e.FIN_TIPO_RECEBIMENTO)
                .HasForeignKey(e => e.ID_FIN_TIPO_RECEBIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.OPTANTE_SIMPLES_NACIONAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.LOCALIZACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.SOFRE_RETENCAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.CHEQUE_NOMINAL_A)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.CONTA_REMETENTE)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.GERA_FATURAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR>()
                .HasMany(e => e.COMPRA_FORNECEDOR_COTACAO)
                .WithRequired(e => e.FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORNECEDOR>()
                .HasMany(e => e.COMPRA_PEDIDO)
                .WithRequired(e => e.FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORNECEDOR>()
                .HasMany(e => e.FIN_LANCAMENTO_PAGAR)
                .WithRequired(e => e.FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORNECEDOR>()
                .HasMany(e => e.FIN_PAGAMENTO_FIXO)
                .WithRequired(e => e.FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORNECEDOR>()
                .HasMany(e => e.FORNECEDOR_PRODUTO)
                .WithRequired(e => e.FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FORNECEDOR>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.FORNECEDOR)
                .HasForeignKey(e => e.ID_FORNECEDOR);

            modelBuilder.Entity<FORNECEDOR_PRODUTO>()
                .Property(e => e.CODIGO_FORNECEDOR_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<FORNECEDOR_PRODUTO>()
                .Property(e => e.PRECO_ULTIMA_COMPRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FORNECEDOR_PRODUTO>()
                .Property(e => e.LOTE_MINIMO_COMPRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FORNECEDOR_PRODUTO>()
                .Property(e => e.MENOR_EMBALAGEM_COMPRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FORNECEDOR_PRODUTO>()
                .Property(e => e.CUSTO_ULTIMA_COMPRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<FUNCAO>()
                .Property(e => e.DESCRICAO_MENU)
                .IsUnicode(false);

            modelBuilder.Entity<FUNCAO>()
                .Property(e => e.IMAGEM_MENU)
                .IsUnicode(false);

            modelBuilder.Entity<FUNCAO>()
                .Property(e => e.METODO)
                .IsUnicode(false);

            modelBuilder.Entity<FUNCAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<FUNCAO>()
                .Property(e => e.FORMULARIO)
                .IsUnicode(false);

            modelBuilder.Entity<FUNCAO>()
                .HasMany(e => e.PAPEL_FUNCAO)
                .WithRequired(e => e.FUNCAO)
                .HasForeignKey(e => e.ID_FUNCAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.NCM)
                .IsUnicode(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.EX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.NACIONAL_FEDERAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.IMPORTADOS_FEDERAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.ESTADUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.MUNICIPAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.VERSAO)
                .IsUnicode(false);

            modelBuilder.Entity<IBPT>()
                .Property(e => e.FONTE)
                .IsUnicode(false);

            modelBuilder.Entity<INDICE_ECONOMICO>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<INDICE_ECONOMICO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<INDICE_ECONOMICO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<INTEGRACAO_PDV>()
                .Property(e => e.IDENTIFICA)
                .IsUnicode(false);

            modelBuilder.Entity<INTEGRACAO_PDV>()
                .Property(e => e.HORA_INTEGRACAO)
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_CAB>()
                .Property(e => e.ESTOQUE_ATUALIZADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_CAB>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_CAB>()
                .HasMany(e => e.INVENTARIO_CONTAGEM_DET)
                .WithRequired(e => e.INVENTARIO_CONTAGEM_CAB)
                .HasForeignKey(e => e.ID_INVENTARIO_CONTAGEM_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.CONTAGEM01)
                .HasPrecision(18, 6);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.CONTAGEM02)
                .HasPrecision(18, 6);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.CONTAGEM03)
                .HasPrecision(18, 6);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.FECHADO_CONTAGEM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.QUANTIDADE_SISTEMA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.ACURACIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<INVENTARIO_CONTAGEM_DET>()
                .Property(e => e.DIVERGENCIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<LOG_EXPORTACAO>()
                .Property(e => e.HORA_IMPORTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_EXPORTACAO>()
                .Property(e => e.ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_EXPORTACAO>()
                .Property(e => e.REGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_IMPORTACAO>()
                .Property(e => e.HORA_IMPORTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_IMPORTACAO>()
                .Property(e => e.ERRO)
                .IsUnicode(false);

            modelBuilder.Entity<LOG_IMPORTACAO>()
                .Property(e => e.REGISTRO)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIO>()
                .Property(e => e.UF_SIGLA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUNICIPIO>()
                .HasMany(e => e.TRANSPORTADORA_MUNICIPIO)
                .WithRequired(e => e.MUNICIPIO)
                .HasForeignKey(e => e.ID_MUNICIPIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .Property(e => e.CLASSIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .Property(e => e.APLICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .Property(e => e.APARECE_A_PAGAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .Property(e => e.APARECE_A_RECEBER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .HasMany(e => e.CT_RESULTADO_NT_FINANCEIRA)
                .WithRequired(e => e.NATUREZA_FINANCEIRA)
                .HasForeignKey(e => e.ID_NATUREZA_FINANCEIRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .HasMany(e => e.FIN_LCTO_PAGAR_NT_FINANCEIRA)
                .WithRequired(e => e.NATUREZA_FINANCEIRA)
                .HasForeignKey(e => e.ID_NATUREZA_FINANCEIRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NATUREZA_FINANCEIRA>()
                .HasMany(e => e.FIN_LCTO_RECEBER_NT_FINANCEIRA)
                .WithRequired(e => e.NATUREZA_FINANCEIRA)
                .HasForeignKey(e => e.ID_NATUREZA_FINANCEIRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NCM>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<NCM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NCM>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CAIXA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CAIXA>()
                .HasMany(e => e.NFCE_CONFIGURACAO)
                .WithRequired(e => e.NFCE_CAIXA)
                .HasForeignKey(e => e.ID_NFCE_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_CAIXA>()
                .HasMany(e => e.NFCE_MOVIMENTO)
                .WithRequired(e => e.NFCE_CAIXA)
                .HasForeignKey(e => e.ID_NFCE_CAIXA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.MENSAGEM_CUPOM)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.TITULO_TELA_CAIXA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_IMAGENS_PRODUTOS)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_IMAGENS_MARKETING)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_IMAGENS_LAYOUT)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.COR_JANELAS_INTERNAS)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.MARKETING_ATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.IMPRIME_PARCELA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CODIGO_CSC)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.ID_TOKEN_CSC)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_CAMINHO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.VERSAO_PROCESSO_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_LOGOMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.SALVAR_XML)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SALVAR_XML)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SCHEMAS)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_ARQUIVO_DANFE)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SALVAR_PDF)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_HOST)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_VISUALIZAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.EMAIL_SERVIDOR_SMTP)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.EMAIL_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.EMAIL_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.EMAIL_ASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.EMAIL_AUTENTICA_SSL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .Property(e => e.EMAIL_TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .HasMany(e => e.NFCE_CONFIGURACAO_LEITOR_SER)
                .WithRequired(e => e.NFCE_CONFIGURACAO)
                .HasForeignKey(e => e.ID_NFCE_CONFIGURACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO>()
                .HasMany(e => e.NFCE_CONFIGURACAO_BALANCA)
                .WithRequired(e => e.NFCE_CONFIGURACAO)
                .HasForeignKey(e => e.ID_NFCE_CONFIGURACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_BALANCA>()
                .Property(e => e.IDENTIFICADOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_BALANCA>()
                .Property(e => e.PORTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_BALANCA>()
                .Property(e => e.TIPO_CONFIGURACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.USA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.PORTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.USAR_FILA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.HARD_FLOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.SOFT_FLOW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.SUFIXO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_CONFIGURACAO_LEITOR_SER>()
                .Property(e => e.EXCLUIR_SUFIXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_FECHAMENTO>()
                .Property(e => e.TIPO_PAGAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_FECHAMENTO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.HORA_ABERTURA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.HORA_FECHAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_SUPRIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_SANGRIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_NAO_FISCAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_FINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_RECEBIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_TROCO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.TOTAL_CANCELADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .Property(e => e.STATUS_MOVIMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .HasMany(e => e.NFCE_FECHAMENTO)
                .WithRequired(e => e.NFCE_MOVIMENTO)
                .HasForeignKey(e => e.ID_NFCE_MOVIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .HasMany(e => e.NFCE_SANGRIA)
                .WithRequired(e => e.NFCE_MOVIMENTO)
                .HasForeignKey(e => e.ID_NFCE_MOVIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .HasMany(e => e.NFCE_SUPRIMENTO)
                .WithRequired(e => e.NFCE_MOVIMENTO)
                .HasForeignKey(e => e.ID_NFCE_MOVIMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_MOVIMENTO>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.NFCE_MOVIMENTO)
                .HasForeignKey(e => e.ID_NFCE_MOVIMENTO);

            modelBuilder.Entity<NFCE_OPERADOR>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_OPERADOR>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_OPERADOR>()
                .Property(e => e.NIVEL_AUTORIZACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_OPERADOR>()
                .HasMany(e => e.NFCE_MOVIMENTO)
                .WithRequired(e => e.NFCE_OPERADOR)
                .HasForeignKey(e => e.ID_NFCE_OPERADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_POSICAO_COMPONENTES>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_POSICAO_COMPONENTES>()
                .Property(e => e.TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_RESOLUCAO>()
                .Property(e => e.RESOLUCAO_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_RESOLUCAO>()
                .Property(e => e.IMAGEM_TELA)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_RESOLUCAO>()
                .Property(e => e.IMAGEM_MENU)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_RESOLUCAO>()
                .Property(e => e.IMAGEM_SUBMENU)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_RESOLUCAO>()
                .HasMany(e => e.NFCE_CONFIGURACAO)
                .WithRequired(e => e.NFCE_RESOLUCAO)
                .HasForeignKey(e => e.ID_NFCE_RESOLUCAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_RESOLUCAO>()
                .HasMany(e => e.NFCE_POSICAO_COMPONENTES)
                .WithRequired(e => e.NFCE_RESOLUCAO)
                .HasForeignKey(e => e.ID_NFCE_RESOLUCAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_SANGRIA>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_SANGRIA>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_SUPRIMENTO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFCE_SUPRIMENTO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TIPO_PAGAMENTO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TIPO_PAGAMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TIPO_PAGAMENTO>()
                .Property(e => e.PERMITE_TROCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TIPO_PAGAMENTO>()
                .Property(e => e.GERA_PARCELAS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TIPO_PAGAMENTO>()
                .HasMany(e => e.NFE_FORMA_PAGAMENTO)
                .WithRequired(e => e.NFCE_TIPO_PAGAMENTO)
                .HasForeignKey(e => e.ID_NFCE_TIPO_PAGAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFCE_TURNO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TURNO>()
                .Property(e => e.HORA_INICIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TURNO>()
                .Property(e => e.HORA_FIM)
                .IsUnicode(false);

            modelBuilder.Entity<NFCE_TURNO>()
                .HasMany(e => e.NFCE_MOVIMENTO)
                .WithRequired(e => e.NFCE_TURNO)
                .HasForeignKey(e => e.ID_NFCE_TURNO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_ACESSO_XML>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_ACESSO_XML>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.CODIGO_NUMERICO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.NATUREZA_OPERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.CODIGO_MODELO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.CHAVE_ACESSO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.DIGITO_CHAVE_ACESSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VERSAO_PROCESSO_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.JUSTIFICATIVA_CONTINGENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.BASE_CALCULO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_DESONERADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.BASE_CALCULO_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_TOTAL_PRODUTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_SEGURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_IMPOSTO_IMPORTACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_DESPESAS_ACESSORIAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_SERVICOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.BASE_CALCULO_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_PIS_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_COFINS_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_DEDUCAO_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.OUTRAS_RETENCOES_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.DESCONTO_INCONDICIONADO_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.DESCONTO_CONDICIONADO_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.TOTAL_RETENCAO_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_RETIDO_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_RETIDO_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_RETIDO_CSLL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.BASE_CALCULO_IRRF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_RETIDO_IRRF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.BASE_CALCULO_PREVIDENCIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_RETIDO_PREVIDENCIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.TROCO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.COMEX_UF_EMBARQUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.COMEX_LOCAL_EMBARQUE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.COMEX_LOCAL_DESPACHO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.COMPRA_NOTA_EMPENHO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.COMPRA_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.COMPRA_CONTRATO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.INFORMACOES_ADD_FISCO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.INFORMACOES_ADD_CONTRIBUINTE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.INDICADOR_PRESENCA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_FPC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_FPC_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_FPC_ST_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_IPI_DEVOLVIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VERSAO_APLICATIVO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.NUMERO_PROTOCOLO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.DIGEST_VALUE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.CODIGO_STATUS_RESPOSTA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.DESCRICAO_MOTIVO_RESPOSTA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.JUSTIFICATIVA_CANCELAMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_FPC_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_INTER_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.VALOR_ICMS_INTER_UF_REMETENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.QRCODE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .Property(e => e.URL_CHAVE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_ACESSO_XML)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_CANA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_CTE_REFERENCIADO)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_CUPOM_FISCAL_REFERENCIADO)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_DESTINATARIO)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_DETALHE)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_DUPLICATA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_EMITENTE)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_FATURA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_FORMA_PAGAMENTO)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_LOCAL_RETIRADA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_LOCAL_ENTREGA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_NF_REFERENCIADA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_PROCESSO_REFERENCIADO)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_PROD_RURAL_REFERENCIADA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_REFERENCIADA)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.NFE_TRANSPORTE)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CABECALHO>()
                .HasMany(e => e.PRODUTO_LOTE)
                .WithRequired(e => e.NFE_CABECALHO)
                .HasForeignKey(e => e.ID_NFE_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CANA>()
                .Property(e => e.SAFRA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CANA>()
                .Property(e => e.MES_ANO_REFERENCIA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CANA>()
                .HasMany(e => e.NFE_CANA_FORNECIMENTO_DIARIO)
                .WithRequired(e => e.NFE_CANA)
                .HasForeignKey(e => e.ID_NFE_CANA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CANA>()
                .HasMany(e => e.NFE_CANA_DEDUCOES_SAFRA)
                .WithRequired(e => e.NFE_CANA)
                .HasForeignKey(e => e.ID_NFE_CANA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_CANA_DEDUCOES_SAFRA>()
                .Property(e => e.DECRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CANA_DEDUCOES_SAFRA>()
                .Property(e => e.VALOR_DEDUCAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_DEDUCOES_SAFRA>()
                .Property(e => e.VALOR_FORNECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_DEDUCOES_SAFRA>()
                .Property(e => e.VALOR_TOTAL_DEDUCAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_DEDUCOES_SAFRA>()
                .Property(e => e.VALOR_LIQUIDO_FORNECIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_FORNECIMENTO_DIARIO>()
                .Property(e => e.DIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CANA_FORNECIMENTO_DIARIO>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_FORNECIMENTO_DIARIO>()
                .Property(e => e.QUANTIDADE_TOTAL_MES)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_FORNECIMENTO_DIARIO>()
                .Property(e => e.QUANTIDADE_TOTAL_ANTERIOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CANA_FORNECIMENTO_DIARIO>()
                .Property(e => e.QUANTIDADE_TOTAL_GERAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_CAMINHO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CERTIFICADO_DIGITAL_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.VERSAO_PROCESSO_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_LOGOMARCA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.SALVAR_XML)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SALVAR_XML)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SCHEMAS)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_ARQUIVO_DANFE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.CAMINHO_SALVAR_PDF)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_HOST)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_PROXY_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.WEBSERVICE_VISUALIZAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.EMAIL_SERVIDOR_SMTP)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.EMAIL_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.EMAIL_SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.EMAIL_ASSUNTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.EMAIL_AUTENTICA_SSL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CONFIGURACAO>()
                .Property(e => e.EMAIL_TEXTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CTE_REFERENCIADO>()
                .Property(e => e.CHAVE_ACESSO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CUPOM_FISCAL_REFERENCIADO>()
                .Property(e => e.MODELO_DOCUMENTO_FISCAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_CUPOM_FISCAL_REFERENCIADO>()
                .Property(e => e.NUMERO_SERIE_ECF)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.NUMERO_DOCUMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.LOCAL_DESEMBARACO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.UF_DESEMBARACO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.CODIGO_EXPORTADOR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.VALOR_AFRMM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .Property(e => e.UF_TERCEIRO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DECLARACAO_IMPORTACAO>()
                .HasMany(e => e.NFE_IMPORTACAO_DETALHE)
                .WithRequired(e => e.NFE_DECLARACAO_IMPORTACAO)
                .HasForeignKey(e => e.ID_NFE_DECLARACAO_IMPORTACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.ESTRANGEIRO_IDENTIFICACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.INSCRICAO_MUNICIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DESTINATARIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_ARMAMENTO>()
                .Property(e => e.NUMERO_SERIE_ARMA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_ARMAMENTO>()
                .Property(e => e.NUMERO_SERIE_CANO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_ARMAMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.CODIF)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.QUANTIDADE_TEMP_AMBIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.UF_CONSUMO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.BASE_CALCULO_CIDE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.ALIQUOTA_CIDE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.VALOR_CIDE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.DESCRICAO_PRODUTO_ANP)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.PERCENTUAL_PETROLEO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.PERCENTUAL_NACIONAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.PERCENTUAL_IMPORTADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.VALOR_PARTIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.VALOR_ENCERRANTE_INICIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_COMBUSTIVEL>()
                .Property(e => e.VALOR_ENCERRANTE_FIM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_MEDICAMENTO>()
                .Property(e => e.PRECO_MAXIMO_CONSUMIDOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_MEDICAMENTO>()
                .Property(e => e.CODIGO_PRODUTO_ANVISA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.TIPO_OPERACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CHASSI)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.COR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.DESCRICAO_COR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.POTENCIA_MOTOR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CILINDRADAS)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.PESO_LIQUIDO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.PESO_BRUTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.NUMERO_SERIE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.TIPO_COMBUSTIVEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.NUMERO_MOTOR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CAPACIDADE_MAXIMA_TRACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.DISTANCIA_EIXOS)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.ANO_MODELO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.ANO_FABRICACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.TIPO_PINTURA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.TIPO_VEICULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.ESPECIE_VEICULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CONDICAO_VIN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CONDICAO_VEICULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CODIGO_MARCA_MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.CODIGO_COR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DET_ESPECIFICO_VEICULO>()
                .Property(e => e.RESTRICAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.CODIGO_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.GTIN)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.NOME_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.NCM)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.NVE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.UNIDADE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.QUANTIDADE_COMERCIAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_UNITARIO_COMERCIAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_BRUTO_PRODUTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.GTIN_UNIDADE_TRIBUTAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.UNIDADE_TRIBUTAVEL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.QUANTIDADE_TRIBUTAVEL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_UNITARIO_TRIBUTAVEL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_SEGURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_OUTRAS_DESPESAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.NUMERO_PEDIDO_COMPRA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.INFORMACOES_ADICIONAIS)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.NUMERO_FCI)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.NUMERO_RECOPI)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_TOTAL_TRIBUTOS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.PERCENTUAL_DEVOLVIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.VALOR_IPI_DEVOLVIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.INDICADOR_ESCALA_RELEVANTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.CNPJ_FABRICANTE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .Property(e => e.CODIGO_BENEFICIO_FISCAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DECLARACAO_IMPORTACAO)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DET_ESPECIFICO_ARMAMENTO)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DET_ESPECIFICO_COMBUSTIVEL)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DET_ESPECIFICO_MEDICAMENTO)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DET_ESPECIFICO_VEICULO)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_RASTRO)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_IMPOSTO_II)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_IMPOSTO_ICMS)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_IMPOSTO_COFINS)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_IMPOSTO_PIS)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_IMPOSTO_ISSQN)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_DETALHE_IMPOSTO_IPI)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE>()
                .HasMany(e => e.NFE_EXPORTACAO)
                .WithRequired(e => e.NFE_DETALHE)
                .HasForeignKey(e => e.ID_NFE_DETALHE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_COFINS>()
                .Property(e => e.CST_COFINS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_COFINS>()
                .Property(e => e.QUANTIDADE_VENDIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_COFINS>()
                .Property(e => e.BASE_CALCULO_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_COFINS>()
                .Property(e => e.ALIQUOTA_COFINS_PERCENTUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_COFINS>()
                .Property(e => e.ALIQUOTA_COFINS_REAIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_COFINS>()
                .Property(e => e.VALOR_COFINS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.CST_ICMS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.CSOSN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.TAXA_REDUCAO_BC_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.BASE_CALCULO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.ALIQUOTA_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_OPERACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_DIFERIMENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_DIFERIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_DESONERADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_MVA_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_REDUCAO_BC_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BASE_CALCULO_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.ALIQUOTA_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BC_ICMS_ST_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_ST_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BC_ICMS_ST_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_ST_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.ALIQUOTA_CREDITO_ICMS_SN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_CREDITO_ICMS_SN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_BC_OPERACAO_PROPRIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.UF_ST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BC_FPC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_FPC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_FPC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BC_FPC_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_BC_FPC_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_FPC_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.FPC_CONSUMIDOR_FINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BC_FPC_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_BC_FPC_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_FPC_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BC_FPC_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_BS_ICMS_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_FPC_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.ALIQUOTA_INTERNA_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.ALIQUOTA_INTERESTADUAL_UFS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.PERCENTUAL_PROVISORIO_PARTILHA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_FPC_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_INTER_UF_DESTINO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ICMS>()
                .Property(e => e.VALOR_ICMS_INTER_UF_REMETENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_II>()
                .Property(e => e.VALOR_BC_II)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_II>()
                .Property(e => e.VALOR_DESPESAS_ADUANEIRAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_II>()
                .Property(e => e.VALOR_IMPOSTO_IMPORTACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_II>()
                .Property(e => e.VALOR_IOF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.ENQUADRAMENTO_IPI)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.CNPJ_PRODUTOR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.CODIGO_SELO_IPI)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.ENQUADRAMENTO_LEGAL_IPI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.CST_IPI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.VALOR_BASE_CALCULO_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.ALIQUOTA_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.QUANTIDADE_UNIDADE_TRIBUTAVEL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.VALOR_UNIDADE_TRIBUTAVEL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_IPI>()
                .Property(e => e.VALOR_IPI)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.BASE_CALCULO_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.ALIQUOTA_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.VALOR_ISSQN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.VALOR_DEDUCAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.VALOR_OUTRAS_RETENCOES)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.VALOR_DESCONTO_INCONDICIONADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.VALOR_DESCONTO_CONDICIONADO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.VALOR_RETENCAO_ISS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.CODIGO_SERVICO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_ISSQN>()
                .Property(e => e.NUMERO_PROCESSO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_PIS>()
                .Property(e => e.CST_PIS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_PIS>()
                .Property(e => e.QUANTIDADE_VENDIDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_PIS>()
                .Property(e => e.VALOR_BASE_CALCULO_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_PIS>()
                .Property(e => e.ALIQUOTA_PIS_PERCENTUAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_PIS>()
                .Property(e => e.ALIQUOTA_PIS_REAIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_IMPOSTO_PIS>()
                .Property(e => e.VALOR_PIS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_RASTRO>()
                .Property(e => e.NUMERO_LOTE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DETALHE_RASTRO>()
                .Property(e => e.QUANTIDADE_LOTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_DETALHE_RASTRO>()
                .Property(e => e.CODIGO_AGREGACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DUPLICATA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_DUPLICATA>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.NOME_PAIS)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.TELEFONE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.INSCRICAO_ESTADUAL_ST)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.INSCRICAO_MUNICIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.CNAE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.CRT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EMITENTE>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EXPORTACAO>()
                .Property(e => e.CHAVE_ACESSO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_EXPORTACAO>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_FATURA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FATURA>()
                .Property(e => e.VALOR_ORIGINAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_FATURA>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_FATURA>()
                .Property(e => e.VALOR_LIQUIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.FORMA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.CARTAO_TIPO_INTEGRACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.CNPJ_OPERADORA_CARTAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.BANDEIRA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.NUMERO_AUTORIZACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.ESTORNO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_FORMA_PAGAMENTO>()
                .Property(e => e.TROCO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_IMPORTACAO_DETALHE>()
                .Property(e => e.CODIGO_FABRICANTE_ESTRANGEIRO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_IMPORTACAO_DETALHE>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_ENTREGA>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_LOCAL_RETIRADA>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NF_REFERENCIADA>()
                .Property(e => e.ANO_MES)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NF_REFERENCIADA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NF_REFERENCIADA>()
                .Property(e => e.MODELO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NF_REFERENCIADA>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NUMERO>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NUMERO_INUTILIZADO>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_NUMERO_INUTILIZADO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROCESSO_REFERENCIADO>()
                .Property(e => e.IDENTIFICADOR)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROCESSO_REFERENCIADO>()
                .Property(e => e.ORIGEM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROD_RURAL_REFERENCIADA>()
                .Property(e => e.ANO_MES)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROD_RURAL_REFERENCIADA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROD_RURAL_REFERENCIADA>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROD_RURAL_REFERENCIADA>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROD_RURAL_REFERENCIADA>()
                .Property(e => e.MODELO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_PROD_RURAL_REFERENCIADA>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_REFERENCIADA>()
                .Property(e => e.CHAVE_ACESSO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.CPF_CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.EMPRESA_ENDERECO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.NOME_MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.VALOR_SERVICO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.VALOR_BC_RETENCAO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.ALIQUOTA_RETENCAO_ICMS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.VALOR_ICMS_RETIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.PLACA_VEICULO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.UF_VEICULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.RNTC_VEICULO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.VAGAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .Property(e => e.BALSA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .HasMany(e => e.NFE_TRANSPORTE_REBOQUE)
                .WithRequired(e => e.NFE_TRANSPORTE)
                .HasForeignKey(e => e.ID_NFE_TRANSPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_TRANSPORTE>()
                .HasMany(e => e.NFE_TRANSPORTE_VOLUME)
                .WithRequired(e => e.NFE_TRANSPORTE)
                .HasForeignKey(e => e.ID_NFE_TRANSPORTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_TRANSPORTE_REBOQUE>()
                .Property(e => e.PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE_REBOQUE>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE_REBOQUE>()
                .Property(e => e.RNTC)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME>()
                .Property(e => e.ESPECIE)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME>()
                .Property(e => e.MARCA)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME>()
                .Property(e => e.NUMERACAO)
                .IsUnicode(false);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME>()
                .Property(e => e.PESO_LIQUIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME>()
                .Property(e => e.PESO_BRUTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME>()
                .HasMany(e => e.NFE_TRANSPORTE_VOLUME_LACRE)
                .WithRequired(e => e.NFE_TRANSPORTE_VOLUME)
                .HasForeignKey(e => e.ID_NFE_TRANSPORTE_VOLUME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NFE_TRANSPORTE_VOLUME_LACRE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<NIVEL_FORMACAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NIVEL_FORMACAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NIVEL_FORMACAO>()
                .HasMany(e => e.COLABORADOR)
                .WithRequired(e => e.NIVEL_FORMACAO)
                .HasForeignKey(e => e.ID_NIVEL_FORMACAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTA_FISCAL_MODELO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_MODELO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_MODELO>()
                .Property(e => e.MODELO)
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_MODELO>()
                .HasMany(e => e.NOTA_FISCAL_TIPO)
                .WithRequired(e => e.NOTA_FISCAL_MODELO)
                .HasForeignKey(e => e.ID_NOTA_FISCAL_MODELO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOTA_FISCAL_TIPO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_TIPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_TIPO>()
                .Property(e => e.SERIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_TIPO>()
                .Property(e => e.SERIE_SCAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NOTA_FISCAL_TIPO>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithRequired(e => e.NOTA_FISCAL_TIPO)
                .HasForeignKey(e => e.ID_TIPO_NOTA_FISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.BANDEIRA)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.TAXA_ADM)
                .HasPrecision(18, 6);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.TAXA_ADM_DEBITO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.VALOR_ALUGUEL_POS_PIN)
                .HasPrecision(18, 6);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.FONE1)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.FONE2)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_CARTAO>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_PLANO_SAUDE>()
                .Property(e => e.REGISTRO_ANS)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_PLANO_SAUDE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<OPERADORA_PLANO_SAUDE>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.NOME_EN)
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.NOME_PTBR)
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.SIGLA2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .Property(e => e.SIGLA3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAIS>()
                .HasMany(e => e.INDICE_ECONOMICO)
                .WithRequired(e => e.PAIS)
                .HasForeignKey(e => e.ID_PAIS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAIS>()
                .HasMany(e => e.UF)
                .WithRequired(e => e.PAIS)
                .HasForeignKey(e => e.ID_PAIS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAPEL>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL>()
                .Property(e => e.ACESSO_COMPLETO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL>()
                .HasMany(e => e.PAPEL_FUNCAO)
                .WithRequired(e => e.PAPEL)
                .HasForeignKey(e => e.ID_PAPEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAPEL>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.PAPEL)
                .HasForeignKey(e => e.ID_PAPEL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PAPEL_FUNCAO>()
                .Property(e => e.PODE_CONSULTAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL_FUNCAO>()
                .Property(e => e.PODE_INSERIR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL_FUNCAO>()
                .Property(e => e.PODE_ALTERAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL_FUNCAO>()
                .Property(e => e.PODE_EXCLUIR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PAPEL_FUNCAO>()
                .Property(e => e.HABILITADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.SITE)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.CLIENTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.FORNECEDOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.COLABORADOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .Property(e => e.TRANSPORTADORA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.CLIENTE1)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.COLABORADOR1)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.DAV_CABECALHO)
                .WithOptional(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.EMPRESA_PESSOA)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.FIN_CHEQUE_RECEBIDO)
                .WithOptional(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.FORNECEDOR1)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PESSOA_ALTERACAO)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PESSOA_CONTATO)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PESSOA_ENDERECO)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PESSOA_FISICA)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PESSOA_JURIDICA)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PESSOA_TELEFONE)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.PRE_VENDA_CABECALHO)
                .WithOptional(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA);

            modelBuilder.Entity<PESSOA>()
                .HasMany(e => e.TRANSPORTADORA1)
                .WithRequired(e => e.PESSOA)
                .HasForeignKey(e => e.ID_PESSOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PESSOA_ALTERACAO>()
                .Property(e => e.OBJETO_ANTIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ALTERACAO>()
                .Property(e => e.OBJETO_NOVO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_CONTATO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_CONTATO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_CONTATO>()
                .Property(e => e.FONE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_CONTATO>()
                .Property(e => e.FONE_RESIDENCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_CONTATO>()
                .Property(e => e.FONE_CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.CIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.FONE)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.PRINCIPAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.ENTREGA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.COBRANCA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_ENDERECO>()
                .Property(e => e.CORRESPONDENCIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.RG)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.ORGAO_RG)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.SEXO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.NATURALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.NACIONALIDADE)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.RACA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.TIPO_SANGUE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.CNH_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.CNH_CATEGORIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.TITULO_ELEITORAL_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.RESERVISTA_NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.NOME_MAE)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_FISICA>()
                .Property(e => e.NOME_PAI)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.FANTASIA)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.INSCRICAO_MUNICIPAL)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.INSCRICAO_ESTADUAL)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.TIPO_REGIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.CRT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_JURIDICA>()
                .Property(e => e.SUFRAMA)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_TELEFONE>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<PESSOA_TELEFONE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CENTRO_RESULTADO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CENTRO_RESULTADO>()
                .Property(e => e.MASCARA)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_CENTRO_RESULTADO>()
                .HasMany(e => e.CENTRO_RESULTADO)
                .WithRequired(e => e.PLANO_CENTRO_RESULTADO)
                .HasForeignKey(e => e.ID_PLANO_CENTRO_RESULTADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PLANO_NATUREZA_FINANCEIRA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_NATUREZA_FINANCEIRA>()
                .Property(e => e.MASCARA)
                .IsUnicode(false);

            modelBuilder.Entity<PLANO_NATUREZA_FINANCEIRA>()
                .HasMany(e => e.NATUREZA_FINANCEIRA)
                .WithRequired(e => e.PLANO_NATUREZA_FINANCEIRA)
                .HasForeignKey(e => e.ID_PLANO_NATUREZA_FINANCEIRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.HORA_EMISSAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.NOME_DESTINATARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.CPF_CNPJ_DESTINATARIO)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.TAXA_ACRESCIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_CABECALHO>()
                .HasMany(e => e.PRE_VENDA_DETALHE)
                .WithRequired(e => e.PRE_VENDA_CABECALHO)
                .HasForeignKey(e => e.ID_PRE_VENDA_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.CANCELADO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.GTIN_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.NOME_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.UNIDADE_PRODUTO)
                .IsUnicode(false);

            modelBuilder.Entity<PRE_VENDA_DETALHE>()
                .Property(e => e.ECF_ICMS_ST)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.GTIN)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CODIGO_INTERNO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.NCM)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.DESCRICAO_PDV)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.VALOR_COMPRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.VALOR_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRECO_VENDA_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRECO_SUGERIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CUSTO_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CUSTO_PRODUCAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CUSTO_MEDIO_LIQUIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRECO_LUCRO_ZERO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRECO_LUCRO_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PRECO_LUCRO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.MARKUP)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.QUANTIDADE_ESTOQUE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.QUANTIDADE_ESTOQUE_ANTERIOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.ESTOQUE_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.ESTOQUE_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.ESTOQUE_IDEAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.EXCLUIDO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.INATIVO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.IMAGEM)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.EX_TIPI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CODIGO_LST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.CLASSE_ABC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.IAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.IPPT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.TIPO_ITEM_SPED)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PESO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PORCENTO_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.PONTO_PEDIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.LOTE_ECONOMICO_COMPRA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.ALIQUOTA_ICMS_PAF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.ALIQUOTA_ISSQN_PAF)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.TOTALIZADOR_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.SERVICO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.COMISSAO_OBJETIVO)
                .WithOptional(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.COMPRA_COTACAO_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.COMPRA_PEDIDO_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.COMPRA_REQUISICAO_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.DAV_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.EMPRESA_PRODUTO)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.ESTOQUE_GRADE)
                .WithOptional(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.ESTOQUE_REAJUSTE_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.FICHA_TECNICA)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.FORNECEDOR_PRODUTO)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.INVENTARIO_CONTAGEM_DET)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.NFE_DETALHE)
                .WithOptional(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRE_VENDA_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_ALTERACAO_ITEM)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_COMBO_ITEM)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_CODIGO_ADICIONAL)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_LACRE_ENTRADA)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_LOTE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.PRODUTO_PROMOCAO)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.REQUISICAO_INTERNA_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.TABELA_PRECO_PRODUTO)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.UNIDADE_CONVERSAO)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.VENDA_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.VENDA_ORCAMENTO_DETALHE)
                .WithRequired(e => e.PRODUTO)
                .HasForeignKey(e => e.ID_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO_ALTERACAO_ITEM>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_ALTERACAO_ITEM>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_CODIGO_ADICIONAL>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_COMBO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_COMBO>()
                .HasMany(e => e.PRODUTO_COMBO_ITEM)
                .WithRequired(e => e.PRODUTO_COMBO)
                .HasForeignKey(e => e.ID_PRODUTO_COMBO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO_COMBO_ITEM>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO_GRUPO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_GRUPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_GRUPO>()
                .HasMany(e => e.PRODUTO_SUBGRUPO)
                .WithRequired(e => e.PRODUTO_GRUPO)
                .HasForeignKey(e => e.ID_GRUPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO_LACRE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_LACRE>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_LACRE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_LACRE>()
                .HasMany(e => e.PRODUTO_LACRE_ENTRADA)
                .WithRequired(e => e.PRODUTO_LACRE)
                .HasForeignKey(e => e.ID_LACRE_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRODUTO_LOTE>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_LOTE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO_LOTE>()
                .Property(e => e.PRECO_MAXIMO_CONSUMIDOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO_LOTE>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_MARCA>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_MARCA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_MARCA>()
                .HasMany(e => e.PRODUTO)
                .WithOptional(e => e.PRODUTO_MARCA)
                .HasForeignKey(e => e.ID_MARCA_PRODUTO);

            modelBuilder.Entity<PRODUTO_PROMOCAO>()
                .Property(e => e.QUANTIDADE_EM_PROMOCAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO_PROMOCAO>()
                .Property(e => e.QUANTIDADE_MAXIMA_CLIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO_PROMOCAO>()
                .Property(e => e.VALOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<PRODUTO_SUBGRUPO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_SUBGRUPO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO_SUBGRUPO>()
                .HasMany(e => e.PRODUTO)
                .WithRequired(e => e.PRODUTO_SUBGRUPO)
                .HasForeignKey(e => e.ID_SUBGRUPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QUADRO_SOCIETARIO>()
                .Property(e => e.CAPITAL_SOCIAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<QUADRO_SOCIETARIO>()
                .Property(e => e.VALOR_QUOTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<QUADRO_SOCIETARIO>()
                .HasMany(e => e.SOCIO)
                .WithRequired(e => e.QUADRO_SOCIETARIO)
                .HasForeignKey(e => e.ID_QUADRO_SOCIETARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REGIAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<REGIAO>()
                .HasMany(e => e.CEP)
                .WithOptional(e => e.REGIAO)
                .HasForeignKey(e => e.ID_REGIAO);

            modelBuilder.Entity<REGIAO>()
                .HasMany(e => e.CLIENTE)
                .WithOptional(e => e.REGIAO)
                .HasForeignKey(e => e.ID_REGIAO);

            modelBuilder.Entity<REGIAO>()
                .HasMany(e => e.VENDEDOR)
                .WithOptional(e => e.REGIAO)
                .HasForeignKey(e => e.ID_REGIAO);

            modelBuilder.Entity<REQUISICAO_INTERNA_CABECALHO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<REQUISICAO_INTERNA_CABECALHO>()
                .HasMany(e => e.REQUISICAO_INTERNA_DETALHE)
                .WithRequired(e => e.REQUISICAO_INTERNA_CABECALHO)
                .HasForeignKey(e => e.ID_REQ_INTERNA_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<REQUISICAO_INTERNA_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SETOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<SETOR>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<SETOR>()
                .HasMany(e => e.COLABORADOR)
                .WithRequired(e => e.SETOR)
                .HasForeignKey(e => e.ID_SETOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.CONTA_BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.CODIGO_CEDENTE)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.NUMERO)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.FONE1)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.FONE2)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.TIPO_SINDICATO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.PISO_SALARIAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<SINDICATO>()
                .HasMany(e => e.COLABORADOR)
                .WithOptional(e => e.SINDICATO)
                .HasForeignKey(e => e.ID_SINDICATO);

            modelBuilder.Entity<SINDICATO>()
                .HasMany(e => e.CONTRIB_SIND_PATRONAL_CAB)
                .WithRequired(e => e.SINDICATO)
                .HasForeignKey(e => e.ID_SINDICATO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINDICATO>()
                .HasMany(e => e.EMPRESA)
                .WithOptional(e => e.SINDICATO)
                .HasForeignKey(e => e.ID_SINDICATO_PATRONAL);

            modelBuilder.Entity<SITUACAO_COLABORADOR>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_COLABORADOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_COLABORADOR>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_COLABORADOR>()
                .HasMany(e => e.COLABORADOR)
                .WithRequired(e => e.SITUACAO_COLABORADOR)
                .HasForeignKey(e => e.ID_SITUACAO_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACAO_DOCUMENTO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_DOCUMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_FOR_CLI>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_FOR_CLI>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<SITUACAO_FOR_CLI>()
                .HasMany(e => e.CLIENTE)
                .WithRequired(e => e.SITUACAO_FOR_CLI)
                .HasForeignKey(e => e.ID_SITUACAO_FOR_CLI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SITUACAO_FOR_CLI>()
                .HasMany(e => e.FORNECEDOR)
                .WithRequired(e => e.SITUACAO_FOR_CLI)
                .HasForeignKey(e => e.ID_SITUACAO_FOR_CLI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.LOGRADOURO)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.COMPLEMENTO)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.BAIRRO)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.UF)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.CEP)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.FONE)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.PARTICIPACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SOCIO>()
                .Property(e => e.INTEGRALIZAR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SOCIO>()
                .HasMany(e => e.SOCIO_DEPENDENTE)
                .WithRequired(e => e.SOCIO)
                .HasForeignKey(e => e.ID_SOCIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOCIO>()
                .HasMany(e => e.SOCIO_PARTICIPACAO_SOCIETARIA)
                .WithRequired(e => e.SOCIO)
                .HasForeignKey(e => e.ID_SOCIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SOCIO_DEPENDENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO_DEPENDENTE>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO_PARTICIPACAO_SOCIETARIA>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO_PARTICIPACAO_SOCIETARIA>()
                .Property(e => e.RAZAO_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<SOCIO_PARTICIPACAO_SOCIETARIA>()
                .Property(e => e.PARTICIPACAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<SOCIO_PARTICIPACAO_SOCIETARIA>()
                .Property(e => e.DIRIGENTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TABELA_PRECO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TABELA_PRECO>()
                .Property(e => e.COEFICIENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TABELA_PRECO>()
                .Property(e => e.PRINCIPAL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TABELA_PRECO>()
                .Property(e => e.BASE_CUSTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TABELA_PRECO>()
                .Property(e => e.METODO_UTILIZACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TABELA_PRECO>()
                .Property(e => e.COMISSAO_VENDEDOR)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TABELA_PRECO>()
                .HasMany(e => e.CLIENTE)
                .WithOptional(e => e.TABELA_PRECO)
                .HasForeignKey(e => e.ID_TABELA_PRECO);

            modelBuilder.Entity<TABELA_PRECO>()
                .HasMany(e => e.COMISSAO_OBJETIVO)
                .WithOptional(e => e.TABELA_PRECO)
                .HasForeignKey(e => e.ID_TABELA_PRECO);

            modelBuilder.Entity<TABELA_PRECO>()
                .HasMany(e => e.TABELA_PRECO_PRODUTO)
                .WithRequired(e => e.TABELA_PRECO)
                .HasForeignKey(e => e.ID_TABELA_PRECO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TABELA_PRECO>()
                .HasMany(e => e.VENDEDOR)
                .WithOptional(e => e.TABELA_PRECO)
                .HasForeignKey(e => e.ID_TABELA_PRECO);

            modelBuilder.Entity<TABELA_PRECO_PRODUTO>()
                .Property(e => e.PRECO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TALONARIO_CHEQUE>()
                .Property(e => e.TALAO)
                .IsUnicode(false);

            modelBuilder.Entity<TALONARIO_CHEQUE>()
                .Property(e => e.STATUS_TALAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TALONARIO_CHEQUE>()
                .HasMany(e => e.CHEQUE)
                .WithRequired(e => e.TALONARIO_CHEQUE)
                .HasForeignKey(e => e.ID_TALONARIO_CHEQUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_ADMISSAO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ADMISSAO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ADMISSAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ADMISSAO>()
                .HasMany(e => e.COLABORADOR)
                .WithOptional(e => e.TIPO_ADMISSAO)
                .HasForeignKey(e => e.ID_TIPO_ADMISSAO);

            modelBuilder.Entity<TIPO_COLABORADOR>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COLABORADOR>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_COLABORADOR>()
                .HasMany(e => e.COLABORADOR)
                .WithRequired(e => e.TIPO_COLABORADOR)
                .HasForeignKey(e => e.ID_TIPO_COLABORADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_ITEM_SPED>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_ITEM_SPED>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RECEITA_DIPI>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RECEITA_DIPI>()
                .HasMany(e => e.TRIBUT_IPI_DIPI)
                .WithOptional(e => e.TIPO_RECEITA_DIPI)
                .HasForeignKey(e => e.ID_TIPO_RECEITA_DIPI);

            modelBuilder.Entity<TIPO_RELACIONAMENTO>()
                .Property(e => e.CODIGO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RELACIONAMENTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RELACIONAMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_RELACIONAMENTO>()
                .HasMany(e => e.COLABORADOR_RELACIONAMENTO)
                .WithRequired(e => e.TIPO_RELACIONAMENTO)
                .HasForeignKey(e => e.ID_TIPO_RELACIONAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_RELACIONAMENTO>()
                .HasMany(e => e.SOCIO_DEPENDENTE)
                .WithRequired(e => e.TIPO_RELACIONAMENTO)
                .HasForeignKey(e => e.ID_TIPO_RELACIONAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANSPORTADORA>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORA>()
                .Property(e => e.CLASSIFICACAO_CONTABIL_CONTA)
                .IsUnicode(false);

            modelBuilder.Entity<TRANSPORTADORA>()
                .HasMany(e => e.NFE_TRANSPORTE)
                .WithOptional(e => e.TRANSPORTADORA)
                .HasForeignKey(e => e.ID_TRANSPORTADORA);

            modelBuilder.Entity<TRANSPORTADORA>()
                .HasMany(e => e.TRANSPORTADORA_MUNICIPIO)
                .WithRequired(e => e.TRANSPORTADORA)
                .HasForeignKey(e => e.ID_TRANSPORTADORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANSPORTADORA>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithOptional(e => e.TRANSPORTADORA)
                .HasForeignKey(e => e.ID_TRANSPORTADORA);

            modelBuilder.Entity<TRANSPORTADORA>()
                .HasMany(e => e.VENDA_FRETE)
                .WithRequired(e => e.TRANSPORTADORA)
                .HasForeignKey(e => e.ID_TRANSPORTADORA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRANSPORTADORA>()
                .HasMany(e => e.VENDA_ORCAMENTO_CABECALHO)
                .WithOptional(e => e.TRANSPORTADORA)
                .HasForeignKey(e => e.ID_TRANSPORTADORA);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.CST_COFINS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.EFD_TABELA_435)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.MODALIDADE_BASE_CALCULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.PORCENTO_BASE_CALCULO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.ALIQUOTA_PORCENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.ALIQUOTA_UNIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.VALOR_PRECO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_COFINS_COD_APURACAO>()
                .Property(e => e.VALOR_PAUTA_FISCAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_CONFIGURA_OF_GT>()
                .HasMany(e => e.TRIBUT_COFINS_COD_APURACAO)
                .WithRequired(e => e.TRIBUT_CONFIGURA_OF_GT)
                .HasForeignKey(e => e.ID_TRIBUT_CONFIGURA_OF_GT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_CONFIGURA_OF_GT>()
                .HasMany(e => e.TRIBUT_ICMS_UF)
                .WithRequired(e => e.TRIBUT_CONFIGURA_OF_GT)
                .HasForeignKey(e => e.ID_TRIBUT_CONFIGURA_OF_GT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_CONFIGURA_OF_GT>()
                .HasMany(e => e.TRIBUT_IPI_DIPI)
                .WithRequired(e => e.TRIBUT_CONFIGURA_OF_GT)
                .HasForeignKey(e => e.ID_TRIBUT_CONFIGURA_OF_GT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_CONFIGURA_OF_GT>()
                .HasMany(e => e.TRIBUT_PIS_COD_APURACAO)
                .WithRequired(e => e.TRIBUT_CONFIGURA_OF_GT)
                .HasForeignKey(e => e.ID_TRIBUT_CONFIGURA_OF_GT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_GRUPO_TRIBUTARIO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_GRUPO_TRIBUTARIO>()
                .Property(e => e.ORIGEM_MERCADORIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_GRUPO_TRIBUTARIO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_GRUPO_TRIBUTARIO>()
                .HasMany(e => e.PRODUTO)
                .WithOptional(e => e.TRIBUT_GRUPO_TRIBUTARIO)
                .HasForeignKey(e => e.ID_GRUPO_TRIBUTARIO);

            modelBuilder.Entity<TRIBUT_GRUPO_TRIBUTARIO>()
                .HasMany(e => e.TRIBUT_CONFIGURA_OF_GT)
                .WithRequired(e => e.TRIBUT_GRUPO_TRIBUTARIO)
                .HasForeignKey(e => e.ID_TRIBUT_GRUPO_TRIBUTARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_CAB>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_CAB>()
                .Property(e => e.ORIGEM_MERCADORIA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_CAB>()
                .HasMany(e => e.PRODUTO)
                .WithOptional(e => e.TRIBUT_ICMS_CUSTOM_CAB)
                .HasForeignKey(e => e.ID_TRIBUT_ICMS_CUSTOM_CAB);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_CAB>()
                .HasMany(e => e.TRIBUT_ICMS_CUSTOM_DET)
                .WithRequired(e => e.TRIBUT_ICMS_CUSTOM_CAB)
                .HasForeignKey(e => e.ID_TRIBUT_ICMS_CUSTOM_CAB)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.UF_DESTINO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.CSOSN_B)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.CST_B)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.MODALIDADE_BC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.ALIQUOTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.VALOR_PAUTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.VALOR_PRECO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.MVA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.PORCENTO_BC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.MODALIDADE_BC_ST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.ALIQUOTA_INTERNA_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.ALIQUOTA_INTERESTADUAL_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.PORCENTO_BC_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.ALIQUOTA_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.VALOR_PAUTA_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_CUSTOM_DET>()
                .Property(e => e.VALOR_PRECO_MAXIMO_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.UF_DESTINO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.CSOSN_B)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.CST_B)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.MODALIDADE_BC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.ALIQUOTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.VALOR_PAUTA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.VALOR_PRECO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.MVA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.PORCENTO_BC)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.MODALIDADE_BC_ST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.ALIQUOTA_INTERNA_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.ALIQUOTA_INTERESTADUAL_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.PORCENTO_BC_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.ALIQUOTA_ICMS_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.VALOR_PAUTA_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.VALOR_PRECO_MAXIMO_ST)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ICMS_UF>()
                .Property(e => e.FCP)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.CST_IPI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.MODALIDADE_BASE_CALCULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.PORCENTO_BASE_CALCULO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.ALIQUOTA_PORCENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.ALIQUOTA_UNIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.VALOR_PRECO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_IPI_DIPI>()
                .Property(e => e.VALOR_PAUTA_FISCAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.MODALIDADE_BASE_CALCULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.PORCENTO_BASE_CALCULO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.ALIQUOTA_PORCENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.ALIQUOTA_UNIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.VALOR_PRECO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.VALOR_PAUTA_FISCAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_ISS>()
                .Property(e => e.CODIGO_TRIBUTACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .Property(e => e.DESCRICAO_NA_NF)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .HasMany(e => e.CLIENTE)
                .WithOptional(e => e.TRIBUT_OPERACAO_FISCAL)
                .HasForeignKey(e => e.ID_OPERACAO_FISCAL);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.TRIBUT_OPERACAO_FISCAL)
                .HasForeignKey(e => e.ID_TRIBUT_OPERACAO_FISCAL);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .HasMany(e => e.TRIBUT_CONFIGURA_OF_GT)
                .WithRequired(e => e.TRIBUT_OPERACAO_FISCAL)
                .HasForeignKey(e => e.ID_TRIBUT_OPERACAO_FISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_OPERACAO_FISCAL>()
                .HasMany(e => e.TRIBUT_ISS)
                .WithRequired(e => e.TRIBUT_OPERACAO_FISCAL)
                .HasForeignKey(e => e.ID_TRIBUT_OPERACAO_FISCAL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.CST_PIS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.EFD_TABELA_435)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.MODALIDADE_BASE_CALCULO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.PORCENTO_BASE_CALCULO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.ALIQUOTA_PORCENTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.ALIQUOTA_UNIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.VALOR_PRECO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<TRIBUT_PIS_COD_APURACAO>()
                .Property(e => e.VALOR_PAUTA_FISCAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<UF>()
                .Property(e => e.SIGLA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UF>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<UF>()
                .HasMany(e => e.MUNICIPIO)
                .WithRequired(e => e.UF)
                .HasForeignKey(e => e.ID_UF)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UNIDADE_CONVERSAO>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_CONVERSAO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_CONVERSAO>()
                .Property(e => e.FATOR_CONVERSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<UNIDADE_PRODUTO>()
                .Property(e => e.SIGLA)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_PRODUTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_PRODUTO>()
                .Property(e => e.PODE_FRACIONAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UNIDADE_PRODUTO>()
                .HasMany(e => e.PRODUTO)
                .WithRequired(e => e.UNIDADE_PRODUTO)
                .HasForeignKey(e => e.ID_UNIDADE_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UNIDADE_PRODUTO>()
                .HasMany(e => e.UNIDADE_CONVERSAO)
                .WithRequired(e => e.UNIDADE_PRODUTO)
                .HasForeignKey(e => e.ID_UNIDADE_PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.LOGIN)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.ADMINISTRADOR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.AUDITORIA)
                .WithRequired(e => e.USUARIO)
                .HasForeignKey(e => e.ID_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.HORA_SAIDA)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.LOCAL_COBRANCA)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.TAXA_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.VALOR_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.TIPO_FRETE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.FORMA_PAGAMENTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.VALOR_SEGURO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.VENDA_CABECALHO)
                .HasForeignKey(e => e.ID_VENDA_CABECALHO);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .HasMany(e => e.VENDA_COMISSAO)
                .WithRequired(e => e.VENDA_CABECALHO)
                .HasForeignKey(e => e.ID_VENDA_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .HasMany(e => e.VENDA_DETALHE)
                .WithRequired(e => e.VENDA_CABECALHO)
                .HasForeignKey(e => e.ID_VENDA_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_CABECALHO>()
                .HasMany(e => e.VENDA_FRETE)
                .WithRequired(e => e.VENDA_CABECALHO)
                .HasForeignKey(e => e.ID_VENDA_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_COMISSAO>()
                .Property(e => e.VALOR_VENDA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_COMISSAO>()
                .Property(e => e.TIPO_CONTABIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_COMISSAO>()
                .Property(e => e.VALOR_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_COMISSAO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.FATURAMENTO_MINIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.FATURAMENTO_MAXIMO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.INDICE_CORRECAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.VALOR_TOLERANCIA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .Property(e => e.VISTA_PRAZO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithRequired(e => e.VENDA_CONDICOES_PAGAMENTO)
                .HasForeignKey(e => e.ID_VENDA_CONDICOES_PAGAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .HasMany(e => e.VENDA_CONDICOES_PARCELAS)
                .WithRequired(e => e.VENDA_CONDICOES_PAGAMENTO)
                .HasForeignKey(e => e.ID_VENDA_CONDICOES_PAGAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_CONDICOES_PAGAMENTO>()
                .HasMany(e => e.VENDA_ORCAMENTO_CABECALHO)
                .WithRequired(e => e.VENDA_CONDICOES_PAGAMENTO)
                .HasForeignKey(e => e.ID_VENDA_CONDICOES_PAGAMENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_CONDICOES_PARCELAS>()
                .Property(e => e.TAXA)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.TAXA_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_DETALHE>()
                .Property(e => e.VALOR_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.RESPONSAVEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.PLACA)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.UF_PLACA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.QUANTIDADE_VOLUME)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.MARCA_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.ESPECIE_VOLUME)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.PESO_BRUTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_FRETE>()
                .Property(e => e.PESO_LIQUIDO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.TIPO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.CODIGO)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.TIPO_FRETE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.VALOR_FRETE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.TAXA_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.VALOR_COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithOptional(e => e.VENDA_ORCAMENTO_CABECALHO)
                .HasForeignKey(e => e.ID_VENDA_ORCAMENTO_CABECALHO);

            modelBuilder.Entity<VENDA_ORCAMENTO_CABECALHO>()
                .HasMany(e => e.VENDA_ORCAMENTO_DETALHE)
                .WithRequired(e => e.VENDA_ORCAMENTO_CABECALHO)
                .HasForeignKey(e => e.ID_VENDA_ORCAMENTO_CABECALHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA_ORCAMENTO_DETALHE>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_DETALHE>()
                .Property(e => e.VALOR_UNITARIO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_DETALHE>()
                .Property(e => e.VALOR_SUBTOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_DETALHE>()
                .Property(e => e.TAXA_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_DETALHE>()
                .Property(e => e.VALOR_DESCONTO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ORCAMENTO_DETALHE>()
                .Property(e => e.VALOR_TOTAL)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDA_ROMANEIO_ENTREGA>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ROMANEIO_ENTREGA>()
                .Property(e => e.SITUACAO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ROMANEIO_ENTREGA>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<VENDA_ROMANEIO_ENTREGA>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithOptional(e => e.VENDA_ROMANEIO_ENTREGA)
                .HasForeignKey(e => e.ID_VENDA_ROMANEIO_ENTREGA);

            modelBuilder.Entity<VENDEDOR>()
                .Property(e => e.COMISSAO)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDEDOR>()
                .Property(e => e.META_VENDAS)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDEDOR>()
                .Property(e => e.GERENTE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VENDEDOR>()
                .Property(e => e.TAXA_GERENTE)
                .HasPrecision(18, 6);

            modelBuilder.Entity<VENDEDOR>()
                .HasMany(e => e.NFE_CABECALHO)
                .WithOptional(e => e.VENDEDOR)
                .HasForeignKey(e => e.ID_VENDEDOR);

            modelBuilder.Entity<VENDEDOR>()
                .HasMany(e => e.VENDA_CABECALHO)
                .WithRequired(e => e.VENDEDOR)
                .HasForeignKey(e => e.ID_VENDEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDEDOR>()
                .HasMany(e => e.VENDA_COMISSAO)
                .WithRequired(e => e.VENDEDOR)
                .HasForeignKey(e => e.ID_VENDEDOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDEDOR>()
                .HasMany(e => e.VENDA_ORCAMENTO_CABECALHO)
                .WithRequired(e => e.VENDEDOR)
                .HasForeignKey(e => e.ID_VENDEDOR)
                .WillCascadeOnDelete(false);
        }
    }
}
