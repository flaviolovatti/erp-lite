namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRIBUT_OPERACAO_FISCAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRIBUT_OPERACAO_FISCAL()
        {
            CLIENTE = new HashSet<CLIENTE>();
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
            TRIBUT_CONFIGURA_OF_GT = new HashSet<TRIBUT_CONFIGURA_OF_GT>();
            TRIBUT_ISS = new HashSet<TRIBUT_ISS>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_NA_NF { get; set; }

        public int? CFOP { get; set; }

        [Column(TypeName = "text")]
        public string OBSERVACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_CONFIGURA_OF_GT> TRIBUT_CONFIGURA_OF_GT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRIBUT_ISS> TRIBUT_ISS { get; set; }
    }
}
