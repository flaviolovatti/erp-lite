namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_COLABORADOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_COLABORADOR()
        {
            COLABORADOR = new HashSet<COLABORADOR>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR> COLABORADOR { get; set; }
    }
}
