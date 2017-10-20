namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.natureza_financeira")]
    public partial class NaturezaFinanceira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaturezaFinanceira()
        {
            ct_resultado_nt_financeira = new HashSet<CentroResultadoNaturezaFinanceira>();
            fin_lcto_pagar_nt_financeira = new HashSet<FIN_LancamentoPagarNotaFinanceira>();
            fin_lcto_receber_nt_financeira = new HashSet<FIN_LancamentoReceberNotaFinanceira>();
        }

        public int id { get; set; }

        public int id_plano_natureza_financeira { get; set; }

        [StringLength(30)]
        public string classificacao { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(250)]
        public string aplicacao { get; set; }

        [StringLength(1)]
        public string aparece_a_pagar { get; set; }

        [StringLength(1)]
        public string aparece_a_receber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CentroResultadoNaturezaFinanceira> ct_resultado_nt_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoPagarNotaFinanceira> fin_lcto_pagar_nt_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoReceberNotaFinanceira> fin_lcto_receber_nt_financeira { get; set; }

        public virtual PlanoNaturezaFinanceira plano_natureza_financeira { get; set; }
    }
}
