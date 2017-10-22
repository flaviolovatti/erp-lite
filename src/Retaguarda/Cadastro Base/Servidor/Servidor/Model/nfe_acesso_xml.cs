namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_acesso_xml")]
    public partial class nfe_acesso_xml
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }
    }
}
