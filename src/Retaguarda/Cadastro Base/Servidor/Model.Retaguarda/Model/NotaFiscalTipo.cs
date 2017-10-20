namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nota_fiscal_tipo")]
    public partial class NotaFiscalTipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotaFiscalTipo()
        {
            venda_cabecalho = new HashSet<VendaCabecalho>();
        }

        public int id { get; set; }

        public int id_nota_fiscal_modelo { get; set; }

        public int id_empresa { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        [StringLength(3)]
        public string serie_scan { get; set; }

        public int? ultimo_numero { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual NotaFiscalModelo nota_fiscal_modelo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCabecalho> venda_cabecalho { get; set; }
    }
}
