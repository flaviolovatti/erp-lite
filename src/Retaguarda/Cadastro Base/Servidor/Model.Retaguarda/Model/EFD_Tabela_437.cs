namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.efd_tabela_437")]
    public partial class EFD_Tabela_437
    {
        public int id { get; set; }

        [StringLength(2)]
        public string codigo { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }
    }
}
