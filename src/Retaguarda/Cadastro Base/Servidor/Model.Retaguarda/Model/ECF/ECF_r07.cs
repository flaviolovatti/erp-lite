namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_r07")]
    public partial class ECF_r07
    {
        public int id { get; set; }

        [StringLength(8)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_r06 { get; set; }

        public int? ccf { get; set; }

        [StringLength(20)]
        public string meio_pagamento { get; set; }

        public decimal? valor_pagamento { get; set; }

        [StringLength(1)]
        public string estorno { get; set; }

        public decimal? valor_estorno { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
