namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_JURIDICA
    {
        public int ID { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(150)]
        public string FANTASIA { get; set; }

        [StringLength(30)]
        public string INSCRICAO_MUNICIPAL { get; set; }

        [StringLength(30)]
        public string INSCRICAO_ESTADUAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CONSTITUICAO { get; set; }

        [StringLength(1)]
        public string TIPO_REGIME { get; set; }

        [StringLength(1)]
        public string CRT { get; set; }

        [StringLength(9)]
        public string SUFRAMA { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
