namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_LANCAMENTO_RECEBER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_LANCAMENTO_RECEBER()
        {
            FIN_LCTO_RECEBER_NT_FINANCEIRA = new HashSet<FIN_LCTO_RECEBER_NT_FINANCEIRA>();
            FIN_PARCELA_RECEBER = new HashSet<FIN_PARCELA_RECEBER>();
        }

        public int ID { get; set; }

        public int ID_FIN_DOCUMENTO_ORIGEM { get; set; }

        public int ID_CLIENTE { get; set; }

        public int? QUANTIDADE_PARCELA { get; set; }

        public decimal? VALOR_TOTAL { get; set; }

        public decimal? VALOR_DESCONTO_CONVENIO { get; set; }

        public decimal? VALOR_A_RECEBER { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string NUMERO_DOCUMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PRIMEIRO_VENCIMENTO { get; set; }

        public decimal? TAXA_COMISSAO { get; set; }

        public decimal? VALOR_COMISSAO { get; set; }

        public int? INTERVALO_ENTRE_PARCELAS { get; set; }

        [StringLength(3)]
        public string CODIGO_MODULO_LCTO { get; set; }

        public int? MESCLADO_PARA { get; set; }

        [StringLength(32)]
        public string HASH_MODULO_LCTO { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        public virtual FIN_DOCUMENTO_ORIGEM FIN_DOCUMENTO_ORIGEM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LCTO_RECEBER_NT_FINANCEIRA> FIN_LCTO_RECEBER_NT_FINANCEIRA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBER> FIN_PARCELA_RECEBER { get; set; }
    }
}
