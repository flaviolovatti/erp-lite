namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_nota_fiscal_detalhe")]
    public partial class ecf_nota_fiscal_detalhe
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_nf_cabecalho { get; set; }

        public int? id_produto { get; set; }

        public int cfop { get; set; }

        public int? item { get; set; }

        public decimal? quantidade { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_total { get; set; }

        public decimal? base_icms { get; set; }

        public decimal? taxa_icms { get; set; }

        public decimal? icms { get; set; }

        public decimal? icms_outras { get; set; }

        public decimal? icms_isento { get; set; }

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

        public decimal? taxa_ipi { get; set; }

        public decimal? ipi { get; set; }

        [StringLength(1)]
        public string cancelado { get; set; }

        [StringLength(3)]
        public string cst { get; set; }

        [StringLength(1)]
        public string movimenta_estoque { get; set; }

        [StringLength(4)]
        public string ecf_icms_st { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
