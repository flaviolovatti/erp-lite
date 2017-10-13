namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMPRA_TIPO_PEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMPRA_TIPO_PEDIDO()
        {
            COMPRA_PEDIDO = new HashSet<COMPRA_PEDIDO>();
        }

        public int ID { get; set; }

        [StringLength(2)]
        public string CODIGO { get; set; }

        [StringLength(30)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA_PEDIDO> COMPRA_PEDIDO { get; set; }
    }
}
