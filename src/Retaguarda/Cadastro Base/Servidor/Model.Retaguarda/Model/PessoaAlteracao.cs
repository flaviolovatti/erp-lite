namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pessoa_alteracao")]
    public partial class PessoaAlteracao
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_alteracao { get; set; }

        public string objeto_antigo { get; set; }

        public string objeto_novo { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
