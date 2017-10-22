namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_turno")]
    public partial class NFCe_Turno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCe_Turno()
        {
            nfce_movimento = new HashSet<NFCe_Movimento>();
        }

        public int id { get; set; }

        [StringLength(10)]
        public string descricao { get; set; }

        [StringLength(8)]
        public string hora_inicio { get; set; }

        [StringLength(8)]
        public string hora_fim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Movimento> nfce_movimento { get; set; }
    }
}
