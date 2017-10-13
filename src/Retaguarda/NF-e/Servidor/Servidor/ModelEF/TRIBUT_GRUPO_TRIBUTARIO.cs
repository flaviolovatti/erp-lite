namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_GRUPO_TRIBUTARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIBUT_GRUPO_TRIBUTARIO()
        {
            PRODUTO = new HashSet<PRODUTO>();
            TRIBUT_CONFIGURA_OF_GT = new HashSet<TRIBUT_CONFIGURA_OF_GT>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string ORIGEM_MERCADORIA { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_CONFIGURA_OF_GT> TRIBUT_CONFIGURA_OF_GT { get; set; }
    }
}
