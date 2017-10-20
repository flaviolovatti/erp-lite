namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.operadora_plano_saude")]
    public partial class OperadoraPlanoSaude
    {
        public int id { get; set; }

        [StringLength(20)]
        public string registro_ans { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }
    }
}
