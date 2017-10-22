namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_prod_rural_referenciada")]
    public partial class nfe_prod_rural_referenciada
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        public int? codigo_uf { get; set; }

        [StringLength(4)]
        public string ano_mes { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(14)]
        public string inscricao_estadual { get; set; }

        [StringLength(2)]
        public string modelo { get; set; }

        [StringLength(3)]
        public string serie { get; set; }

        public int? numero_nf { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }
    }
}
