namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_FERROVIARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTE_FERROVIARIO()
        {
            CTE_FERROVIARIO_FERROVIA = new HashSet<CTE_FERROVIARIO_FERROVIA>();
            CTE_FERROVIARIO_VAGAO = new HashSet<CTE_FERROVIARIO_VAGAO>();
        }

        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        public int? TIPO_TRAFEGO { get; set; }

        public int? RESPONSAVEL_FATURAMENTO { get; set; }

        public int? FERROVIA_EMITENTE_CTE { get; set; }

        [StringLength(10)]
        public string FLUXO { get; set; }

        [StringLength(7)]
        public string ID_TREM { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_FERROVIARIO_FERROVIA> CTE_FERROVIARIO_FERROVIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTE_FERROVIARIO_VAGAO> CTE_FERROVIARIO_VAGAO { get; set; }
    }
}
