namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_icms_custom_cab")]
    public partial class tribut_icms_custom_cab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tribut_icms_custom_cab()
        {
            produtoes = new HashSet<Produto>();
            tribut_icms_custom_det = new HashSet<tribut_icms_custom_det>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(1)]
        public string origem_mercadoria { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produto> produtoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_icms_custom_det> tribut_icms_custom_det { get; set; }
    }
}
