namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_cabecalho")]
    public partial class NFe_Cabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFe_Cabecalho()
        {
            nfe_acesso_xml = new HashSet<NFe_AcessoXML>();
            nfe_cana = new HashSet<NFe_Cana>();
            nfe_cte_referenciado = new HashSet<NFe_CTe_Referenciado>();
            nfe_cupom_fiscal_referenciado = new HashSet<NFe_CupomFiscalReferenciado>();
            nfe_destinatario = new HashSet<NFe_Destinatario>();
            nfe_detalhe = new HashSet<NFe_Detalhe>();
            nfe_duplicata = new HashSet<NFe_Duplicata>();
            nfe_emitente = new HashSet<NFe_Emitente>();
            nfe_fatura = new HashSet<NFe_Fatura>();
            nfe_forma_pagamento = new HashSet<NFe_FormaPagamento>();
            nfe_local_entrega = new HashSet<NFe_LocalEntrega>();
            nfe_local_retirada = new HashSet<NFe_LocalRetirada>();
            nfe_nf_referenciada = new HashSet<NFe_NotaFiscalReferenciada>();
            nfe_processo_referenciado = new HashSet<NFe_ProcessoReferenciado>();
            nfe_prod_rural_referenciada = new HashSet<NFe_ProdutorRuralReferenciada>();
            nfe_referenciada = new HashSet<NFe_Referenciada>();
            nfe_transporte = new HashSet<NFe_Transporte>();
            produto_lote = new HashSet<ProdutoLote>();
        }

        public int id { get; set; }

        public int? id_nfce_movimento { get; set; }

        public int? id_vendedor { get; set; }

        public int? id_tribut_operacao_fiscal { get; set; }

        public int? id_venda_cabecalho { get; set; }

        public int? id_empresa { get; set; }

        public int? id_fornecedor { get; set; }

        public int? id_cliente { get; set; }

        public int? uf_emitente { get; set; }

        [StringLength(8)]
        public string codigo_numerico { get; set; }

        [StringLength(60)]
        public string natureza_operacao { get; set; }

        [StringLength(2)]
        public string codigo_modelo { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        [StringLength(9)]
        public string numero { get; set; }

        public DateTime? data_hora_emissao { get; set; }

        public DateTime? data_hora_entrada_saida { get; set; }

        public int? tipo_operacao { get; set; }

        public int? local_destino { get; set; }

        public int? codigo_municipio { get; set; }

        public int? formato_impressao_danfe { get; set; }

        public int? tipo_emissao { get; set; }

        [StringLength(44)]
        public string chave_acesso { get; set; }

        [StringLength(1)]
        public string digito_chave_acesso { get; set; }

        public int? ambiente { get; set; }

        public int? finalidade_emissao { get; set; }

        public int? consumidor_operacao { get; set; }

        public int? processo_emissao { get; set; }

        [StringLength(20)]
        public string versao_processo_emissao { get; set; }

        public DateTime? data_entrada_contingencia { get; set; }

        [StringLength(255)]
        public string justificativa_contingencia { get; set; }

        public decimal? base_calculo_icms { get; set; }

        public decimal? valor_icms { get; set; }

        public decimal? valor_icms_desonerado { get; set; }

        public decimal? base_calculo_icms_st { get; set; }

        public decimal? valor_icms_st { get; set; }

        public decimal? valor_total_produtos { get; set; }

        public decimal? valor_frete { get; set; }

        public decimal? valor_seguro { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_imposto_importacao { get; set; }

        public decimal? valor_ipi { get; set; }

        public decimal? valor_pis { get; set; }

        public decimal? valor_cofins { get; set; }

        public decimal? valor_despesas_acessorias { get; set; }

        public decimal? valor_total { get; set; }

        public decimal? valor_servicos { get; set; }

        public decimal? base_calculo_issqn { get; set; }

        public decimal? valor_issqn { get; set; }

        public decimal? valor_pis_issqn { get; set; }

        public decimal? valor_cofins_issqn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_prestacao_servico { get; set; }

        public decimal? valor_deducao_issqn { get; set; }

        public decimal? outras_retencoes_issqn { get; set; }

        public decimal? desconto_incondicionado_issqn { get; set; }

        public decimal? desconto_condicionado_issqn { get; set; }

        public decimal? total_retencao_issqn { get; set; }

        public int? regime_especial_tributacao { get; set; }

        public decimal? valor_retido_pis { get; set; }

        public decimal? valor_retido_cofins { get; set; }

        public decimal? valor_retido_csll { get; set; }

        public decimal? base_calculo_irrf { get; set; }

        public decimal? valor_retido_irrf { get; set; }

        public decimal? base_calculo_previdencia { get; set; }

        public decimal? valor_retido_previdencia { get; set; }

        public decimal? troco { get; set; }

        [StringLength(2)]
        public string comex_uf_embarque { get; set; }

        [StringLength(60)]
        public string comex_local_embarque { get; set; }

        [StringLength(60)]
        public string comex_local_despacho { get; set; }

        [StringLength(22)]
        public string compra_nota_empenho { get; set; }

        [StringLength(60)]
        public string compra_pedido { get; set; }

        [StringLength(60)]
        public string compra_contrato { get; set; }

        public string informacoes_add_fisco { get; set; }

        public string informacoes_add_contribuinte { get; set; }

        public int? status_nota { get; set; }

        public int? quantidade_impressao_danfe { get; set; }

        [StringLength(1)]
        public string indicador_presenca { get; set; }

        public decimal? valor_fcp { get; set; }

        public decimal? valor_fcp_st { get; set; }

        public decimal? valor_fcp_st_retido { get; set; }

        public decimal? valor_ipi_devolvido { get; set; }

        [StringLength(20)]
        public string versao_aplicativo { get; set; }

        public DateTime? data_hora_processamento { get; set; }

        [StringLength(15)]
        public string numero_protocolo { get; set; }

        [StringLength(28)]
        public string digest_value { get; set; }

        [StringLength(3)]
        public string codigo_status_resposta { get; set; }

        public string descricao_motivo_resposta { get; set; }

        [StringLength(255)]
        public string justificativa_cancelamento { get; set; }

        public decimal? valor_icms_fcp_uf_destino { get; set; }

        public decimal? valor_icms_inter_uf_destino { get; set; }

        public decimal? valor_icms_inter_uf_remetente { get; set; }

        public string qrcode { get; set; }

        [StringLength(85)]
        public string url_chave { get; set; }

        public int? indicador_forma_pagamento { get; set; }

        public virtual Cliente cliente { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual Fornecedor fornecedor { get; set; }

        public virtual NFCe_Movimento nfce_movimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_AcessoXML> nfe_acesso_xml { get; set; }

        public virtual Tribut_OperacaoFiscal tribut_operacao_fiscal { get; set; }

        public virtual VendaCabecalho venda_cabecalho { get; set; }

        public virtual Vendedor vendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cana> nfe_cana { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_CTe_Referenciado> nfe_cte_referenciado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_CupomFiscalReferenciado> nfe_cupom_fiscal_referenciado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Destinatario> nfe_destinatario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Detalhe> nfe_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Duplicata> nfe_duplicata { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Emitente> nfe_emitente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Fatura> nfe_fatura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_FormaPagamento> nfe_forma_pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_LocalEntrega> nfe_local_entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_LocalRetirada> nfe_local_retirada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_NotaFiscalReferenciada> nfe_nf_referenciada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_ProcessoReferenciado> nfe_processo_referenciado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_ProdutorRuralReferenciada> nfe_prod_rural_referenciada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Referenciada> nfe_referenciada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Transporte> nfe_transporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoLote> produto_lote { get; set; }
    }
}