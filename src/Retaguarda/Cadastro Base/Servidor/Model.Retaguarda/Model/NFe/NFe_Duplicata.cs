namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_duplicata")]
    public partial class NFe_Duplicata
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        public decimal? valor { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }
    }
}
