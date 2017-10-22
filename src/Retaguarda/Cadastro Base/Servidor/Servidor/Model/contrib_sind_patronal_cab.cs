namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.contrib_sind_patronal_cab")]
    public partial class contrib_sind_patronal_cab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contrib_sind_patronal_cab()
        {
            contrib_sind_patronal_det = new HashSet<contrib_sind_patronal_det>();
        }

        public int id { get; set; }

        public int id_sindicato { get; set; }

        [StringLength(4)]
        public string vigencia_ano { get; set; }

        public virtual sindicato sindicato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrib_sind_patronal_det> contrib_sind_patronal_det { get; set; }
    }
}
