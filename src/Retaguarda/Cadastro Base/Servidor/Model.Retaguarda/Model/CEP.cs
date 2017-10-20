namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cep")]
    public partial class CEP
    {
        public int id { get; set; }

        public int? id_regiao { get; set; }

        [Column("cep")]
        [StringLength(8)]
        public string cep1 { get; set; }

        [StringLength(60)]
        public string logradouro { get; set; }

        [StringLength(60)]
        public string complemento { get; set; }

        [StringLength(60)]
        public string bairro { get; set; }

        [StringLength(60)]
        public string municipio { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        public int? codigo_ibge_municipio { get; set; }

        public virtual Regiao regiao { get; set; }
    }
}
