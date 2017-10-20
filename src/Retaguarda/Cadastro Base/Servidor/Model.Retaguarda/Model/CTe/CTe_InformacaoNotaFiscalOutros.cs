namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_informacao_nf_outros")]
    public partial class CTe_InformacaoNotaFiscalOutros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTe_InformacaoNotaFiscalOutros()
        {
            cte_informacao_nf_carga = new HashSet<CTe_InformacaoNotaFiscalCarga>();
            cte_informacao_nf_transporte = new HashSet<CTe_InformacaoNotaFiscalTransporte>();
        }

        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(20)]
        public string numero_romaneio { get; set; }

        [StringLength(20)]
        public string numero_pedido { get; set; }

        [StringLength(44)]
        public string chave_acesso_nfe { get; set; }

        [StringLength(2)]
        public string codigo_modelo { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        [StringLength(20)]
        public string numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        public int? uf_emitente { get; set; }

        public decimal? base_calculo_icms { get; set; }

        public decimal? valor_icms { get; set; }

        public decimal? base_calculo_icms_st { get; set; }

        public decimal? valor_icms_st { get; set; }

        public decimal? valor_total_produtos { get; set; }

        public decimal? valor_total { get; set; }

        public int? cfop_predominante { get; set; }

        public decimal? peso_total_kg { get; set; }

        public int? pin_suframa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_prevista_entrega { get; set; }

        [StringLength(2)]
        public string outro_tipo_doc_orig { get; set; }

        [StringLength(100)]
        public string outro_descricao { get; set; }

        public decimal? outro_valor_documento { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_InformacaoNotaFiscalCarga> cte_informacao_nf_carga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_InformacaoNotaFiscalTransporte> cte_informacao_nf_transporte { get; set; }
    }
}
