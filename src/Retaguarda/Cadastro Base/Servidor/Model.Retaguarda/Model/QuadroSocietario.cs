namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.quadro_societario")]
    public partial class QuadroSocietario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuadroSocietario()
        {
            socios = new HashSet<Socio>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_registro { get; set; }

        public decimal? capital_social { get; set; }

        public decimal? valor_quota { get; set; }

        public int? quantidade_cotas { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Socio> socios { get; set; }
    }
}
