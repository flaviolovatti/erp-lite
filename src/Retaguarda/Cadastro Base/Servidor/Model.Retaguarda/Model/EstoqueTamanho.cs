namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.estoque_tamanho")]
    public partial class EstoqueTamanho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstoqueTamanho()
        {
            estoque_grade = new HashSet<EstoqueGrade>();
        }

        public int id { get; set; }

        [StringLength(4)]
        public string codigo { get; set; }

        [StringLength(20)]
        public string nome { get; set; }

        public decimal? altura { get; set; }

        public decimal? comprimento { get; set; }

        public decimal? largura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueGrade> estoque_grade { get; set; }
    }
}
