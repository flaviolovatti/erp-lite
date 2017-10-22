namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nota_fiscal_modelo")]
    public partial class nota_fiscal_modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nota_fiscal_modelo()
        {
            nota_fiscal_tipo = new HashSet<nota_fiscal_tipo>();
        }

        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(10)]
        public string modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nota_fiscal_tipo> nota_fiscal_tipo { get; set; }
    }
}
