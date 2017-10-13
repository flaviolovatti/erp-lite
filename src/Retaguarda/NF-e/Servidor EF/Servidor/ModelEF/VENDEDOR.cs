namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDEDOR")]
    public partial class VENDEDOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDEDOR()
        {
            NFE_CABECALHO = new HashSet<NFE_CABECALHO>();
            VENDA_CABECALHO = new HashSet<VENDA_CABECALHO>();
            VENDA_COMISSAO = new HashSet<VENDA_COMISSAO>();
            VENDA_ORCAMENTO_CABECALHO = new HashSet<VENDA_ORCAMENTO_CABECALHO>();
        }

        public int ID { get; set; }

        public int? ID_TABELA_PRECO { get; set; }

        public int? ID_REGIAO { get; set; }

        public int? ID_COMISSAO_PERFIL { get; set; }

        public int? ID_COLABORADOR { get; set; }

        public decimal? COMISSAO { get; set; }

        public decimal? META_VENDAS { get; set; }

        [StringLength(1)]
        public string GERENTE { get; set; }

        public decimal? TAXA_GERENTE { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        public virtual COMISSAO_PERFIL COMISSAO_PERFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NFE_CABECALHO> NFE_CABECALHO { get; set; }

        public virtual REGIAO REGIAO { get; set; }

        public virtual TABELA_PRECO TABELA_PRECO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_CABECALHO> VENDA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_COMISSAO> VENDA_COMISSAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA_ORCAMENTO_CABECALHO> VENDA_ORCAMENTO_CABECALHO { get; set; }
    }
}
