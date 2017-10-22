namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_tipo_pedido")]
    public partial class compra_tipo_pedido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra_tipo_pedido()
        {
            compra_pedido = new HashSet<compra_pedido>();
        }

        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(30)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_pedido> compra_pedido { get; set; }
    }
}
