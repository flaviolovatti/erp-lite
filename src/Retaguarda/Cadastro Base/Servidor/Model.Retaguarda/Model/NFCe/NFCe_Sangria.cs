namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfce_sangria")]
    public partial class NFCe_Sangria
    {
        public int id { get; set; }

        public int id_nfce_movimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_sangria { get; set; }

        public decimal? valor { get; set; }

        public string observacao { get; set; }

        public virtual NFCe_Movimento nfce_movimento { get; set; }
    }
}