namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.estoque_sabor")]
    public partial class EstoqueSabor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstoqueSabor()
        {
            estoque_grade = new HashSet<EstoqueGrade>();
        }

        public int id { get; set; }

        [StringLength(4)]
        public string codigo { get; set; }

        [StringLength(20)]
        public string nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueGrade> estoque_grade { get; set; }
    }
}
