namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.socio_dependente")]
    public partial class socio_dependente
    {
        public int id { get; set; }

        public int id_socio { get; set; }

        public int id_tipo_relacionamento { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_nascimento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_inicio_depedencia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_fim_dependencia { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        public virtual socio socio { get; set; }

        public virtual tipo_relacionamento tipo_relacionamento { get; set; }
    }
}
