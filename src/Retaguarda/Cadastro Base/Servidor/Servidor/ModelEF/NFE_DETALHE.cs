namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DETALHE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFE_DETALHE()
        {
            NFE_DECLARACAO_IMPORTACAO = new HashSet<NFE_DECLARACAO_IMPORTACAO>();
            NFE_DET_ESPECIFICO_ARMAMENTO = new HashSet<NFE_DET_ESPECIFICO_ARMAMENTO>();
            NFE_DET_ESPECIFICO_COMBUSTIVEL = new HashSet<NFE_DET_ESPECIFICO_COMBUSTIVEL>();
            NFE_DET_ESPECIFICO_MEDICAMENTO = new HashSet<NFE_DET_ESPECIFICO_MEDICAMENTO>();
            NFE_DET_ESPECIFICO_VEICULO = new HashSet<NFE_DET_ESPECIFICO_VEICULO>();
            NFE_DETALHE_RASTRO = new HashSet<NFE_DETALHE_RASTRO>();
            NFE_DETALHE_IMPOSTO_II = new HashSet<NFE_DETALHE_IMPOSTO_II>();
            NFE_DETALHE_IMPOSTO_ICMS = new HashSet<NFE_DETALHE_IMPOSTO_ICMS>();
            NFE_DETALHE_IMPOSTO_COFINS = new HashSet<NFE_DETALHE_IMPOSTO_COFINS>();
            NFE_DETALHE_IMPOSTO_PIS = new HashSet<NFE_DETALHE_IMPOSTO_PIS>();
            NFE_DETALHE_IMPOSTO_ISSQN = new HashSet<NFE_DETALHE_IMPOSTO_ISSQN>();
            NFE_DETALHE_IMPOSTO_IPI = new HashSet<NFE_DETALHE_IMPOSTO_IPI>();
            NFE_EXPORTACAO = new HashSet<NFE_EXPORTACAO>();
        }

        public int ID { get; set; }

        public int? ID_PRODUTO { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        public int? NUMERO_ITEM { get; set; }

        [StringLength(60)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(14)]
        public string GTIN { get; set; }

        [StringLength(120)]
        public string NOME_PRODUTO { get; set; }

        [StringLength(8)]
        public string NCM { get; set; }

        [StringLength(6)]
        public string NVE { get; set; }

        public int? EX_TIPI { get; set; }

        public int? CFOP { get; set; }

        [StringLength(6)]
        public string UNIDADE_COMERCIAL { get; set; }

        public decimal? QUANTIDADE_COMERCIAL { get; set; }

        public decimal? VALOR_UNITARIO_COMERCIAL { get; set; }

        public decimal? VALOR_BRUTO_PRODUTO { get; set; }

        [StringLength(14)]
        public string GTIN_UNIDADE_TRIBUTAVEL { get; set; }

        [StringLength(6)]
        public string UNIDADE_TRIBUTAVEL { get; set; }

        public decimal? QUANTIDADE_TRIBUTAVEL { get; set; }

        public decimal? VALOR_UNITARIO_TRIBUTAVEL { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public decimal? VALOR_SEGURO { get; set; }

        public decimal? VALOR_DESCONTO { get; set; }

        public decimal? VALOR_OUTRAS_DESPESAS { get; set; }

        public int? ENTRA_TOTAL { get; set; }

        public decimal? VALOR_SUBTOTAL { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        [StringLength(15)]
        public string NUMERO_PEDIDO_COMPRA { get; set; }

        public int? ITEM_PEDIDO_COMPRA { get; set; }

        [Column(TypeName = "text")]
        public string INFORMACOES_ADICIONAIS { get; set; }

        [StringLength(36)]
        public string NUMERO_FCI { get; set; }

        [StringLength(20)]
        public string NUMERO_RECOPI { get; set; }

        public decimal? VALOR_TOTAL_TRIBUTOS { get; set; }

        public decimal? PERCENTUAL_DEVOLVIDO { get; set; }

        public decimal? VALOR_IPI_DEVOLVIDO { get; set; }

        public int? CEST { get; set; }

        [StringLength(1)]
        public string INDICADOR_ESCALA_RELEVANTE { get; set; }

        [StringLength(14)]
        public string CNPJ_FABRICANTE { get; set; }

        [StringLength(10)]
        public string CODIGO_BENEFICIO_FISCAL { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DECLARACAO_IMPORTACAO> NFE_DECLARACAO_IMPORTACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DET_ESPECIFICO_ARMAMENTO> NFE_DET_ESPECIFICO_ARMAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DET_ESPECIFICO_COMBUSTIVEL> NFE_DET_ESPECIFICO_COMBUSTIVEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DET_ESPECIFICO_MEDICAMENTO> NFE_DET_ESPECIFICO_MEDICAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DET_ESPECIFICO_VEICULO> NFE_DET_ESPECIFICO_VEICULO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_RASTRO> NFE_DETALHE_RASTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_IMPOSTO_II> NFE_DETALHE_IMPOSTO_II { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_IMPOSTO_ICMS> NFE_DETALHE_IMPOSTO_ICMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_IMPOSTO_COFINS> NFE_DETALHE_IMPOSTO_COFINS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_IMPOSTO_PIS> NFE_DETALHE_IMPOSTO_PIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_IMPOSTO_ISSQN> NFE_DETALHE_IMPOSTO_ISSQN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_DETALHE_IMPOSTO_IPI> NFE_DETALHE_IMPOSTO_IPI { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_EXPORTACAO> NFE_EXPORTACAO { get; set; }
    }
}
