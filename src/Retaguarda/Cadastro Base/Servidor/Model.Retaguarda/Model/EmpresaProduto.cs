namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.empresa_produto")]
    public partial class EmpresaProduto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmpresaProduto()
        {
            estoque_grade = new HashSet<EstoqueGrade>();
        }

        public int id { get; set; }

        public int id_produto { get; set; }

        public int id_empresa { get; set; }

        public decimal? quantidade_estoque { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual Produto produto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueGrade> estoque_grade { get; set; }
    }
}
