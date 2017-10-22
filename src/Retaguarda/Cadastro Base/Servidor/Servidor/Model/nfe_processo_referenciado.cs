namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_processo_referenciado")]
    public partial class nfe_processo_referenciado
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(60)]
        public string identificador { get; set; }

        [StringLength(1)]
        public string origem { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }
    }
}
