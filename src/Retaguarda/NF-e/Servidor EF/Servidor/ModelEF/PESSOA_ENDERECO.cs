namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_ENDERECO
    {
        public int ID { get; set; }

        public int ID_PESSOA { get; set; }

        [StringLength(60)]
        public string LOGRADOURO { get; set; }

        [StringLength(10)]
        public string NUMERO { get; set; }

        [StringLength(60)]
        public string COMPLEMENTO { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        [StringLength(60)]
        public string CIDADE { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(14)]
        public string FONE { get; set; }

        public int? MUNICIPIO_IBGE { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(1)]
        public string PRINCIPAL { get; set; }

        [StringLength(1)]
        public string ENTREGA { get; set; }

        [StringLength(1)]
        public string COBRANCA { get; set; }

        [StringLength(1)]
        public string CORRESPONDENCIA { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
