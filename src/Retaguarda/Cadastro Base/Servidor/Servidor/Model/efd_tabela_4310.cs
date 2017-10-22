namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.efd_tabela_4310")]
    public partial class efd_tabela_4310
    {
        public int id { get; set; }

        public int? codigo { get; set; }

        public string descricao { get; set; }

        public string observacao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? inicio_vigencia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fim_vigencia { get; set; }
    }
}
