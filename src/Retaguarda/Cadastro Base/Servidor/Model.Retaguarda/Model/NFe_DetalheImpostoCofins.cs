namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe_imposto_cofins")]
    public partial class NFe_DetalheImpostoCofins
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        [StringLength(2)]
        public string cst_cofins { get; set; }

        public decimal? quantidade_vendida { get; set; }

        public decimal? base_calculo_cofins { get; set; }

        public decimal? aliquota_cofins_percentual { get; set; }

        public decimal? aliquota_cofins_reais { get; set; }

        public decimal? valor_cofins { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }
    }
}
