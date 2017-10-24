namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.municipio")]
    public partial class municipio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public municipio()
        {
            transportadora_municipio = new HashSet<transportadora_municipio>();
        }

        public int id { get; set; }

        public int id_uf { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public int? codigo_ibge { get; set; }

        public int? codigo_receita_federal { get; set; }

        public int? codigo_estadual { get; set; }

        [StringLength(2)]
        public string uf_sigla { get; set; }

        public virtual UF uf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transportadora_municipio> transportadora_municipio { get; set; }
    }
}
