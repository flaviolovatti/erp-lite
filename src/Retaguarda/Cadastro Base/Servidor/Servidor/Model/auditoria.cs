namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.auditoria")]
    public partial class auditoria
    {
        public int id { get; set; }

        public int id_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_registro { get; set; }

        [StringLength(8)]
        public string hora_registro { get; set; }

        [StringLength(50)]
        public string janela_controller { get; set; }

        [StringLength(50)]
        public string acao { get; set; }

        public string conteudo { get; set; }

        public virtual Usuario usuario { get; set; }
    }
}
