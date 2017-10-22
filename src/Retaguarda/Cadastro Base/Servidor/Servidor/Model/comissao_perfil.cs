namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.comissao_perfil")]
    public partial class comissao_perfil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comissao_perfil()
        {
            comissao_objetivo = new HashSet<comissao_objetivo>();
            vendedors = new HashSet<vendedor>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(3)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comissao_objetivo> comissao_objetivo { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vendedor> vendedors { get; set; }
    }
}
