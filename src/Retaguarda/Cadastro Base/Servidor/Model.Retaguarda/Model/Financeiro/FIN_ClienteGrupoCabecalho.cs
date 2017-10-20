namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cliente_grupo_cab")]
    public partial class FIN_ClienteGrupoCabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_ClienteGrupoCabecalho()
        {
            fin_cliente_grupo_det = new HashSet<FIN_ClienteGrupoDetalhe>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ClienteGrupoDetalhe> fin_cliente_grupo_det { get; set; }
    }
}
