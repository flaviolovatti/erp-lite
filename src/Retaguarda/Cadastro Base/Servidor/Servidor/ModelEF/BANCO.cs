namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANCO")]
    public partial class BANCO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANCO()
        {
            AGENCIA_BANCO = new HashSet<AGENCIA_BANCO>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(250)]
        public string URL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENCIA_BANCO> AGENCIA_BANCO { get; set; }
    }
}
