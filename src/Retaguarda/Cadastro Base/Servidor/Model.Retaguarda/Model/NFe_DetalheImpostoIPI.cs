namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe_imposto_ipi")]
    public partial class NFe_DetalheImpostoIPI
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        [StringLength(5)]
        public string enquadramento_ipi { get; set; }

        [StringLength(14)]
        public string cnpj_produtor { get; set; }

        [StringLength(60)]
        public string codigo_selo_ipi { get; set; }

        public int? quantidade_selo_ipi { get; set; }

        [StringLength(3)]
        public string enquadramento_legal_ipi { get; set; }

        [StringLength(2)]
        public string cst_ipi { get; set; }

        public decimal? valor_base_calculo_ipi { get; set; }

        public decimal? aliquota_ipi { get; set; }

        public decimal? quantidade_unidade_tributavel { get; set; }

        public decimal? valor_unidade_tributavel { get; set; }

        public decimal? valor_ipi { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }
    }
}
