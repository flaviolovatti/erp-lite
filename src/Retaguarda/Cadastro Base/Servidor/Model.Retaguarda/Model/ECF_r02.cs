namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_r02")]
    public partial class ECF_r02
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int id_operador { get; set; }

        public int id_impressora { get; set; }

        public int? id_ecf_caixa { get; set; }

        [StringLength(20)]
        public string serie_ecf { get; set; }

        public int? crz { get; set; }

        public int? coo { get; set; }

        public int? cro { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_movimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(8)]
        public string hora_emissao { get; set; }

        public decimal? venda_bruta { get; set; }

        public decimal? grande_total { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
