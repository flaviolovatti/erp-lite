namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFCE_MOVIMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCE_MOVIMENTO()
        {
            NFCE_FECHAMENTO = new HashSet<NFCE_FECHAMENTO>();
            NFCE_SANGRIA = new HashSet<NFCE_SANGRIA>();
            NFCE_SUPRIMENTO = new HashSet<NFCE_SUPRIMENTO>();
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
        }

        public int ID { get; set; }

        public int ID_NFCE_CAIXA { get; set; }

        public int ID_NFCE_OPERADOR { get; set; }

        public int ID_NFCE_TURNO { get; set; }

        public int ID_EMPRESA { get; set; }

        public int ID_GERENTE_SUPERVISOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ABERTURA { get; set; }

        [StringLength(8)]
        public string HORA_ABERTURA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FECHAMENTO { get; set; }

        [StringLength(8)]
        public string HORA_FECHAMENTO { get; set; }

        public decimal? TOTAL_SUPRIMENTO { get; set; }

        public decimal? TOTAL_SANGRIA { get; set; }

        public decimal? TOTAL_NAO_FISCAL { get; set; }

        public decimal? TOTAL_VENDA { get; set; }

        public decimal? TOTAL_DESCONTO { get; set; }

        public decimal? TOTAL_ACRESCIMO { get; set; }

        public decimal? TOTAL_FINAL { get; set; }

        public decimal? TOTAL_RECEBIDO { get; set; }

        public decimal? TOTAL_TROCO { get; set; }

        public decimal? TOTAL_CANCELADO { get; set; }

        [StringLength(1)]
        public string STATUS_MOVIMENTO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual NFCE_CAIXA NFCE_CAIXA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_FECHAMENTO> NFCE_FECHAMENTO { get; set; }

        public virtual NFCE_TURNO NFCE_TURNO { get; set; }

        public virtual NFCE_OPERADOR NFCE_OPERADOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_SANGRIA> NFCE_SANGRIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCE_SUPRIMENTO> NFCE_SUPRIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }
    }
}
