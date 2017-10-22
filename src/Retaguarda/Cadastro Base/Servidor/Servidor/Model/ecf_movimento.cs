namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_movimento")]
    public partial class ecf_movimento
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_ecf_empresa { get; set; }

        public int? id_ecf_turno { get; set; }

        public int? id_ecf_impressora { get; set; }

        public int? id_ecf_operador { get; set; }

        public int? id_ecf_caixa { get; set; }

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

        [Required]
        [StringLength(1)]
        public string status_movimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
