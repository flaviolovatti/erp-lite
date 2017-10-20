namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.empresa_pessoa")]
    public partial class EmpresaPessoa
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

        public int id_pessoa { get; set; }

        [StringLength(1)]
        public string responsavel_legal { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
