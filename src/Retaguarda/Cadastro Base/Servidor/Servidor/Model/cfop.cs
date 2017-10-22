namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cfop")]
    public partial class cfop
    {
        public int id { get; set; }

        [Column("cfop")]
        public int? cfop1 { get; set; }

        public string descricao { get; set; }

        public string aplicacao { get; set; }
    }
}
