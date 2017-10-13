namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NFE_DET_ESPECIFICO_VEICULO
    {
        public int ID { get; set; }

        public int ID_NFE_DETALHE { get; set; }

        [StringLength(1)]
        public string TIPO_OPERACAO { get; set; }

        [StringLength(17)]
        public string CHASSI { get; set; }

        [StringLength(4)]
        public string COR { get; set; }

        [StringLength(40)]
        public string DESCRICAO_COR { get; set; }

        [StringLength(4)]
        public string POTENCIA_MOTOR { get; set; }

        [StringLength(4)]
        public string CILINDRADAS { get; set; }

        [StringLength(9)]
        public string PESO_LIQUIDO { get; set; }

        [StringLength(9)]
        public string PESO_BRUTO { get; set; }

        [StringLength(9)]
        public string NUMERO_SERIE { get; set; }

        [StringLength(2)]
        public string TIPO_COMBUSTIVEL { get; set; }

        [StringLength(21)]
        public string NUMERO_MOTOR { get; set; }

        [StringLength(9)]
        public string CAPACIDADE_MAXIMA_TRACAO { get; set; }

        [StringLength(4)]
        public string DISTANCIA_EIXOS { get; set; }

        [StringLength(4)]
        public string ANO_MODELO { get; set; }

        [StringLength(4)]
        public string ANO_FABRICACAO { get; set; }

        [StringLength(1)]
        public string TIPO_PINTURA { get; set; }

        [StringLength(2)]
        public string TIPO_VEICULO { get; set; }

        [StringLength(1)]
        public string ESPECIE_VEICULO { get; set; }

        [StringLength(1)]
        public string CONDICAO_VIN { get; set; }

        [StringLength(1)]
        public string CONDICAO_VEICULO { get; set; }

        [StringLength(6)]
        public string CODIGO_MARCA_MODELO { get; set; }

        [StringLength(2)]
        public string CODIGO_COR { get; set; }

        public int? LOTACAO { get; set; }

        [StringLength(1)]
        public string RESTRICAO { get; set; }

        public virtual NFE_DETALHE NFE_DETALHE { get; set; }
    }
}
