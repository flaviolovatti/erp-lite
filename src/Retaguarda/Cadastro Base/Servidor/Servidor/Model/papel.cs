namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.papel")]
    public partial class papel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public papel()
        {
            papel_funcao = new HashSet<papel_funcao>();
            usuarios = new HashSet<Usuario>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [StringLength(1)]
        public string acesso_completo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<papel_funcao> papel_funcao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> usuarios { get; set; }
    }
}
