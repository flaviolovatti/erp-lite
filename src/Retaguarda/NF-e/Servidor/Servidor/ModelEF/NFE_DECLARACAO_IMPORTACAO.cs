namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DECLARACAO_IMPORTACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFE_DECLARACAO_IMPORTACAO()
        {
            NFE_IMPORTACAO_DETALHE = new HashSet<NFE_IMPORTACAO_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        [StringLength(12)]
        public string NUMERO_DOCUMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_REGISTRO { get; set; }

        [StringLength(60)]
        public string LOCAL_DESEMBARACO { get; set; }

        [StringLength(2)]
        public string UF_DESEMBARACO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_DESEMBARACO { get; set; }

        [StringLength(60)]
        public string CODIGO_EXPORTADOR { get; set; }

        public int? VIA_TRANSPORTE { get; set; }

        public decimal? VALOR_AFRMM { get; set; }

        public int? FORMA_INTERMEDIACAO { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(2)]
        public string UF_TERCEIRO { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_IMPORTACAO_DETALHE> NFE_IMPORTACAO_DETALHE { get; set; }
    }
}
