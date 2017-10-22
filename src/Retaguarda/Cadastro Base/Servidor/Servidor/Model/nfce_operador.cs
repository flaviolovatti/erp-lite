namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_operador")]
    public partial class nfce_operador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfce_operador()
        {
            nfce_movimento = new HashSet<nfce_movimento>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string login { get; set; }

        [StringLength(20)]
        public string senha { get; set; }

        [StringLength(1)]
        public string nivel_autorizacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_movimento> nfce_movimento { get; set; }
    }
}
