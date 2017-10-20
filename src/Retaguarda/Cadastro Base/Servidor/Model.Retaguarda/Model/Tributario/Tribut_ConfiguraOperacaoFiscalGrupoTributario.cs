namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_configura_of_gt")]
    public partial class Tribut_ConfiguraOperacaoFiscalGrupoTributario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tribut_ConfiguraOperacaoFiscalGrupoTributario()
        {
            tribut_cofins_cod_apuracao = new HashSet<Tribut_CofinsCodigoApuracao>();
            tribut_icms_uf = new HashSet<Tribut_ICMS_UF>();
            tribut_ipi_dipi = new HashSet<Tribut_IPI_DIPI>();
            tribut_pis_cod_apuracao = new HashSet<Tribut_PIS_CodigoApuracao>();
        }

        public int id { get; set; }

        public int id_tribut_grupo_tributario { get; set; }

        public int id_tribut_operacao_fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_CofinsCodigoApuracao> tribut_cofins_cod_apuracao { get; set; }

        public virtual Tribut_GrupoTributario tribut_grupo_tributario { get; set; }

        public virtual Tribut_OperacaoFiscal tribut_operacao_fiscal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_ICMS_UF> tribut_icms_uf { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_IPI_DIPI> tribut_ipi_dipi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tribut_PIS_CodigoApuracao> tribut_pis_cod_apuracao { get; set; }
    }
}
