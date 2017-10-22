namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pessoa_telefone")]
    public partial class PessoaTelefone
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        public int? tipo { get; set; }

        [StringLength(14)]
        public string numero { get; set; }

        public string observacao { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
