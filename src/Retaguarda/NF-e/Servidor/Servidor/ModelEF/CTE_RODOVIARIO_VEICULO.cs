namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_RODOVIARIO_VEICULO
    {
        public int ID { get; set; }

        public int ID_CTE_RODOVIARIO { get; set; }

        [StringLength(10)]
        public string CODIGO_INTERNO { get; set; }

        [StringLength(11)]
        public string RENAVAM { get; set; }

        [StringLength(7)]
        public string PLACA { get; set; }

        public int? TARA { get; set; }

        public int? CAPACIDADE_KG { get; set; }

        public int? CAPACIDADE_M3 { get; set; }

        [StringLength(1)]
        public string TIPO_PROPRIEDADE { get; set; }

        public int? TIPO_VEICULO { get; set; }

        [StringLength(2)]
        public string TIPO_RODADO { get; set; }

        [StringLength(2)]
        public string TIPO_CARROCERIA { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(11)]
        public string PROPRIETARIO_CPF { get; set; }

        [StringLength(14)]
        public string PROPRIETARIO_CNPJ { get; set; }

        [StringLength(8)]
        public string PROPRIETARIO_RNTRC { get; set; }

        [StringLength(60)]
        public string PROPRIETARIO_NOME { get; set; }

        [StringLength(14)]
        public string PROPRIETARIO_IE { get; set; }

        [StringLength(2)]
        public string PROPRIETARIO_UF { get; set; }

        public int? PROPRIETARIO_TIPO { get; set; }

        public virtual CTE_RODOVIARIO CTE_RODOVIARIO { get; set; }
    }
}
