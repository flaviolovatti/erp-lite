namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NOTA_FISCAL_MODELO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOTA_FISCAL_MODELO()
        {
            NOTA_FISCAL_TIPO = new HashSet<NOTA_FISCAL_TIPO>();
        }

        public int ID { get; set; }

        [StringLength(2)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(10)]
        public string MODELO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTA_FISCAL_TIPO> NOTA_FISCAL_TIPO { get; set; }
    }
}
