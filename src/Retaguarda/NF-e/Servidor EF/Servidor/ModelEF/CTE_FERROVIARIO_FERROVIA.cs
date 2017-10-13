namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_FERROVIARIO_FERROVIA
    {
        public int ID { get; set; }

        public int ID_CTE_FERROVIARIO { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(10)]
        public string CODIGO_INTERNO { get; set; }

        [StringLength(20)]
        public string IE { get; set; }

        [StringLength(60)]
        public string NOME { get; set; }

        [StringLength(250)]
        public string LOGRADOURO { get; set; }

        [StringLength(60)]
        public string NUMERO { get; set; }

        [StringLength(60)]
        public string COMPLEMENTO { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        public int? CODIGO_MUNICIPIO { get; set; }

        [StringLength(60)]
        public string NOME_MUNICIPIO { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        public virtual CTE_FERROVIARIO CTE_FERROVIARIO { get; set; }
    }
}
