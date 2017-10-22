namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.produto_combo")]
    public partial class ProdutoCombo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProdutoCombo()
        {
            produto_combo_item = new HashSet<ProdutoComboItem>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validade_inicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? validade_fim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProdutoComboItem> produto_combo_item { get; set; }
    }
}
