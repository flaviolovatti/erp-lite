namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.plano_centro_resultado")]
    public partial class PlanoCentroResultado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanoCentroResultado()
        {
            centro_resultado = new HashSet<CentroResultado>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(50)]
        public string mascara { get; set; }

        public int? niveis { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inclusao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CentroResultado> centro_resultado { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
