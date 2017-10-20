namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.efd_tabela_436")]
    public partial class EFD_Tabela_436
    {
        public int id { get; set; }

        public int? codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }
    }
}
