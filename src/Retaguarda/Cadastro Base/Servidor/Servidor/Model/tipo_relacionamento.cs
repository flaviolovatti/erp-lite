namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tipo_relacionamento")]
    public partial class tipo_relacionamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_relacionamento()
        {
            colaborador_relacionamento = new HashSet<colaborador_relacionamento>();
            socio_dependente = new HashSet<socio_dependente>();
        }

        public int id { get; set; }

        [StringLength(3)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<colaborador_relacionamento> colaborador_relacionamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<socio_dependente> socio_dependente { get; set; }
    }
}
