namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_TIPO_REQUISICAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_TIPO_REQUISICAO()
        {
            COMPRA_REQUISICAO = new HashSet<COMPRA_REQUISICAO>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(2)]
        public string CODIGO { get; set; }

        [StringLength(30)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_REQUISICAO> COMPRA_REQUISICAO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
