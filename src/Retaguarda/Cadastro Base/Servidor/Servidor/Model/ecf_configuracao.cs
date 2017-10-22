namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.ecf_configuracao")]
    public partial class ecf_configuracao
    {
        public int id { get; set; }

        [StringLength(30)]
        public string nome_caixa { get; set; }

        public int? id_gerado_caixa { get; set; }

        public int? id_empresa { get; set; }

        public int? id_ecf_impressora { get; set; }

        public int? id_ecf_resolucao { get; set; }

        public int? id_ecf_caixa { get; set; }

        public int? id_ecf_empresa { get; set; }

        [StringLength(250)]
        public string mensagem_cupom { get; set; }

        [StringLength(10)]
        public string porta_ecf { get; set; }

        [StringLength(15)]
        public string ip_servidor { get; set; }

        [StringLength(15)]
        public string ip_sitef { get; set; }

        [StringLength(2)]
        public string tipo_tef { get; set; }

        [StringLength(100)]
        public string titulo_tela_caixa { get; set; }

        [StringLength(250)]
        public string caminho_imagens_produtos { get; set; }

        [StringLength(250)]
        public string caminho_imagens_marketing { get; set; }

        [StringLength(250)]
        public string caminho_imagens_layout { get; set; }

        [StringLength(20)]
        public string cor_janelas_internas { get; set; }

        [StringLength(1)]
        public string marketing_ativo { get; set; }

        public int? cfop_ecf { get; set; }

        public int? cfop_nf2 { get; set; }

        public int? timeout_ecf { get; set; }

        public int? intervalo_ecf { get; set; }

        [StringLength(20)]
        public string descricao_suprimento { get; set; }

        [StringLength(20)]
        public string descricao_sangria { get; set; }

        public int? tef_tipo_gp { get; set; }

        public int? tef_tempo_espera { get; set; }

        public int? tef_espera_sts { get; set; }

        public int? tef_numero_vias { get; set; }

        public int? decimais_quantidade { get; set; }

        public int? decimais_valor { get; set; }

        public int? bits_por_segundo { get; set; }

        public int? qtde_maxima_cartoes { get; set; }

        [StringLength(1)]
        public string pesquisa_parte { get; set; }

        [StringLength(100)]
        public string configuracao_balanca { get; set; }

        [StringLength(250)]
        public string parametros_diversos { get; set; }

        public int? ultima_exclusao { get; set; }

        [StringLength(10)]
        public string laudo { get; set; }

        [StringLength(100)]
        public string indice_gerencial { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_atualizacao_estoque { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sincronizacao { get; set; }

        [StringLength(8)]
        public string hora_sincronizacao { get; set; }
    }
}
