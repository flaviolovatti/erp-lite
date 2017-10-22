namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_movimento")]
    public partial class nfce_movimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nfce_movimento()
        {
            nfce_fechamento = new HashSet<nfce_fechamento>();
            nfce_sangria = new HashSet<nfce_sangria>();
            nfce_suprimento = new HashSet<nfce_suprimento>();
            nfe_cabecalho = new HashSet<nfe_cabecalho>();
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

        public virtual nfce_caixa nfce_caixa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_fechamento> nfce_fechamento { get; set; }

        public virtual nfce_operador nfce_operador { get; set; }

        public virtual nfce_turno nfce_turno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_sangria> nfce_sangria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfce_suprimento> nfce_suprimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nfe_cabecalho> nfe_cabecalho { get; set; }
    }
}
