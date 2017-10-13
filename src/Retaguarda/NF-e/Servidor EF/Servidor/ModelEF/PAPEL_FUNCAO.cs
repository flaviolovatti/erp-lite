namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PAPEL_FUNCAO
    {
        public int ID { get; set; }

        public int ID_PAPEL { get; set; }

        public int ID_FUNCAO { get; set; }

        [StringLength(1)]
        public string PODE_CONSULTAR { get; set; }

        [StringLength(1)]
        public string PODE_INSERIR { get; set; }

        [StringLength(1)]
        public string PODE_ALTERAR { get; set; }

        [StringLength(1)]
        public string PODE_EXCLUIR { get; set; }

        [StringLength(1)]
        public string HABILITADO { get; set; }

        public virtual FUNCAO FUNCAO { get; set; }

        public virtual PAPEL PAPEL { get; set; }
    }
}
