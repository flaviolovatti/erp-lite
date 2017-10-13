namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTOQUE_MARCA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTOQUE_MARCA()
        {
            ESTOQUE_GRADE = new HashSet<ESTOQUE_GRADE>();
        }

        public int ID { get; set; }

        [StringLength(4)]
        public string CODIGO { get; set; }

        [StringLength(20)]
        public string NOME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTOQUE_GRADE> ESTOQUE_GRADE { get; set; }
    }
}
