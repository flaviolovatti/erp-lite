namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_CLIENTE_GRUPO_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_CLIENTE_GRUPO_CAB()
        {
            FIN_CLIENTE_GRUPO_DET = new HashSet<FIN_CLIENTE_GRUPO_DET>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CLIENTE_GRUPO_DET> FIN_CLIENTE_GRUPO_DET { get; set; }
    }
}
