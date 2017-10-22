namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_venda_cabecalho")]
    public partial class ecf_venda_cabecalho
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_cliente { get; set; }

        public int? id_ecf_funcionario { get; set; }

        public int? id_ecf_movimento { get; set; }

        public int? id_ecf_dav { get; set; }

        public int? id_ecf_pre_venda_cabecalho { get; set; }

        [StringLength(20)]
        public string serie_ecf { get; set; }

        public int? cfop { get; set; }

        public int? coo { get; set; }

        public int? ccf { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_venda { get; set; }

        [StringLength(8)]
        public string hora_venda { get; set; }

        public decimal? valor_venda { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? desconto { get; set; }

        public decimal? taxa_acrescimo { get; set; }

        public decimal? acrescimo { get; set; }

        public decimal? valor_final { get; set; }

        public decimal? valor_recebido { get; set; }

        public decimal? troco { get; set; }

        public decimal? valor_cancelado { get; set; }

        public decimal? total_produtos { get; set; }

        public decimal? total_documento { get; set; }

        public decimal? base_icms { get; set; }

        public decimal? icms { get; set; }

        public decimal? icms_outras { get; set; }

        public decimal? issqn { get; set; }

        public decimal? pis { get; set; }

        public decimal? cofins { get; set; }

        public decimal? acrescimo_itens { get; set; }

        public decimal? desconto_itens { get; set; }

        [StringLength(1)]
        public string status_venda { get; set; }

        [StringLength(100)]
        public string nome_cliente { get; set; }

        [StringLength(14)]
        public string cpf_cnpj_cliente { get; set; }

        [StringLength(1)]
        public string cupom_cancelado { get; set; }

        [StringLength(32)]
        public string logss { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
