namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario")]
    public partial class CTe_Rodoviario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTe_Rodoviario()
        {
            cte_rodoviario_lacre = new HashSet<CTe_RodoviarioLacre>();
            cte_rodoviario_motorista = new HashSet<CTe_RodoviarioMotorista>();
            cte_rodoviario_occ = new HashSet<CTe_RodoviarioOcc>();
            cte_rodoviario_pedagio = new HashSet<CTe_RodoviarioPedagio>();
            cte_rodoviario_veiculo = new HashSet<CTe_RodoviarioVeiculo>();
        }

        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(8)]
        public string rntrc { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_RodoviarioLacre> cte_rodoviario_lacre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_RodoviarioMotorista> cte_rodoviario_motorista { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_RodoviarioOcc> cte_rodoviario_occ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_RodoviarioPedagio> cte_rodoviario_pedagio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_RodoviarioVeiculo> cte_rodoviario_veiculo { get; set; }
    }
}
