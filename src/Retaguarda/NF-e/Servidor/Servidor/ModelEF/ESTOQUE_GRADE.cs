namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESTOQUE_GRADE
    {
        public int ID { get; set; }

        public int? ID_EMPRESA_PRODUTO { get; set; }

        public int ID_ESTOQUE_MARCA { get; set; }

        public int ID_ESTOQUE_SABOR { get; set; }

        public int? ID_PRODUTO { get; set; }

        public int ID_ESTOQUE_TAMANHO { get; set; }

        public int ID_ESTOQUE_COR { get; set; }

        [StringLength(50)]
        public string CODIGO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public virtual EMPRESA_PRODUTO EMPRESA_PRODUTO { get; set; }

        public virtual ESTOQUE_COR ESTOQUE_COR { get; set; }

        public virtual ESTOQUE_TAMANHO ESTOQUE_TAMANHO { get; set; }

        public virtual ESTOQUE_SABOR ESTOQUE_SABOR { get; set; }

        public virtual ESTOQUE_MARCA ESTOQUE_MARCA { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }
    }
}
