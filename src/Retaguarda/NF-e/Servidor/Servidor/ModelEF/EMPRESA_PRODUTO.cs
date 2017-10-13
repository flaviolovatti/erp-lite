namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMPRESA_PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA_PRODUTO()
        {
            ESTOQUE_GRADE = new HashSet<ESTOQUE_GRADE>();
        }

        public int ID { get; set; }

        public int ID_PRODUTO { get; set; }

        public int ID_EMPRESA { get; set; }

        public decimal? QUANTIDADE_ESTOQUE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTOQUE_GRADE> ESTOQUE_GRADE { get; set; }
    }
}
