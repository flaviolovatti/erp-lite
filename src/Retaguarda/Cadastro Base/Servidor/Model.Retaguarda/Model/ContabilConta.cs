namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.contabil_conta")]
    public partial class ContabilConta
    {
        public int id { get; set; }

        [StringLength(30)]
        public string classificacao { get; set; }

        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inclusao { get; set; }

        [StringLength(1)]
        public string situacao { get; set; }

        [StringLength(1)]
        public string natureza { get; set; }

        [StringLength(1)]
        public string patrimonio_resultado { get; set; }

        [StringLength(1)]
        public string livro_caixa { get; set; }

        [StringLength(1)]
        public string dfc { get; set; }

        [StringLength(20)]
        public string ordem { get; set; }

        [StringLength(10)]
        public string codigo_reduzido { get; set; }

        [StringLength(2)]
        public string codigo_efd { get; set; }
    }
}
