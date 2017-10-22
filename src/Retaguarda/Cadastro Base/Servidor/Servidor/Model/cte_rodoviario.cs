namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario")]
    public partial class cte_rodoviario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cte_rodoviario()
        {
            cte_rodoviario_lacre = new HashSet<cte_rodoviario_lacre>();
            cte_rodoviario_motorista = new HashSet<cte_rodoviario_motorista>();
            cte_rodoviario_occ = new HashSet<cte_rodoviario_occ>();
            cte_rodoviario_pedagio = new HashSet<cte_rodoviario_pedagio>();
            cte_rodoviario_veiculo = new HashSet<cte_rodoviario_veiculo>();
        }

        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(8)]
        public string rntrc { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_rodoviario_lacre> cte_rodoviario_lacre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_rodoviario_motorista> cte_rodoviario_motorista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_rodoviario_occ> cte_rodoviario_occ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_rodoviario_pedagio> cte_rodoviario_pedagio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cte_rodoviario_veiculo> cte_rodoviario_veiculo { get; set; }
    }
}
