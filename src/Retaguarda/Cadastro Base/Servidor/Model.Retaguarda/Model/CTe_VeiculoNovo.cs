namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_veiculo_novo")]
    public partial class CTe_VeiculoNovo
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(17)]
        public string chassi { get; set; }

        [StringLength(4)]
        public string cor { get; set; }

        [StringLength(40)]
        public string descricao_cor { get; set; }

        [StringLength(6)]
        public string codigo_marca_modelo { get; set; }

        public decimal? valor_unitario { get; set; }

        public decimal? valor_frete { get; set; }

        public virtual CTe_Cabecalho cte_cabecalho { get; set; }
    }
}
