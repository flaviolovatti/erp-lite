namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_cobranca")]
    public partial class fin_cobranca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_cobranca()
        {
            fin_cobranca_parcela_receber = new HashSet<fin_cobranca_parcela_receber>();
        }

        public int id { get; set; }

        public int id_cliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_contato { get; set; }

        [StringLength(8)]
        public string hora_contato { get; set; }

        [StringLength(14)]
        public string telefone_contato { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_acerto_pagamento { get; set; }

        public decimal? total_receber_na_data { get; set; }

        public virtual Cliente cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cobranca_parcela_receber> fin_cobranca_parcela_receber { get; set; }
    }
}
