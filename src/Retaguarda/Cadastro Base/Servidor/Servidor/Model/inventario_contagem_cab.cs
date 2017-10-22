namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.inventario_contagem_cab")]
    public partial class inventario_contagem_cab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public inventario_contagem_cab()
        {
            inventario_contagem_det = new HashSet<inventario_contagem_det>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_contagem { get; set; }

        [StringLength(1)]
        public string estoque_atualizado { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inventario_contagem_det> inventario_contagem_det { get; set; }
    }
}
