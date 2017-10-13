namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMISSAO_OBJETIVO
    {
        public int ID { get; set; }

        public int? ID_TABELA_PRECO { get; set; }

        public int? ID_PRODUTO { get; set; }

        public int ID_COMISSAO_PERFIL { get; set; }

        [StringLength(3)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(1)]
        public string FORMA_PAGAMENTO { get; set; }

        public decimal? TAXA_PAGAMENTO { get; set; }

        public decimal? VALOR_PAGAMENTO { get; set; }

        public decimal? VALOR_META { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public virtual COMISSAO_PERFIL COMISSAO_PERFIL { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual TABELA_PRECO TABELA_PRECO { get; set; }
    }
}
