namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_lancamento_receber")]
    public partial class FIN_LancamentoReceber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_LancamentoReceber()
        {
            fin_lcto_receber_nt_financeira = new HashSet<FIN_LancamentoReceberNotaFinanceira>();
            fin_parcela_receber = new HashSet<FIN_ParcelaReceber>();
        }

        public int id { get; set; }

        public int id_fin_documento_origem { get; set; }

        public int id_cliente { get; set; }

        public int? quantidade_parcela { get; set; }

        public decimal? valor_total { get; set; }

        public decimal? valor_desconto_convenio { get; set; }

        public decimal? valor_a_receber { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_lancamento { get; set; }

        [StringLength(50)]
        public string numero_documento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? primeiro_vencimento { get; set; }

        public decimal? taxa_comissao { get; set; }

        public decimal? valor_comissao { get; set; }

        public int? intervalo_entre_parcelas { get; set; }

        [StringLength(3)]
        public string codigo_modulo_lcto { get; set; }

        public int? mesclado_para { get; set; }

        [StringLength(32)]
        public string hash_modulo_lcto { get; set; }

        public virtual Cliente cliente { get; set; }

        public virtual FIN_DocumentoOrigem fin_documento_origem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoReceberNotaFinanceira> fin_lcto_receber_nt_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaReceber> fin_parcela_receber { get; set; }
    }
}
