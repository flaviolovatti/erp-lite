namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.uf")]
    public partial class UF
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UF()
        {
            municipios = new HashSet<Municipio>();
        }

        public int id { get; set; }

        public int id_pais { get; set; }

        [StringLength(2)]
        public string sigla { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public int? codigo_ibge { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Municipio> municipios { get; set; }

        public virtual Pai pai { get; set; }
    }
}
