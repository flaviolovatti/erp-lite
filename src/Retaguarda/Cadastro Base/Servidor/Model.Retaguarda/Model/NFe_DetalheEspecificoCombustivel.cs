namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_det_especifico_combustivel")]
    public partial class NFe_DetalheEspecificoCombustivel
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public int? codigo_anp { get; set; }

        [StringLength(21)]
        public string codif { get; set; }

        public decimal? quantidade_temp_ambiente { get; set; }

        [StringLength(2)]
        public string uf_consumo { get; set; }

        public decimal? base_calculo_cide { get; set; }

        public decimal? aliquota_cide { get; set; }

        public decimal? valor_cide { get; set; }

        [StringLength(95)]
        public string descricao_produto_anp { get; set; }

        public decimal? percentual_petroleo { get; set; }

        public decimal? percentual_nacional { get; set; }

        public decimal? percentual_importado { get; set; }

        public decimal? valor_partida { get; set; }

        public int? numero_identificacao_bico { get; set; }

        public int? numero_identificacao_bomba { get; set; }

        public int? numero_identificacao_tanque { get; set; }

        public decimal? valor_encerrante_inicio { get; set; }

        public decimal? valor_encerrante_fim { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }
    }
}
