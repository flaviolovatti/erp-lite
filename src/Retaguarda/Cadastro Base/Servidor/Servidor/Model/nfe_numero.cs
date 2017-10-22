namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_numero")]
    public partial class nfe_numero
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        public int? numero { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
