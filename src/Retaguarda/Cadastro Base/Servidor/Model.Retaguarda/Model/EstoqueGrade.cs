namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.estoque_grade")]
    public partial class EstoqueGrade
    {
        public int id { get; set; }

        public int? id_empresa_produto { get; set; }

        public int id_estoque_marca { get; set; }

        public int id_estoque_sabor { get; set; }

        public int? id_produto { get; set; }

        public int id_estoque_tamanho { get; set; }

        public int id_estoque_cor { get; set; }

        [StringLength(50)]
        public string codigo { get; set; }

        public decimal? quantidade { get; set; }

        public virtual EmpresaProduto empresa_produto { get; set; }

        public virtual EstoqueCor estoque_cor { get; set; }

        public virtual EstoqueMarca estoque_marca { get; set; }

        public virtual EstoqueSabor estoque_sabor { get; set; }

        public virtual EstoqueTamanho estoque_tamanho { get; set; }

        public virtual Produto produto { get; set; }
    }
}
