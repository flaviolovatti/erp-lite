namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAV_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAV_CABECALHO()
        {
            DAV_DETALHE = new HashSet<DAV_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? ID_PESSOA { get; set; }

        [StringLength(10)]
        public string NUMERO_DAV { get; set; }

        [StringLength(4)]
        public string NUMERO_ECF { get; set; }

        public int? CCF { get; set; }

        public int? COO { get; set; }

        [StringLength(100)]
        public string NOME_DESTINATARIO { get; set; }

        [StringLength(14)]
        public string CPF_CNPJ_DESTINATARIO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(8)]
        public string HORA_EMISSAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        public decimal? TAXA_ACRESCIMO { get; set; }

        public decimal? ACRESCIMO { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public decimal? DESCONTO { get; set; }

        public decimal? SUBTOTAL { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(1)]
        public string IMPRESSO { get; set; }

        [StringLength(32)]
        public string LOGSS { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_DETALHE> DAV_DETALHE { get; set; }
    }
}
