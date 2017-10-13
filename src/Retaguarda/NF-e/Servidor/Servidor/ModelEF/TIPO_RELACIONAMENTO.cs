namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_RELACIONAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_RELACIONAMENTO()
        {
            COLABORADOR_RELACIONAMENTO = new HashSet<COLABORADOR_RELACIONAMENTO>();
            SOCIO_DEPENDENTE = new HashSet<SOCIO_DEPENDENTE>();
        }

        public int ID { get; set; }

        [StringLength(3)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR_RELACIONAMENTO> COLABORADOR_RELACIONAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOCIO_DEPENDENTE> SOCIO_DEPENDENTE { get; set; }
    }
}
