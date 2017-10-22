namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tipo_receita_dipi")]
    public partial class tipo_receita_dipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_receita_dipi()
        {
            tribut_ipi_dipi = new HashSet<tribut_ipi_dipi>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_ipi_dipi> tribut_ipi_dipi { get; set; }
    }
}
