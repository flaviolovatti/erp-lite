namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUNICIPIO")]
    public partial class MUNICIPIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUNICIPIO()
        {
            TRANSPORTADORA_MUNICIPIO = new HashSet<TRANSPORTADORA_MUNICIPIO>();
        }

        public int ID { get; set; }

        public int ID_UF { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        public int? CODIGO_IBGE { get; set; }

        public int? CODIGO_RECEITA_FEDERAL { get; set; }

        public int? CODIGO_ESTADUAL { get; set; }

        [StringLength(2)]
        public string UF_SIGLA { get; set; }

        public virtual UF UF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSPORTADORA_MUNICIPIO> TRANSPORTADORA_MUNICIPIO { get; set; }
    }
}
