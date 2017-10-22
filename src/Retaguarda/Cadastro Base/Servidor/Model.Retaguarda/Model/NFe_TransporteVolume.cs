namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_transporte_volume")]
    public partial class NFe_TransporteVolume
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFe_TransporteVolume()
        {
            nfe_transporte_volume_lacre = new HashSet<NFe_TransporteVolumeLacre>();
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

        public virtual NFe_Transporte nfe_transporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_TransporteVolumeLacre> nfe_transporte_volume_lacre { get; set; }
    }
}
