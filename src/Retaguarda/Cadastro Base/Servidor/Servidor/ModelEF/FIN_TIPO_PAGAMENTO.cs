namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_TIPO_PAGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_TIPO_PAGAMENTO()
        {
            FIN_PARCELA_PAGAMENTO = new HashSet<FIN_PARCELA_PAGAMENTO>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(30)]
        public string DESCRICAO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_PAGAMENTO> FIN_PARCELA_PAGAMENTO { get; set; }
    }
}
