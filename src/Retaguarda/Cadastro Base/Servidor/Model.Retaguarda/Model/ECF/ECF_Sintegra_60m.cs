namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_sintegra_60m")]
    public partial class ECF_Sintegra_60m
    {
        public int id { get; set; }

        [StringLength(8)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(20)]
        public string numero_serie_ecf { get; set; }

        public int? numero_equipamento { get; set; }

        [StringLength(2)]
        public string modelo_documento_fiscal { get; set; }

        public int? coo_inicial { get; set; }

        public int? coo_final { get; set; }

        public int? crz { get; set; }

        public int? cro { get; set; }

        public decimal? valor_venda_bruta { get; set; }

        public decimal? valor_grande_total { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
