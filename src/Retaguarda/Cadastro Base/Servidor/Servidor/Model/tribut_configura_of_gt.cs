namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_configura_of_gt")]
    public partial class tribut_configura_of_gt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tribut_configura_of_gt()
        {
            tribut_cofins_cod_apuracao = new HashSet<tribut_cofins_cod_apuracao>();
            tribut_icms_uf = new HashSet<tribut_icms_uf>();
            tribut_ipi_dipi = new HashSet<tribut_ipi_dipi>();
            tribut_pis_cod_apuracao = new HashSet<tribut_pis_cod_apuracao>();
        }

        public int id { get; set; }

        public int id_tribut_grupo_tributario { get; set; }

        public int id_tribut_operacao_fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_cofins_cod_apuracao> tribut_cofins_cod_apuracao { get; set; }

        public virtual tribut_grupo_tributario tribut_grupo_tributario { get; set; }

        public virtual tribut_operacao_fiscal tribut_operacao_fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_icms_uf> tribut_icms_uf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_ipi_dipi> tribut_ipi_dipi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tribut_pis_cod_apuracao> tribut_pis_cod_apuracao { get; set; }
    }
}
