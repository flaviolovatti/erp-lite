namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_PROD_RURAL_REFERENCIADA
    {
        public int ID { get; set; }

        public int ID_NFE_CABECALHO { get; set; }

        public int? CODIGO_UF { get; set; }

        [StringLength(4)]
        public string ANO_MES { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(14)]
        public string INSCRICAO_ESTADUAL { get; set; }

        [StringLength(2)]
        public string MODELO { get; set; }

        [StringLength(3)]
        public string SERIE { get; set; }

        public int? NUMERO_NF { get; set; }

        public virtual NFE_CABECALHO NFE_CABECALHO { get; set; }
    }
}
