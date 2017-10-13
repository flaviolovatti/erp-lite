namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_RODOVIARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_RODOVIARIO()
        {
            CTE_RODOVIARIO_MOTORISTA = new HashSet<CTE_RODOVIARIO_MOTORISTA>();
            CTE_RODOVIARIO_LACRE = new HashSet<CTE_RODOVIARIO_LACRE>();
            CTE_RODOVIARIO_OCC = new HashSet<CTE_RODOVIARIO_OCC>();
            CTE_RODOVIARIO_PEDAGIO = new HashSet<CTE_RODOVIARIO_PEDAGIO>();
            CTE_RODOVIARIO_VEICULO = new HashSet<CTE_RODOVIARIO_VEICULO>();
        }

        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(8)]
        public string RNTRC { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RODOVIARIO_MOTORISTA> CTE_RODOVIARIO_MOTORISTA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RODOVIARIO_LACRE> CTE_RODOVIARIO_LACRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RODOVIARIO_OCC> CTE_RODOVIARIO_OCC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RODOVIARIO_PEDAGIO> CTE_RODOVIARIO_PEDAGIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_RODOVIARIO_VEICULO> CTE_RODOVIARIO_VEICULO { get; set; }
    }
}
