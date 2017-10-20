namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_total_tipo_pagamento")]
    public partial class ECF_TotalTipoPagamento
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_ecf_venda_cabecalho { get; set; }

        public int? id_ecf_tipo_pagamento { get; set; }

        [StringLength(20)]
        public string serie_ecf { get; set; }

        public int? coo { get; set; }

        public int? ccf { get; set; }

        public int? gnf { get; set; }

        public decimal? valor { get; set; }

        [StringLength(30)]
        public string nsu { get; set; }

        [StringLength(1)]
        public string estorno { get; set; }

        [StringLength(10)]
        public string rede { get; set; }

        [StringLength(1)]
        public string cartao_dc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_venda { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
