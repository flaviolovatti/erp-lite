namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_fatura")]
    public partial class NFe_Fatura
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        public decimal? valor_original { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? valor_liquido { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }
    }
}
