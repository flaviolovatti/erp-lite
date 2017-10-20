namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_requisicao")]
    public partial class CompraRequisicao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompraRequisicao()
        {
            compra_requisicao_detalhe = new HashSet<CompraRequisicaoDetalhe>();
        }

        public int id { get; set; }

        public int id_compra_tipo_requisicao { get; set; }

        public int id_colaborador { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_requisicao { get; set; }

        public string observacao { get; set; }

        public virtual Colaborador colaborador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompraRequisicaoDetalhe> compra_requisicao_detalhe { get; set; }

        public virtual CompraTipoRequisicao compra_tipo_requisicao { get; set; }
    }
}
