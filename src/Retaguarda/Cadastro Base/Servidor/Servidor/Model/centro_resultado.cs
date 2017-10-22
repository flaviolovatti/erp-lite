namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.centro_resultado")]
    public partial class centro_resultado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public centro_resultado()
        {
            ct_resultado_nt_financeira = new HashSet<ct_resultado_nt_financeira>();
        }

        public int id { get; set; }

        public int id_plano_centro_resultado { get; set; }

        [StringLength(30)]
        public string classificacao { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string sofre_rateiro { get; set; }

        public virtual plano_centro_resultado plano_centro_resultado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ct_resultado_nt_financeira> ct_resultado_nt_financeira { get; set; }
    }
}
