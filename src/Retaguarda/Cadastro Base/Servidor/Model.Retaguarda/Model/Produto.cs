namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            comissao_objetivo = new HashSet<ComissaoObjetivo>();
            compra_cotacao_detalhe = new HashSet<CompraCotacaoDetalhe>();
            compra_pedido_detalhe = new HashSet<CompraPedidoDetalhe>();
            compra_requisicao_detalhe = new HashSet<CompraRequisicaoDetalhe>();
            dav_detalhe = new HashSet<DAV_Detalhe>();
            empresa_produto = new HashSet<EmpresaProduto>();
            estoque_grade = new HashSet<EstoqueGrade>();
            estoque_reajuste_detalhe = new HashSet<EstoqueReajusteDetalhe>();
            ficha_tecnica = new HashSet<FichaTecnica>();
            fornecedor_produto = new HashSet<FornecedorProduto>();
            inventario_contagem_det = new HashSet<InventarioContagemDetalhe>();
            nfe_detalhe = new HashSet<NFe_Detalhe>();
            pre_venda_detalhe = new HashSet<PreVendaDetalhe>();
            produto_alteracao_item = new HashSet<ProdutoAlteracaoItem>();
            produto_codigo_adicional = new HashSet<ProdutoCodigoAdicional>();
            produto_combo_item = new HashSet<ProdutoComboItem>();
            produto_lacre_entrada = new HashSet<ProdutoLacreEntrada>();
            produto_lote = new HashSet<ProdutoLote>();
            produto_promocao = new HashSet<ProdutoPromocao>();
            requisicao_interna_detalhe = new HashSet<RequisicaoInternaDetalhe>();
            tabela_preco_produto = new HashSet<TabelaPrecoProduto>();
            unidade_conversao = new HashSet<UnidadeConversao>();
            venda_detalhe = new HashSet<VendaDetalhe>();
            venda_orcamento_detalhe = new HashSet<VendaOrcamentoDetalhe>();
        }

        public int id { get; set; }

        public int id_subgrupo { get; set; }

        public int? id_tribut_icms_custom_cab { get; set; }

        public int id_unidade_produto { get; set; }

        public int? id_almoxarifado { get; set; }

        public int? id_grupo_tributario { get; set; }

        public int? id_marca_produto { get; set; }

        [StringLength(14)]
        public string gtin { get; set; }

        [StringLength(60)]
        public string codigo_interno { get; set; }

        [StringLength(8)]
        public string ncm { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [StringLength(30)]
        public string descricao_pdv { get; set; }

        public decimal? valor_compra { get; set; }

        public decimal? valor_venda { get; set; }

        public decimal? preco_venda_minimo { get; set; }

        public decimal? preco_sugerido { get; set; }

        public decimal? custo_unitario { get; set; }

        public decimal? custo_producao { get; set; }

        public decimal? custo_medio_liquido { get; set; }

        public decimal? preco_lucro_zero { get; set; }

        public decimal? preco_lucro_minimo { get; set; }

        public decimal? preco_lucro_maximo { get; set; }

        public decimal? markup { get; set; }

        public decimal? quantidade_estoque { get; set; }

        public decimal? quantidade_estoque_anterior { get; set; }

        public decimal? estoque_minimo { get; set; }

        public decimal? estoque_maximo { get; set; }

        public decimal? estoque_ideal { get; set; }

        [StringLength(1)]
        public string excluido { get; set; }

        [StringLength(1)]
        public string inativo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        public string imagem { get; set; }

        [StringLength(3)]
        public string ex_tipi { get; set; }

        [StringLength(4)]
        public string codigo_lst { get; set; }

        [StringLength(1)]
        public string classe_abc { get; set; }

        [StringLength(1)]
        public string iat { get; set; }

        [StringLength(1)]
        public string ippt { get; set; }

        [StringLength(2)]
        public string tipo_item_sped { get; set; }

        public decimal? peso { get; set; }

        public decimal? porcento_comissao { get; set; }

        public decimal? ponto_pedido { get; set; }

        public decimal? lote_economico_compra { get; set; }

        public decimal? aliquota_icms_paf { get; set; }

        public decimal? aliquota_issqn_paf { get; set; }

        [StringLength(10)]
        public string totalizador_parcial { get; set; }

        public int? codigo_balanca { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_alteracao { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(1)]
        public string servico { get; set; }

        [StringLength(10)]
        public string cest { get; set; }

        public virtual Almoxarifado almoxarifado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComissaoObjetivo> comissao_objetivo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraCotacaoDetalhe> compra_cotacao_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraPedidoDetalhe> compra_pedido_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraRequisicaoDetalhe> compra_requisicao_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_Detalhe> dav_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaProduto> empresa_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueGrade> estoque_grade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueReajusteDetalhe> estoque_reajuste_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FichaTecnica> ficha_tecnica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FornecedorProduto> fornecedor_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventarioContagemDetalhe> inventario_contagem_det { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Detalhe> nfe_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreVendaDetalhe> pre_venda_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoAlteracaoItem> produto_alteracao_item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoCodigoAdicional> produto_codigo_adicional { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoComboItem> produto_combo_item { get; set; }

        public virtual Tribut_GrupoTributario tribut_grupo_tributario { get; set; }

        public virtual ProdutoMarca produto_marca { get; set; }

        public virtual ProdutoSubgrupo produto_subgrupo { get; set; }

        public virtual Tribut_ICMSCustomizadoCabecalho tribut_icms_custom_cab { get; set; }

        public virtual UnidadeProduto unidade_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoLacreEntrada> produto_lacre_entrada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoLote> produto_lote { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoPromocao> produto_promocao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequisicaoInternaDetalhe> requisicao_interna_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabelaPrecoProduto> tabela_preco_produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnidadeConversao> unidade_conversao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaDetalhe> venda_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaOrcamentoDetalhe> venda_orcamento_detalhe { get; set; }
    }
}
