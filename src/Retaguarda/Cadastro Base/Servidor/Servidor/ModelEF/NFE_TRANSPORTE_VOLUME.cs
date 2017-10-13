namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_TRANSPORTE_VOLUME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFE_TRANSPORTE_VOLUME()
        {
            NFE_TRANSPORTE_VOLUME_LACRE = new HashSet<NFE_TRANSPORTE_VOLUME_LACRE>();
        }

        public int ID { get; set; }

        public int ID_NFE_TRANSPORTE { get; set; }

        public int? QUANTIDADE { get; set; }

        [StringLength(60)]
        public string ESPECIE { get; set; }

        [StringLength(60)]
        public string MARCA { get; set; }

        [StringLength(60)]
        public string NUMERACAO { get; set; }

        public decimal? PESO_LIQUIDO { get; set; }

        public decimal? PESO_BRUTO { get; set; }

        public virtual NFE_TRANSPORTE NFE_TRANSPORTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_TRANSPORTE_VOLUME_LACRE> NFE_TRANSPORTE_VOLUME_LACRE { get; set; }
    }
}
