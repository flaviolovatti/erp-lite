namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.compra_fornecedor_cotacao")]
    public partial class compra_fornecedor_cotacao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public compra_fornecedor_cotacao()
        {
            compra_cotacao_detalhe = new HashSet<compra_cotacao_detalhe>();
        }

        public int id { get; set; }

        public int id_compra_cotacao { get; set; }

        public int id_fornecedor { get; set; }

        [StringLength(30)]
        public string prazo_entrega { get; set; }

        [StringLength(30)]
        public string venda_condicoes_pagamento { get; set; }

        public decimal? valor_subtotal { get; set; }

        public decimal? taxa_desconto { get; set; }

        public decimal? valor_desconto { get; set; }

        public decimal? total { get; set; }

        public virtual compra_cotacao compra_cotacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<compra_cotacao_detalhe> compra_cotacao_detalhe { get; set; }

        public virtual fornecedor fornecedor { get; set; }
    }
}
