namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cargo")]
    public partial class Cargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cargo()
        {
            colaboradors = new HashSet<Colaborador>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public string descricao { get; set; }

        public decimal? salario { get; set; }

        [StringLength(10)]
        public string cbo_1994 { get; set; }

        [StringLength(10)]
        public string cbo_2002 { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaborador> colaboradors { get; set; }
    }
}
