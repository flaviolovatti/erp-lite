namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tipo_colaborador")]
    public partial class tipo_colaborador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tipo_colaborador()
        {
            colaboradors = new HashSet<Colaborador>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaborador> colaboradors { get; set; }
    }
}
