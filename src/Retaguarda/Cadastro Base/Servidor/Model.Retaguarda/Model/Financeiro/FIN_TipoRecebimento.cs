namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_tipo_recebimento")]
    public partial class FIN_TipoRecebimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_TipoRecebimento()
        {
            fin_parcela_recebimento = new HashSet<FIN_ParcelaRecebimento>();
            venda_condicoes_pagamento = new HashSet<VendaCondicoesPagamento>();
        }

        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int id_empresa { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        public virtual ContaCaixa conta_caixa { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_ParcelaRecebimento> fin_parcela_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VendaCondicoesPagamento> venda_condicoes_pagamento { get; set; }
    }
}
