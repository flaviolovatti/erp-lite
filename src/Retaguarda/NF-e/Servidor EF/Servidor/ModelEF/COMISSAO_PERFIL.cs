namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMISSAO_PERFIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMISSAO_PERFIL()
        {
            COMISSAO_OBJETIVO = new HashSet<COMISSAO_OBJETIVO>();
            VENDEDOR = new HashSet<VENDEDOR>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(3)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_OBJETIVO> COMISSAO_OBJETIVO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDEDOR> VENDEDOR { get; set; }
    }
}
