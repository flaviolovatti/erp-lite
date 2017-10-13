namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CEP")]
    public partial class CEP
    {
        public int ID { get; set; }

        public int? ID_REGIAO { get; set; }

        [Column("CEP")]
        [StringLength(8)]
        public string CEP1 { get; set; }

        [StringLength(60)]
        public string LOGRADOURO { get; set; }

        [StringLength(60)]
        public string COMPLEMENTO { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        [StringLength(60)]
        public string MUNICIPIO { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        public int? CODIGO_IBGE_MUNICIPIO { get; set; }

        public virtual REGIAO REGIAO { get; set; }
    }
}
