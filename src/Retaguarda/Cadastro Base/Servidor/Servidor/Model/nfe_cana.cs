namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_cana")]
    public partial class nfe_cana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfe_cana()
        {
            nfe_cana_deducoes_safra = new HashSet<nfe_cana_deducoes_safra>();
            nfe_cana_fornecimento_diario = new HashSet<nfe_cana_fornecimento_diario>();
        }

        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(9)]
        public string safra { get; set; }

        [StringLength(9)]
        public string mes_ano_referencia { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_cana_deducoes_safra> nfe_cana_deducoes_safra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_cana_fornecimento_diario> nfe_cana_fornecimento_diario { get; set; }
    }
}
