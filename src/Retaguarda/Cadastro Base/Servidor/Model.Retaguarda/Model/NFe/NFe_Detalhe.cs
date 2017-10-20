namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe")]
    public partial class NFe_Detalhe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFe_Detalhe()
        {
            nfe_declaracao_importacao = new HashSet<NFe_DeclaracaoImportacao>();
            nfe_det_especifico_armamento = new HashSet<NFe_DetalheEspecificoArmamento>();
            nfe_det_especifico_combustivel = new HashSet<NFe_DetalheEspecificoCombustivel>();
            nfe_det_especifico_medicamento = new HashSet<NFe_DetalheEspecificoMedicamento>();
            nfe_det_especifico_veiculo = new HashSet<NFe_DetalheEspecificoVeiculo>();
            nfe_detalhe_imposto_cofins = new HashSet<NFe_DetalheImpostoCofins>();
            nfe_detalhe_imposto_icms = new HashSet<NFe_DetalheImpostoICMS>();
            nfe_detalhe_imposto_ii = new HashSet<NFe_DetalheImposto_II>();
            nfe_detalhe_imposto_ipi = new HashSet<NFe_DetalheImpostoIPI>();
            nfe_detalhe_imposto_issqn = new HashSet<NFe_DetalheImpostoISSQN>();
            nfe_detalhe_imposto_pis = new HashSet<NFe_DetalheImpostoPIS>();
            nfe_detalhe_rastro = new HashSet<NFe_DetalheRastro>();
            nfe_exportacao = new HashSet<NFe_Exportacao>();
        }

        public int id { get; set; }

        public int? id_produto { get; set; }

        public int id_nfe_cabecalho { get; set; }

        public int? numero_item { get; set; }

        [StringLength(60)]
        public string codigo_produto { get; set; }

        [StringLength(14)]
        public string gtin { get; set; }

        [StringLength(120)]
        public string nome_produto { get; set; }

        [StringLength(8)]
        public string ncm { get; set; }

        [StringLength(6)]
        public string nve { get; set; }

        public int? ex_tipi { get; set; }

        public int? cfop { get; set; }

        [StringLength(6)]
        public string unidade_comercial { get; set; }

        public decimal? quantidade_comercial { get; set; }

        public decimal? valor_unitario_comercial { get; set; }

        public decimal? valor_bruto_produto { get; set; }

        [StringLength(14)]
        public string gtin_unidade_tributavel { get; set; }

        [StringLength(6)]
        public string unidade_tributavel { get; set; }

        public decimal? quantidade_tributavel { get; set; }

        public decimal? valor_unitario_tributavel { get; set; }

        public decimal? valor_frete { get; set; }

        public decimal? valor_seguro { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_outras_despesas { get; set; }

        public int? entra_total { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? valor_total { get; set; }

        [StringLength(15)]
        public string numero_pedido_compra { get; set; }

        public int? item_pedido_compra { get; set; }

        public string informacoes_adicionais { get; set; }

        [StringLength(36)]
        public string numero_fci { get; set; }

        [StringLength(20)]
        public string numero_recopi { get; set; }

        public decimal? valor_total_tributos { get; set; }

        public decimal? percentual_devolvido { get; set; }

        public decimal? valor_ipi_devolvido { get; set; }

        [StringLength(10)]
        public string cest { get; set; }

        [StringLength(1)]
        public string indicador_escala_relevante { get; set; }

        [StringLength(14)]
        public string cnpj_fabricante { get; set; }

        [StringLength(10)]
        public string codigo_beneficio_fiscal { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DeclaracaoImportacao> nfe_declaracao_importacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheEspecificoArmamento> nfe_det_especifico_armamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheEspecificoCombustivel> nfe_det_especifico_combustivel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheEspecificoMedicamento> nfe_det_especifico_medicamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheEspecificoVeiculo> nfe_det_especifico_veiculo { get; set; }

        public virtual Produto produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheImpostoCofins> nfe_detalhe_imposto_cofins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheImpostoICMS> nfe_detalhe_imposto_icms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheImposto_II> nfe_detalhe_imposto_ii { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheImpostoIPI> nfe_detalhe_imposto_ipi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheImpostoISSQN> nfe_detalhe_imposto_issqn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheImpostoPIS> nfe_detalhe_imposto_pis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_DetalheRastro> nfe_detalhe_rastro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Exportacao> nfe_exportacao { get; set; }
    }
}
