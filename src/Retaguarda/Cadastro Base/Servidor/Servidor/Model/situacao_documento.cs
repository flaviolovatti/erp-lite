namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.situacao_documento")]
    public partial class situacao_documento
    {
        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }
    }
}
