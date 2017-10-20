namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pessoa_contato")]
    public partial class PessoaContato
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(14)]
        public string fone_comercial { get; set; }

        [StringLength(14)]
        public string fone_residencial { get; set; }

        [StringLength(14)]
        public string fone_celular { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
