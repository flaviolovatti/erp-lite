namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_documento_origem")]
    public partial class FIN_DocumentoOrigem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_DocumentoOrigem()
        {
            fin_lancamento_pagar = new HashSet<FIN_LancamentoPagar>();
            fin_lancamento_receber = new HashSet<FIN_LancamentoReceber>();
            fin_pagamento_fixo = new HashSet<FIN_PagamentoFixo>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(3)]
        public string codigo { get; set; }

        [StringLength(10)]
        public string sigla_documento { get; set; }

        public string descricao { get; set; }

        public virtual Empresa empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoPagar> fin_lancamento_pagar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_LancamentoReceber> fin_lancamento_receber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PagamentoFixo> fin_pagamento_fixo { get; set; }
    }
}
