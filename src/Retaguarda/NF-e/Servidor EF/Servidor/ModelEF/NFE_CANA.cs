namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_CANA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFE_CANA()
        {
            NFE_CANA_FORNECIMENTO_DIARIO = new HashSet<NFE_CANA_FORNECIMENTO_DIARIO>();
            NFE_CANA_DEDUCOES_SAFRA = new HashSet<NFE_CANA_DEDUCOES_SAFRA>();
        }

        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        [StringLength(9)]
        public string SAFRA { get; set; }

        [StringLength(9)]
        public string MES_ANO_REFERENCIA { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CANA_FORNECIMENTO_DIARIO> NFE_CANA_FORNECIMENTO_DIARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CANA_DEDUCOES_SAFRA> NFE_CANA_DEDUCOES_SAFRA { get; set; }
    }
}
