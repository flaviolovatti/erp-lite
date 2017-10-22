namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cheque")]
    public partial class cheque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cheque()
        {
            fin_cheque_emitido = new HashSet<fin_cheque_emitido>();
        }

        public int id { get; set; }

        public int id_talonario_cheque { get; set; }

        public int? numero { get; set; }

        [StringLength(1)]
        public string status_cheque { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_status { get; set; }

        public virtual talonario_cheque talonario_cheque { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cheque_emitido> fin_cheque_emitido { get; set; }
    }
}
