namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nota_fiscal_modelo")]
    public partial class NotaFiscalModelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotaFiscalModelo()
        {
            nota_fiscal_tipo = new HashSet<NotaFiscalTipo>();
        }

        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(10)]
        public string modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaFiscalTipo> nota_fiscal_tipo { get; set; }
    }
}
