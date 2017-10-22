namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_nota_fiscal_cabecalho")]
    public partial class ecf_nota_fiscal_cabecalho
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_ecf_funcionario { get; set; }

        public int? id_cliente { get; set; }

        [StringLength(14)]
        public string cpf_cnpj_cliente { get; set; }

        public int? cfop { get; set; }

        [StringLength(6)]
        public string numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao { get; set; }

        [StringLength(8)]
        public string hora_emissao { get; set; }

        [StringLength(2)]
        public string serie { get; set; }

        [StringLength(2)]
        public string subserie { get; set; }

        public decimal? total_produtos { get; set; }

        public decimal? total_nf { get; set; }

        public decimal? base_icms { get; set; }

        public decimal? icms { get; set; }

        public decimal? icms_outras { get; set; }

        public decimal? issqn { get; set; }

        public decimal? pis { get; set; }

        public decimal? cofins { get; set; }

        public decimal? ipi { get; set; }

        public decimal? taxa_acrescimo { get; set; }

        public decimal? acrescimo { get; set; }

        public decimal? acrescimo_itens { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? desconto { get; set; }

        public decimal? desconto_itens { get; set; }

        [StringLength(1)]
        public string cancelada { get; set; }

        [StringLength(1)]
        public string tipo_nota { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
