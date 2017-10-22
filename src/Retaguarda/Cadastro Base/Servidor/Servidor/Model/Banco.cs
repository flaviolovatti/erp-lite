namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.banco")]
    public partial class Banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banco()
        {
            agencia_banco = new HashSet<agencia_banco>();
        }

        public int id { get; set; }

        [StringLength(10)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(250)]
        public string url { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agencia_banco> agencia_banco { get; set; }
    }
}
