namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_status_parcela")]
    public partial class FIN_StatusParcela
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_StatusParcela()
        {
            fin_parcela_pagar = new HashSet<FIN_ParcelaPagar>();
            fin_parcela_receber = new HashSet<FIN_ParcelaReceber>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [Required]
        [StringLength(2)]
        public string situacao { get; set; }

        [StringLength(30)]
        public string descricao { get; set; }

        public string procedimento { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaPagar> fin_parcela_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaReceber> fin_parcela_receber { get; set; }
    }
}
