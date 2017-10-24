namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_iss")]
    public partial class Tribut_ISS
    {
        public int id { get; set; }

        public int id_tribut_operacao_fiscal { get; set; }

        [StringLength(1)]
        public string modalidade_base_calculo { get; set; }

        public decimal? porcento_base_calculo { get; set; }

        public decimal? aliquota_porcento { get; set; }

        public decimal? aliquota_unidade { get; set; }

        public decimal? valor_preco_maximo { get; set; }

        public decimal? valor_pauta_fiscal { get; set; }

        public int? item_lista_servico { get; set; }

        [StringLength(1)]
        public string codigo_tributacao { get; set; }

        public virtual Tribut_OperacaoFiscal tribut_operacao_fiscal { get; set; }
    }
}
