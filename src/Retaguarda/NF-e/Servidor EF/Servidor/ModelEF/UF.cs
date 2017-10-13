namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UF")]
    public partial class UF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UF()
        {
            MUNICIPIO = new HashSet<MUNICIPIO>();
        }

        public int ID { get; set; }

        public int ID_PAIS { get; set; }

        [StringLength(2)]
        public string SIGLA { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        public int? CODIGO_IBGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUNICIPIO> MUNICIPIO { get; set; }

        public virtual PAIS PAIS { get; set; }
    }
}
