namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOCIO_PARTICIPACAO_SOCIETARIA
    {
        public int ID { get; set; }

        public int ID_SOCIO { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(100)]
        public string RAZAO_SOCIAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ENTRADA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_SAIDA { get; set; }

        public decimal? PARTICIPACAO { get; set; }

        [StringLength(1)]
        public string DIRIGENTE { get; set; }

        public virtual SOCIO SOCIO { get; set; }
    }
}
