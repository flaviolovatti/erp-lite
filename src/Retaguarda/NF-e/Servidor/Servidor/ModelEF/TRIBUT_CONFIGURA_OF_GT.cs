namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_CONFIGURA_OF_GT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIBUT_CONFIGURA_OF_GT()
        {
            TRIBUT_COFINS_COD_APURACAO = new HashSet<TRIBUT_COFINS_COD_APURACAO>();
            TRIBUT_ICMS_UF = new HashSet<TRIBUT_ICMS_UF>();
            TRIBUT_IPI_DIPI = new HashSet<TRIBUT_IPI_DIPI>();
            TRIBUT_PIS_COD_APURACAO = new HashSet<TRIBUT_PIS_COD_APURACAO>();
        }

        public int ID { get; set; }

        public int ID_TRIBUT_GRUPO_TRIBUTARIO { get; set; }

        public int ID_TRIBUT_OPERACAO_FISCAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_COFINS_COD_APURACAO> TRIBUT_COFINS_COD_APURACAO { get; set; }

        public virtual TRIBUT_OPERACAO_FISCAL TRIBUT_OPERACAO_FISCAL { get; set; }

        public virtual TRIBUT_GRUPO_TRIBUTARIO TRIBUT_GRUPO_TRIBUTARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_ICMS_UF> TRIBUT_ICMS_UF { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_IPI_DIPI> TRIBUT_IPI_DIPI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_PIS_COD_APURACAO> TRIBUT_PIS_COD_APURACAO { get; set; }
    }
}
