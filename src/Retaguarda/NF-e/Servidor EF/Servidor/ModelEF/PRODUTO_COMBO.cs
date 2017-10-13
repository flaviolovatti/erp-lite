namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_COMBO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO_COMBO()
        {
            PRODUTO_COMBO_ITEM = new HashSet<PRODUTO_COMBO_ITEM>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALIDADE_INICIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALIDADE_FIM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_COMBO_ITEM> PRODUTO_COMBO_ITEM { get; set; }
    }
}
