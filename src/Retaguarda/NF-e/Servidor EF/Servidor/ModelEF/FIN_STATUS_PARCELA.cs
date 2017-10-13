namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_STATUS_PARCELA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_STATUS_PARCELA()
        {
            FIN_PARCELA_PAGAR = new HashSet<FIN_PARCELA_PAGAR>();
            FIN_PARCELA_RECEBER = new HashSet<FIN_PARCELA_RECEBER>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [Required]
        [StringLength(2)]
        public string SITUACAO { get; set; }

        [StringLength(30)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "text")]
        public string PROCEDIMENTO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_PAGAR> FIN_PARCELA_PAGAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBER> FIN_PARCELA_RECEBER { get; set; }
    }
}
