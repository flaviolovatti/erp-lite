namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.socio_participacao_societaria")]
    public partial class SocioParticipacaoSocietaria
    {
        public int id { get; set; }

        public int id_socio { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(100)]
        public string razao_social { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_entrada { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_saida { get; set; }

        public decimal? participacao { get; set; }

        [StringLength(1)]
        public string dirigente { get; set; }

        public virtual Socio socio { get; set; }
    }
}
