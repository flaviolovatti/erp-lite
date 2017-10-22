namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.natureza_financeira")]
    public partial class natureza_financeira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public natureza_financeira()
        {
            ct_resultado_nt_financeira = new HashSet<ct_resultado_nt_financeira>();
            fin_lcto_pagar_nt_financeira = new HashSet<fin_lcto_pagar_nt_financeira>();
            fin_lcto_receber_nt_financeira = new HashSet<fin_lcto_receber_nt_financeira>();
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
        public virtual ICollection<ct_resultado_nt_financeira> ct_resultado_nt_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_lcto_pagar_nt_financeira> fin_lcto_pagar_nt_financeira { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_lcto_receber_nt_financeira> fin_lcto_receber_nt_financeira { get; set; }

        public virtual plano_natureza_financeira plano_natureza_financeira { get; set; }
    }
}
