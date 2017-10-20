namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.inventario_contagem_cab")]
    public partial class InventarioContagemCabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventarioContagemCabecalho()
        {
            inventario_contagem_det = new HashSet<InventarioContagemDetalhe>();
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
        public virtual ICollection<InventarioContagemDetalhe> inventario_contagem_det { get; set; }
    }
}
