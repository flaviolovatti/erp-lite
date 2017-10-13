namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USUARIO")]
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            AUDITORIA = new HashSet<AUDITORIA>();
        }

        public int ID { get; set; }

        public int ID_COLABORADOR { get; set; }

        public int ID_PAPEL { get; set; }

        [StringLength(20)]
        public string LOGIN { get; set; }

        [StringLength(40)]
        public string SENHA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [StringLength(1)]
        public string ADMINISTRADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUDITORIA> AUDITORIA { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        public virtual PAPEL PAPEL { get; set; }
    }
}
