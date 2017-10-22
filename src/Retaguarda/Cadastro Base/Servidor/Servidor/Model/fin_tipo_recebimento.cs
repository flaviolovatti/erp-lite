namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_tipo_recebimento")]
    public partial class fin_tipo_recebimento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fin_tipo_recebimento()
        {
            fin_parcela_recebimento = new HashSet<fin_parcela_recebimento>();
            venda_condicoes_pagamento = new HashSet<venda_condicoes_pagamento>();
        }

        public int id { get; set; }

        public int id_conta_caixa { get; set; }

        public int id_empresa { get; set; }

        [StringLength(2)]
        public string tipo { get; set; }

        [StringLength(100)]
        public string descricao { get; set; }

        public virtual conta_caixa conta_caixa { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_parcela_recebimento> fin_parcela_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_condicoes_pagamento> venda_condicoes_pagamento { get; set; }
    }
}
