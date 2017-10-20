namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.empresa_telefone")]
    public partial class EmpresaTelefone
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

        public int? tipo { get; set; }

        [StringLength(14)]
        public string numero { get; set; }

        public string observacao { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
