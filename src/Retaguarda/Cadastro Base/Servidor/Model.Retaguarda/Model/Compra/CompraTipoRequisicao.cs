namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_tipo_requisicao")]
    public partial class CompraTipoRequisicao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraTipoRequisicao()
        {
            compra_requisicao = new HashSet<CompraRequisicao>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(30)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraRequisicao> compra_requisicao { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
