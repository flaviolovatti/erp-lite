namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIN_TIPO_RECEBIMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FIN_TIPO_RECEBIMENTO()
        {
            FIN_PARCELA_RECEBIMENTO = new HashSet<FIN_PARCELA_RECEBIMENTO>();
            VENDA_CONDICOES_PAGAMENTO = new HashSet<VENDA_CONDICOES_PAGAMENTO>();
        }

        public int ID { get; set; }

        public int ID_CONTA_CAIXA { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public virtual CONTA_CAIXA CONTA_CAIXA { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_PARCELA_RECEBIMENTO> FIN_PARCELA_RECEBIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CONDICOES_PAGAMENTO> VENDA_CONDICOES_PAGAMENTO { get; set; }
    }
}
