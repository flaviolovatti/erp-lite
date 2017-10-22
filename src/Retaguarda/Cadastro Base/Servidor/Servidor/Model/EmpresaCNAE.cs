namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.empresa_cnae")]
    public partial class EmpresaCNAE
    {
        public int id { get; set; }

        public int id_cnae { get; set; }

        public int id_empresa { get; set; }

        [StringLength(1)]
        public string principal { get; set; }

        [StringLength(50)]
        public string ramo_atividade { get; set; }

        public string objeto_social { get; set; }

        public virtual cnae cnae { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
