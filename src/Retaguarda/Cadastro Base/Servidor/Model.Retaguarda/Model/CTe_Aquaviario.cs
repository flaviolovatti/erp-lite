namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_aquaviario")]
    public partial class CTe_Aquaviario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTe_Aquaviario()
        {
            cte_aquaviario_balsa = new HashSet<CTe_AquaviarioBalsa>();
        }

        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        public decimal? valor_prestacao { get; set; }

        public decimal? afrmm { get; set; }

        [StringLength(10)]
        public string numero_booking { get; set; }

        [StringLength(10)]
        public string numero_controle { get; set; }

        [StringLength(60)]
        public string id_navio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_AquaviarioBalsa> cte_aquaviario_balsa { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
