namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_declaracao_importacao")]
    public partial class NFe_DeclaracaoImportacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFe_DeclaracaoImportacao()
        {
            nfe_importacao_detalhe = new HashSet<NFe_ImportacaoDetalhe>();
        }

        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        [StringLength(12)]
        public string numero_documento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_registro { get; set; }

        [StringLength(60)]
        public string local_desembaraco { get; set; }

        [StringLength(2)]
        public string uf_desembaraco { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_desembaraco { get; set; }

        [StringLength(60)]
        public string codigo_exportador { get; set; }

        public int? via_transporte { get; set; }

        public decimal? valor_afrmm { get; set; }

        public int? forma_intermediacao { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(2)]
        public string uf_terceiro { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_ImportacaoDetalhe> nfe_importacao_detalhe { get; set; }
    }
}
