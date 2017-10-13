namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class INVENTARIO_CONTAGEM_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVENTARIO_CONTAGEM_CAB()
        {
            INVENTARIO_CONTAGEM_DET = new HashSet<INVENTARIO_CONTAGEM_DET>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CONTAGEM { get; set; }

        [StringLength(1)]
        public string ESTOQUE_ATUALIZADO { get; set; }

        [StringLength(1)]
        public string TIPO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVENTARIO_CONTAGEM_DET> INVENTARIO_CONTAGEM_DET { get; set; }
    }
}
