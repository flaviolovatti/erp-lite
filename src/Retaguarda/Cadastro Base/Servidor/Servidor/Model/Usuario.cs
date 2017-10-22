namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            auditorias = new HashSet<auditoria>();
        }

        public int id { get; set; }

        public int id_colaborador { get; set; }

        public int id_papel { get; set; }

        [StringLength(20)]
        public string login { get; set; }

        [StringLength(40)]
        public string senha { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        [StringLength(1)]
        public string administrador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auditoria> auditorias { get; set; }

        public virtual Colaborador colaborador { get; set; }

        public virtual papel papel { get; set; }
    }
}
