namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_movimento")]
    public partial class NFCe_Movimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NFCe_Movimento()
        {
            nfce_fechamento = new HashSet<NFCe_Fechamento>();
            nfce_sangria = new HashSet<NFCe_Sangria>();
            nfce_suprimento = new HashSet<NFCe_Suprimento>();
            nfe_cabecalho = new HashSet<NFe_Cabecalho>();
        }

        public int id { get; set; }

        public int id_nfce_caixa { get; set; }

        public int id_nfce_operador { get; set; }

        public int id_nfce_turno { get; set; }

        public int id_empresa { get; set; }

        public int id_gerente_supervisor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_abertura { get; set; }

        [StringLength(8)]
        public string hora_abertura { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fechamento { get; set; }

        [StringLength(8)]
        public string hora_fechamento { get; set; }

        public decimal? total_suprimento { get; set; }

        public decimal? total_sangria { get; set; }

        public decimal? total_nao_fiscal { get; set; }

        public decimal? total_venda { get; set; }

        public decimal? total_desconto { get; set; }

        public decimal? total_acrescimo { get; set; }

        public decimal? total_final { get; set; }

        public decimal? total_recebido { get; set; }

        public decimal? total_troco { get; set; }

        public decimal? total_cancelado { get; set; }

        [StringLength(1)]
        public string status_movimento { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual NFCe_Caixa nfce_caixa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Fechamento> nfce_fechamento { get; set; }

        public virtual NFCe_Operador nfce_operador { get; set; }

        public virtual NFCe_Turno nfce_turno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Sangria> nfce_sangria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFCe_Suprimento> nfce_suprimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFe_Cabecalho> nfe_cabecalho { get; set; }
    }
}
