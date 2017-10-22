namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.tribut_ipi_dipi")]
    public partial class tribut_ipi_dipi
    {
        public int id { get; set; }

        public int id_tribut_configura_of_gt { get; set; }

        public int? id_tipo_receita_dipi { get; set; }

        [StringLength(2)]
        public string cst_ipi { get; set; }

        [StringLength(1)]
        public string modalidade_base_calculo { get; set; }

        public decimal? porcento_base_calculo { get; set; }

        public decimal? aliquota_porcento { get; set; }

        public decimal? aliquota_unidade { get; set; }

        public decimal? valor_preco_maximo { get; set; }

        public decimal? valor_pauta_fiscal { get; set; }

        public virtual tipo_receita_dipi tipo_receita_dipi { get; set; }

        public virtual tribut_configura_of_gt tribut_configura_of_gt { get; set; }
    }
}