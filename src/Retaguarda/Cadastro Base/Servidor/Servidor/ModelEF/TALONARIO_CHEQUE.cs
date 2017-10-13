namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TALONARIO_CHEQUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TALONARIO_CHEQUE()
        {
            CHEQUE = new HashSet<CHEQUE>();
        }

        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(10)]
        public string TALAO { get; set; }

        public int? NUMERO { get; set; }

        [StringLength(1)]
        public string STATUS_TALAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHEQUE> CHEQUE { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
