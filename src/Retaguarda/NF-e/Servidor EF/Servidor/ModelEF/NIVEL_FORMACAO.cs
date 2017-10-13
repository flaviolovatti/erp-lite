namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NIVEL_FORMACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NIVEL_FORMACAO()
        {
            COLABORADOR = new HashSet<COLABORADOR>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        public int? GRAU_INSTRUCAO_CAGED { get; set; }

        public int? GRAU_INSTRUCAO_SEFIP { get; set; }

        public int? GRAU_INSTRUCAO_RAIS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR> COLABORADOR { get; set; }
    }
}
