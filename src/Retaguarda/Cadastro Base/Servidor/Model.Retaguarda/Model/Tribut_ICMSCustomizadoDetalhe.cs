namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_icms_custom_det")]
    public partial class Tribut_ICMSCustomizadoDetalhe
    {
        public int id { get; set; }

        public int id_tribut_icms_custom_cab { get; set; }

        [StringLength(2)]
        public string uf_destino { get; set; }

        public int? cfop { get; set; }

        [StringLength(3)]
        public string csosn_b { get; set; }

        [StringLength(2)]
        public string cst_b { get; set; }

        [StringLength(1)]
        public string modalidade_bc { get; set; }

        public decimal? aliquota { get; set; }

        public decimal? valor_pauta { get; set; }

        public decimal? valor_preco_maximo { get; set; }

        public decimal? mva { get; set; }

        public decimal? porcento_bc { get; set; }

        [StringLength(1)]
        public string modalidade_bc_st { get; set; }

        public decimal? aliquota_interna_st { get; set; }

        public decimal? aliquota_interestadual_st { get; set; }

        public decimal? porcento_bc_st { get; set; }

        public decimal? aliquota_icms_st { get; set; }

        public decimal? valor_pauta_st { get; set; }

        public decimal? valor_preco_maximo_st { get; set; }

        public virtual Tribut_ICMSCustomizadoCabecalho tribut_icms_custom_cab { get; set; }
    }
}