namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_det_especifico_veiculo")]
    public partial class NFe_DetalheEspecificoVeiculo
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        [StringLength(1)]
        public string tipo_operacao { get; set; }

        [StringLength(17)]
        public string chassi { get; set; }

        [StringLength(4)]
        public string cor { get; set; }

        [StringLength(40)]
        public string descricao_cor { get; set; }

        [StringLength(4)]
        public string potencia_motor { get; set; }

        [StringLength(4)]
        public string cilindradas { get; set; }

        [StringLength(9)]
        public string peso_liquido { get; set; }

        [StringLength(9)]
        public string peso_bruto { get; set; }

        [StringLength(9)]
        public string numero_serie { get; set; }

        [StringLength(2)]
        public string tipo_combustivel { get; set; }

        [StringLength(21)]
        public string numero_motor { get; set; }

        [StringLength(9)]
        public string capacidade_maxima_tracao { get; set; }

        [StringLength(4)]
        public string distancia_eixos { get; set; }

        [StringLength(4)]
        public string ano_modelo { get; set; }

        [StringLength(4)]
        public string ano_fabricacao { get; set; }

        [StringLength(1)]
        public string tipo_pintura { get; set; }

        [StringLength(2)]
        public string tipo_veiculo { get; set; }

        [StringLength(1)]
        public string especie_veiculo { get; set; }

        [StringLength(1)]
        public string condicao_vin { get; set; }

        [StringLength(1)]
        public string condicao_veiculo { get; set; }

        [StringLength(6)]
        public string codigo_marca_modelo { get; set; }

        [StringLength(2)]
        public string codigo_cor { get; set; }

        public int? lotacao { get; set; }

        [StringLength(1)]
        public string restricao { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }
    }
}
