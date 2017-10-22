namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.plano_natureza_financeira")]
    public partial class plano_natureza_financeira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public plano_natureza_financeira()
        {
            natureza_financeira = new HashSet<natureza_financeira>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inclusao { get; set; }

        [StringLength(50)]
        public string mascara { get; set; }

        public int? niveis { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<natureza_financeira> natureza_financeira { get; set; }
    }
}
