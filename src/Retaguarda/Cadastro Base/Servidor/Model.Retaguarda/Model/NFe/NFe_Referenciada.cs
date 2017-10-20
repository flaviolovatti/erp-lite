namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_referenciada")]
    public partial class NFe_Referenciada
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(44)]
        public string chave_acesso { get; set; }

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }
    }
}
