namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cliente_grupo_cab")]
    public partial class fin_cliente_grupo_cab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_cliente_grupo_cab()
        {
            fin_cliente_grupo_det = new HashSet<fin_cliente_grupo_det>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cliente_grupo_det> fin_cliente_grupo_det { get; set; }
    }
}
