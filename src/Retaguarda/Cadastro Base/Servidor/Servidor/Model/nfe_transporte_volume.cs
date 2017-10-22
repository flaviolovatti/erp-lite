namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_transporte_volume")]
    public partial class nfe_transporte_volume
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfe_transporte_volume()
        {
            nfe_transporte_volume_lacre = new HashSet<nfe_transporte_volume_lacre>();
        }

        public int id { get; set; }

        public int id_nfe_transporte { get; set; }

        public int? quantidade { get; set; }

        [StringLength(60)]
        public string especie { get; set; }

        [StringLength(60)]
        public string marca { get; set; }

        [StringLength(60)]
        public string numeracao { get; set; }

        public decimal? peso_liquido { get; set; }

        public decimal? peso_bruto { get; set; }

        public virtual nfe_transporte nfe_transporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_transporte_volume_lacre> nfe_transporte_volume_lacre { get; set; }
    }
}
