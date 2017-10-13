namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UNIDADE_PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIDADE_PRODUTO()
        {
            PRODUTO = new HashSet<PRODUTO>();
            UNIDADE_CONVERSAO = new HashSet<UNIDADE_CONVERSAO>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string SIGLA { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string PODE_FRACIONAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUTO> PRODUTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIDADE_CONVERSAO> UNIDADE_CONVERSAO { get; set; }
    }
}
