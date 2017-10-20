namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_cana")]
    public partial class NFe_Cana
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFe_Cana()
        {
            nfe_cana_deducoes_safra = new HashSet<NFe_CanaDeducoesSafra>();
            nfe_cana_fornecimento_diario = new HashSet<NFe_CanaFornecimentoDiario>();
        }

        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(9)]
        public string safra { get; set; }

        [StringLength(9)]
        public string mes_ano_referencia { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_CanaDeducoesSafra> nfe_cana_deducoes_safra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_CanaFornecimentoDiario> nfe_cana_fornecimento_diario { get; set; }
    }
}
