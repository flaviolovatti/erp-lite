namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FUNCAO")]
    public partial class FUNCAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FUNCAO()
        {
            PAPEL_FUNCAO = new HashSet<PAPEL_FUNCAO>();
        }

        public int ID { get; set; }

        [StringLength(30)]
        public string DESCRICAO_MENU { get; set; }

        [StringLength(30)]
        public string IMAGEM_MENU { get; set; }

        [StringLength(30)]
        public string METODO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [StringLength(100)]
        public string FORMULARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAPEL_FUNCAO> PAPEL_FUNCAO { get; set; }
    }
}
