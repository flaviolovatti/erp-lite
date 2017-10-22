namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pais")]
    public partial class Pais
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pais()
        {
            indice_economico = new HashSet<indice_economico>();
            ufs = new HashSet<uf>();
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
        public virtual ICollection<indice_economico> indice_economico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uf> ufs { get; set; }
    }
}
