namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAIS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PAIS()
        {
            INDICE_ECONOMICO = new HashSet<INDICE_ECONOMICO>();
            UF = new HashSet<UF>();
        }

        public int ID { get; set; }

        public int? CODIGO { get; set; }

        [StringLength(100)]
        public string NOME_EN { get; set; }

        [StringLength(100)]
        public string NOME_PTBR { get; set; }

        [StringLength(2)]
        public string SIGLA2 { get; set; }

        [StringLength(3)]
        public string SIGLA3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INDICE_ECONOMICO> INDICE_ECONOMICO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UF> UF { get; set; }
    }
}
