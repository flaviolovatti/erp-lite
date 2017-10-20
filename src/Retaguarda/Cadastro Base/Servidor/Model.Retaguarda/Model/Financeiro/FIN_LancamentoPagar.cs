namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_lancamento_pagar")]
    public partial class FIN_LancamentoPagar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_LancamentoPagar()
        {
            fin_lcto_pagar_nt_financeira = new HashSet<FIN_LancamentoPagarNotaFinanceira>();
            fin_parcela_pagar = new HashSet<FIN_ParcelaPagar>();
        }

        public int id { get; set; }

        public int id_fin_documento_origem { get; set; }

        public int id_fornecedor { get; set; }

        [StringLength(1)]
        public string pagamento_compartilhado { get; set; }

        public int? quantidade_parcela { get; set; }

        public decimal? valor_total { get; set; }

        public decimal? valor_a_pagar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_lancamento { get; set; }

        [StringLength(50)]
        public string numero_documento { get; set; }

        public string imagem_documento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? primeiro_vencimento { get; set; }

        [StringLength(3)]
        public string codigo_modulo_lcto { get; set; }

        public int? intervalo_entre_parcelas { get; set; }

        public int? mesclado_para { get; set; }

        [StringLength(32)]
        public string hash_modulo_lcto { get; set; }

        public virtual FIN_DocumentoOrigem fin_documento_origem { get; set; }

        public virtual Fornecedor fornecedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoPagarNotaFinanceira> fin_lcto_pagar_nt_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaPagar> fin_parcela_pagar { get; set; }
    }
}
