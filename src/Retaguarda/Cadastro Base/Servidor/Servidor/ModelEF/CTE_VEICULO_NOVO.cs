namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CTE_VEICULO_NOVO
    {
        public int ID { get; set; }

        public int ID_CTE_CABECALHO { get; set; }

        [StringLength(17)]
        public string CHASSI { get; set; }

        [StringLength(4)]
        public string COR { get; set; }

        [StringLength(40)]
        public string DESCRICAO_COR { get; set; }

        [StringLength(6)]
        public string CODIGO_MARCA_MODELO { get; set; }

        public decimal? VALOR_UNITARIO { get; set; }

        public decimal? VALOR_FRETE { get; set; }

        public virtual CTE_CABECALHO CTE_CABECALHO { get; set; }
    }
}
