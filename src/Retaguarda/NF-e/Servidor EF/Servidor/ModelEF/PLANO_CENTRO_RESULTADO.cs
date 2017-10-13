namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PLANO_CENTRO_RESULTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANO_CENTRO_RESULTADO()
        {
            CENTRO_RESULTADO = new HashSet<CENTRO_RESULTADO>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(50)]
        public string MASCARA { get; set; }

        public int? NIVEIS { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INCLUSAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CENTRO_RESULTADO> CENTRO_RESULTADO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
