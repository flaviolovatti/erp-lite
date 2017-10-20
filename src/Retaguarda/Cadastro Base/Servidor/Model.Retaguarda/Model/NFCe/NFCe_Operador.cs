namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_operador")]
    public partial class NFCe_Operador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCe_Operador()
        {
            nfce_movimento = new HashSet<NFCe_Movimento>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string login { get; set; }

        [StringLength(20)]
        public string senha { get; set; }

        [StringLength(1)]
        public string nivel_autorizacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Movimento> nfce_movimento { get; set; }
    }
}
