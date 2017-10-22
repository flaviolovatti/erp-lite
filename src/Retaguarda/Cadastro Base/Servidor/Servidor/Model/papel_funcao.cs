namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.papel_funcao")]
    public partial class papel_funcao
    {
        public int id { get; set; }

        public int id_papel { get; set; }

        public int id_funcao { get; set; }

        [StringLength(1)]
        public string pode_consultar { get; set; }

        [StringLength(1)]
        public string pode_inserir { get; set; }

        [StringLength(1)]
        public string pode_alterar { get; set; }

        [StringLength(1)]
        public string pode_excluir { get; set; }

        [StringLength(1)]
        public string habilitado { get; set; }

        public virtual funcao funcao { get; set; }

        public virtual papel papel { get; set; }
    }
}
