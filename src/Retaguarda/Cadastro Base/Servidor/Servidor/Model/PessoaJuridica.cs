namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pessoa_juridica")]
    public partial class PessoaJuridica
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(150)]
        public string fantasia { get; set; }

        [StringLength(30)]
        public string inscricao_municipal { get; set; }

        [StringLength(30)]
        public string inscricao_estadual { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_constituicao { get; set; }

        [StringLength(1)]
        public string tipo_regime { get; set; }

        [StringLength(1)]
        public string crt { get; set; }

        [StringLength(9)]
        public string suframa { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
