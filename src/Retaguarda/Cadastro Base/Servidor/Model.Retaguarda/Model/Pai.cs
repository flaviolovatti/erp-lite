namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pais")]
    public partial class Pai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pai()
        {
            indice_economico = new HashSet<IndiceEconomico>();
            ufs = new HashSet<UF>();
        }

        public int id { get; set; }

        public int? codigo { get; set; }

        [StringLength(100)]
        public string nome_en { get; set; }

        [StringLength(100)]
        public string nome_ptbr { get; set; }

        [StringLength(2)]
        public string sigla2 { get; set; }

        [StringLength(3)]
        public string sigla3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndiceEconomico> indice_economico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UF> ufs { get; set; }
    }
}
