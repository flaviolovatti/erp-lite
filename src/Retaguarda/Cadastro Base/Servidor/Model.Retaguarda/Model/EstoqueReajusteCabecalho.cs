namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.estoque_reajuste_cabecalho")]
    public partial class EstoqueReajusteCabecalho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstoqueReajusteCabecalho()
        {
            estoque_reajuste_detalhe = new HashSet<EstoqueReajusteDetalhe>();
        }

        public int id { get; set; }

        public int id_colaborador { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_reajuste { get; set; }

        public decimal? porcentagem { get; set; }

        [StringLength(1)]
        public string tipo_reajuste { get; set; }

        [StringLength(100)]
        public string justificativa { get; set; }

        public decimal? quantidade_fixa { get; set; }

        [StringLength(1)]
        public string campo_reajuste { get; set; }

        public virtual Colaborador colaborador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstoqueReajusteDetalhe> estoque_reajuste_detalhe { get; set; }
    }
}
