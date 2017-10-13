namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRODUTO")]
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            COMISSAO_OBJETIVO = new HashSet<COMISSAO_OBJETIVO>();
            COMPRA_COTACAO_DETALHE = new HashSet<COMPRA_COTACAO_DETALHE>();
            COMPRA_PEDIDO_DETALHE = new HashSet<COMPRA_PEDIDO_DETALHE>();
            COMPRA_REQUISICAO_DETALHE = new HashSet<COMPRA_REQUISICAO_DETALHE>();
            DAV_DETALHE = new HashSet<DAV_DETALHE>();
            EMPRESA_PRODUTO = new HashSet<EMPRESA_PRODUTO>();
            ESTOQUE_GRADE = new HashSet<ESTOQUE_GRADE>();
            ESTOQUE_REAJUSTE_DETALHE = new HashSet<ESTOQUE_REAJUSTE_DETALHE>();
            FICHA_TECNICA = new HashSet<FICHA_TECNICA>();
            FORNECEDOR_PRODUTO = new HashSet<FORNECEDOR_PRODUTO>();
            INVENTARIO_CONTAGEM_DET = new HashSet<INVENTARIO_CONTAGEM_DET>();
            NFE_DETALHE = new HashSet<NFE_DETALHE>();
            PRE_VENDA_DETALHE = new HashSet<PRE_VENDA_DETALHE>();
            PRODUTO_ALTERACAO_ITEM = new HashSet<PRODUTO_ALTERACAO_ITEM>();
            PRODUTO_COMBO_ITEM = new HashSet<PRODUTO_COMBO_ITEM>();
            PRODUTO_CODIGO_ADICIONAL = new HashSet<PRODUTO_CODIGO_ADICIONAL>();
            PRODUTO_LACRE_ENTRADA = new HashSet<PRODUTO_LACRE_ENTRADA>();
            PRODUTO_LOTE = new HashSet<PRODUTO_LOTE>();
            PRODUTO_PROMOCAO = new HashSet<PRODUTO_PROMOCAO>();
            REQUISICAO_INTERNA_DETALHE = new HashSet<REQUISICAO_INTERNA_DETALHE>();
            TABELA_PRECO_PRODUTO = new HashSet<TABELA_PRECO_PRODUTO>();
            UNIDADE_CONVERSAO = new HashSet<UNIDADE_CONVERSAO>();
            VENDA_DETALHE = new HashSet<VENDA_DETALHE>();
            VENDA_ORCAMENTO_DETALHE = new HashSet<VENDA_ORCAMENTO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_SUBGRUPO { get; set; }

        public int? ID_TRIBUT_ICMS_CUSTOM_CAB { get; set; }

        public int ID_UNIDADE_PRODUTO { get; set; }

        public int? ID_ALMOXARIFADO { get; set; }

        public int? ID_GRUPO_TRIBUTARIO { get; set; }

        public int? ID_MARCA_PRODUTO { get; set; }

        [StringLength(14)]
        public string GTIN { get; set; }

        [StringLength(60)]
        public string CODIGO_INTERNO { get; set; }

        [StringLength(8)]
        public string NCM { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(30)]
        public string DESCRICAO_PDV { get; set; }

        public decimal? VALOR_COMPRA { get; set; }

        public decimal? VALOR_VENDA { get; set; }

        public decimal? PRECO_VENDA_MINIMO { get; set; }

        public decimal? PRECO_SUGERIDO { get; set; }

        public decimal? CUSTO_UNITARIO { get; set; }

        public decimal? CUSTO_PRODUCAO { get; set; }

        public decimal? CUSTO_MEDIO_LIQUIDO { get; set; }

        public decimal? PRECO_LUCRO_ZERO { get; set; }

        public decimal? PRECO_LUCRO_MINIMO { get; set; }

        public decimal? PRECO_LUCRO_MAXIMO { get; set; }

        public decimal? MARKUP { get; set; }

        public decimal? QUANTIDADE_ESTOQUE { get; set; }

        public decimal? QUANTIDADE_ESTOQUE_ANTERIOR { get; set; }

        public decimal? ESTOQUE_MINIMO { get; set; }

        public decimal? ESTOQUE_MAXIMO { get; set; }

        public decimal? ESTOQUE_IDEAL { get; set; }

        [StringLength(1)]
        public string EXCLUIDO { get; set; }

        [StringLength(1)]
        public string INATIVO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "text")]
        public string IMAGEM { get; set; }

        [StringLength(3)]
        public string EX_TIPI { get; set; }

        [StringLength(4)]
        public string CODIGO_LST { get; set; }

        [StringLength(1)]
        public string CLASSE_ABC { get; set; }

        [StringLength(1)]
        public string IAT { get; set; }

        [StringLength(1)]
        public string IPPT { get; set; }

        [StringLength(2)]
        public string TIPO_ITEM_SPED { get; set; }

        public decimal? PESO { get; set; }

        public decimal? PORCENTO_COMISSAO { get; set; }

        public decimal? PONTO_PEDIDO { get; set; }

        public decimal? LOTE_ECONOMICO_COMPRA { get; set; }

        public decimal? ALIQUOTA_ICMS_PAF { get; set; }

        public decimal? ALIQUOTA_ISSQN_PAF { get; set; }

        [StringLength(10)]
        public string TOTALIZADOR_PARCIAL { get; set; }

        public int? CODIGO_BALANCA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ALTERACAO { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        [StringLength(1)]
        public string SERVICO { get; set; }

        public virtual ALMOXARIFADO ALMOXARIFADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_OBJETIVO> COMISSAO_OBJETIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_COTACAO_DETALHE> COMPRA_COTACAO_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_PEDIDO_DETALHE> COMPRA_PEDIDO_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_REQUISICAO_DETALHE> COMPRA_REQUISICAO_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_DETALHE> DAV_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_PRODUTO> EMPRESA_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTOQUE_GRADE> ESTOQUE_GRADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTOQUE_REAJUSTE_DETALHE> ESTOQUE_REAJUSTE_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FICHA_TECNICA> FICHA_TECNICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORNECEDOR_PRODUTO> FORNECEDOR_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO_CONTAGEM_DET> INVENTARIO_CONTAGEM_DET { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE> NFE_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_VENDA_DETALHE> PRE_VENDA_DETALHE { get; set; }

        public virtual TRIBUT_GRUPO_TRIBUTARIO TRIBUT_GRUPO_TRIBUTARIO { get; set; }

        public virtual PRODUTO_MARCA PRODUTO_MARCA { get; set; }

        public virtual PRODUTO_SUBGRUPO PRODUTO_SUBGRUPO { get; set; }

        public virtual TRIBUT_ICMS_CUSTOM_CAB TRIBUT_ICMS_CUSTOM_CAB { get; set; }

        public virtual UNIDADE_PRODUTO UNIDADE_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_ALTERACAO_ITEM> PRODUTO_ALTERACAO_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_COMBO_ITEM> PRODUTO_COMBO_ITEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_CODIGO_ADICIONAL> PRODUTO_CODIGO_ADICIONAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_LACRE_ENTRADA> PRODUTO_LACRE_ENTRADA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_LOTE> PRODUTO_LOTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_PROMOCAO> PRODUTO_PROMOCAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUISICAO_INTERNA_DETALHE> REQUISICAO_INTERNA_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TABELA_PRECO_PRODUTO> TABELA_PRECO_PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIDADE_CONVERSAO> UNIDADE_CONVERSAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_DETALHE> VENDA_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ORCAMENTO_DETALHE> VENDA_ORCAMENTO_DETALHE { get; set; }
    }
}
