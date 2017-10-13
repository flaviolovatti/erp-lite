namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRE_VENDA_CABECALHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRE_VENDA_CABECALHO()
        {
            PRE_VENDA_DETALHE = new HashSet<PRE_VENDA_DETALHE>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        public int? ID_PESSOA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO { get; set; }

        [StringLength(8)]
        public string HORA_EMISSAO { get; set; }

        [StringLength(1)]
        public string SITUACAO { get; set; }

        public int? CCF { get; set; }

        public decimal? VALOR { get; set; }

        [StringLength(100)]
        public string NOME_DESTINATARIO { get; set; }

        [StringLength(14)]
        public string CPF_CNPJ_DESTINATARIO { get; set; }

        public decimal? SUBTOTAL { get; set; }

        public decimal? DESCONTO { get; set; }

        public decimal? ACRESCIMO { get; set; }

        public decimal? TAXA_ACRESCIMO { get; set; }

        public decimal? TAXA_DESCONTO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual PESSOA PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_VENDA_DETALHE> PRE_VENDA_DETALHE { get; set; }
    }
}
