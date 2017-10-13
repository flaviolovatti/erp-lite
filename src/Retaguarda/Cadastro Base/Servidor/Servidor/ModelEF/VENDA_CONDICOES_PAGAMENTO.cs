namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_CONDICOES_PAGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA_CONDICOES_PAGAMENTO()
        {
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
            VENDA_CONDICOES_PARCELAS = new HashSet<VENDA_CONDICOES_PARCELAS>();
            VENDA_ORCAMENTO_CABECALHO = new HashSet<VENDA_ORCAMENTO_CABECALHO>();
        }

        public int ID { get; set; }

        public int ID_FIN_TIPO_RECEBIMENTO { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(50)]
        public string NOME { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        public decimal? FATURAMENTO_MINIMO { get; set; }

        public decimal? FATURAMENTO_MAXIMO { get; set; }

        public decimal? INDICE_CORRECAO { get; set; }

        public int? DIAS_TOLERANCIA { get; set; }

        public decimal? VALOR_TOLERANCIA { get; set; }

        public int? PRAZO_MEDIO { get; set; }

        [StringLength(1)]
        public string VISTA_PRAZO { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }

        public virtual FIN_TIPO_RECEBIMENTO FIN_TIPO_RECEBIMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CONDICOES_PARCELAS> VENDA_CONDICOES_PARCELAS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ORCAMENTO_CABECALHO> VENDA_ORCAMENTO_CABECALHO { get; set; }
    }
}
