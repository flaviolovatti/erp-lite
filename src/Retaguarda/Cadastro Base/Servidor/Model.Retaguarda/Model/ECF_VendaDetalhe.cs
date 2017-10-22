namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_venda_detalhe")]
    public partial class ECF_VendaDetalhe
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_ecf_produto { get; set; }

        public int? id_ecf_venda_cabecalho { get; set; }

        public int? cfop { get; set; }

        [StringLength(14)]
        public string gtin { get; set; }

        public int? ccf { get; set; }

        public int? coo { get; set; }

        [StringLength(20)]
        public string serie_ecf { get; set; }

        public int? item { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_total { get; set; }

        public decimal? total_item { get; set; }

        public decimal? base_icms { get; set; }

        public decimal? taxa_icms { get; set; }

        public decimal? icms { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? desconto { get; set; }

        public decimal? taxa_issqn { get; set; }

        public decimal? issqn { get; set; }

        public decimal? taxa_pis { get; set; }

        public decimal? pis { get; set; }

        public decimal? taxa_cofins { get; set; }

        public decimal? cofins { get; set; }

        public decimal? taxa_acrescimo { get; set; }

        public decimal? acrescimo { get; set; }

        public decimal? acrescimo_rateio { get; set; }

        public decimal? desconto_rateio { get; set; }

        [StringLength(10)]
        public string totalizador_parcial { get; set; }

        [StringLength(3)]
        public string cst { get; set; }

        [StringLength(1)]
        public string cancelado { get; set; }

        [StringLength(1)]
        public string movimenta_estoque { get; set; }

        [StringLength(4)]
        public string ecf_icms_st { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
