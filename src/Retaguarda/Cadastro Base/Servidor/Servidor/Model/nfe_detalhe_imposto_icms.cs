namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe_imposto_icms")]
    public partial class nfe_detalhe_imposto_icms
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public int? origem_mercadoria { get; set; }

        [StringLength(2)]
        public string cst_icms { get; set; }

        [StringLength(3)]
        public string csosn { get; set; }

        public int? modalidade_bc_icms { get; set; }

        public decimal? taxa_reducao_bc_icms { get; set; }

        public decimal? base_calculo_icms { get; set; }

        public decimal? aliquota_icms { get; set; }

        public decimal? valor_icms { get; set; }

        public decimal? valor_icms_operacao { get; set; }

        public decimal? percentual_diferimento { get; set; }

        public decimal? valor_icms_diferido { get; set; }

        public int? motivo_desoneracao_icms { get; set; }

        public decimal? valor_icms_desonerado { get; set; }

        public int? modalidade_bc_icms_st { get; set; }

        public decimal? percentual_mva_icms_st { get; set; }

        public decimal? percentual_reducao_bc_icms_st { get; set; }

        public decimal? valor_base_calculo_icms_st { get; set; }

        public decimal? aliquota_icms_st { get; set; }

        public decimal? valor_icms_st { get; set; }

        public decimal? valor_bc_icms_st_retido { get; set; }

        public decimal? valor_icms_st_retido { get; set; }

        public decimal? valor_bc_icms_st_destino { get; set; }

        public decimal? valor_icms_st_destino { get; set; }

        public decimal? aliquota_credito_icms_sn { get; set; }

        public decimal? valor_credito_icms_sn { get; set; }

        public decimal? percentual_bc_operacao_propria { get; set; }

        [StringLength(2)]
        public string uf_st { get; set; }

        public decimal? valor_bc_fcp { get; set; }

        public decimal? percentual_fcp { get; set; }

        public decimal? valor_fcp { get; set; }

        public decimal? valor_bc_fcp_st { get; set; }

        public decimal? percentual_bc_fcp_st { get; set; }

        public decimal? valor_fcp_st { get; set; }

        public decimal? fcp_consumidor_final { get; set; }

        public decimal? valor_bc_fcp_retido { get; set; }

        public decimal? percentual_bc_fcp_retido { get; set; }

        public decimal? valor_fcp_retido { get; set; }

        public decimal? valor_bc_fcp_uf_destino { get; set; }

        public decimal? valor_bc_icms_uf_destino { get; set; }

        public decimal? percentual_fcp_uf_destino { get; set; }

        public decimal? aliquota_interna_uf_destino { get; set; }

        public decimal? aliquota_interestadual_ufs { get; set; }

        public decimal? percentual_provisorio_partilha { get; set; }

        public decimal? valor_icms_fcp_uf_destino { get; set; }

        public decimal? valor_icms_inter_uf_destino { get; set; }

        public decimal? valor_icms_inter_uf_remetente { get; set; }

        public virtual nfe_detalhe nfe_detalhe { get; set; }
    }
}
