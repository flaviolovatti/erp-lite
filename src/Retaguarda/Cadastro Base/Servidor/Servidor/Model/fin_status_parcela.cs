namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_status_parcela")]
    public partial class fin_status_parcela
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_status_parcela()
        {
            fin_parcela_pagar = new HashSet<fin_parcela_pagar>();
            fin_parcela_receber = new HashSet<fin_parcela_receber>();
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
        public virtual ICollection<fin_parcela_pagar> fin_parcela_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_receber> fin_parcela_receber { get; set; }
    }
}
