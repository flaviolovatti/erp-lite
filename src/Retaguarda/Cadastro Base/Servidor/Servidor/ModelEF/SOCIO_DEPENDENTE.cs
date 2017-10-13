namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SOCIO_DEPENDENTE
    {
        public int ID { get; set; }

        public int ID_SOCIO { get; set; }

        public int ID_TIPO_RELACIONAMENTO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_NASCIMENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_INICIO_DEPEDENCIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_FIM_DEPENDENCIA { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        public virtual SOCIO SOCIO { get; set; }

        public virtual TIPO_RELACIONAMENTO TIPO_RELACIONAMENTO { get; set; }
    }
}
