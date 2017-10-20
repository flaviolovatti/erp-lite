namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.comissao_objetivo")]
    public partial class ComissaoObjetivo
    {
        public int id { get; set; }

        public int? id_tabela_preco { get; set; }

        public int? id_produto { get; set; }

        public int id_comissao_perfil { get; set; }

        [StringLength(3)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        public string descricao { get; set; }

        [StringLength(1)]
        public string forma_pagamento { get; set; }

        public decimal? taxa_pagamento { get; set; }

        public decimal? valor_pagamento { get; set; }

        public decimal? valor_meta { get; set; }

        public decimal? quantidade { get; set; }

        public virtual ComissaoPerfil comissao_perfil { get; set; }

        public virtual Produto produto { get; set; }

        public virtual TabelaPreco tabela_preco { get; set; }
    }
}
