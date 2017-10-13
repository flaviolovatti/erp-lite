namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRODUTO_LACRE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO_LACRE()
        {
            PRODUTO_LACRE_ENTRADA = new HashSet<PRODUTO_LACRE_ENTRADA>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(250)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO_LACRE_ENTRADA> PRODUTO_LACRE_ENTRADA { get; set; }
    }
}
