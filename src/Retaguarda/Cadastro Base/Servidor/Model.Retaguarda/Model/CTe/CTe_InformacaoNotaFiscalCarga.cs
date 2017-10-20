namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_informacao_nf_carga")]
    public partial class CTe_InformacaoNotaFiscalCarga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTe_InformacaoNotaFiscalCarga()
        {
            cte_inf_nf_carga_lacre = new HashSet<CTe_InformacaoNotaFiscalCargaLacre>();
        }

        public int id { get; set; }

        public int id_cte_informacao_nf { get; set; }

        public int? tipo_unidade_carga { get; set; }

        [StringLength(20)]
        public string id_unidade_carga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTe_InformacaoNotaFiscalCargaLacre> cte_inf_nf_carga_lacre { get; set; }

        public virtual CTe_InformacaoNotaFiscalOutros cte_informacao_nf_outros { get; set; }
    }
}
