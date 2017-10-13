namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PESSOA")]
    public partial class PESSOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PESSOA()
        {
            CLIENTE1 = new HashSet<CLIENTE>();
            COLABORADOR1 = new HashSet<COLABORADOR>();
            DAV_CABECALHO = new HashSet<DAV_CABECALHO>();
            EMPRESA_PESSOA = new HashSet<EMPRESA_PESSOA>();
            FIN_CHEQUE_RECEBIDO = new HashSet<FIN_CHEQUE_RECEBIDO>();
            FORNECEDOR1 = new HashSet<FORNECEDOR>();
            PESSOA_ALTERACAO = new HashSet<PESSOA_ALTERACAO>();
            PESSOA_CONTATO = new HashSet<PESSOA_CONTATO>();
            PESSOA_ENDERECO = new HashSet<PESSOA_ENDERECO>();
            PESSOA_FISICA = new HashSet<PESSOA_FISICA>();
            PESSOA_JURIDICA = new HashSet<PESSOA_JURIDICA>();
            PESSOA_TELEFONE = new HashSet<PESSOA_TELEFONE>();
            PRE_VENDA_CABECALHO = new HashSet<PRE_VENDA_CABECALHO>();
            TRANSPORTADORA1 = new HashSet<TRANSPORTADORA>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string NOME { get; set; }

        [Required]
        [StringLength(1)]
        public string TIPO { get; set; }

        [StringLength(250)]
        public string EMAIL { get; set; }

        [StringLength(250)]
        public string SITE { get; set; }

        [StringLength(1)]
        public string CLIENTE { get; set; }

        [StringLength(1)]
        public string FORNECEDOR { get; set; }

        [StringLength(1)]
        public string COLABORADOR { get; set; }

        [StringLength(1)]
        public string TRANSPORTADORA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE> CLIENTE1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR> COLABORADOR1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAV_CABECALHO> DAV_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA_PESSOA> EMPRESA_PESSOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FIN_CHEQUE_RECEBIDO> FIN_CHEQUE_RECEBIDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FORNECEDOR> FORNECEDOR1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_ALTERACAO> PESSOA_ALTERACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_CONTATO> PESSOA_CONTATO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_ENDERECO> PESSOA_ENDERECO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_FISICA> PESSOA_FISICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_JURIDICA> PESSOA_JURIDICA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PESSOA_TELEFONE> PESSOA_TELEFONE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRE_VENDA_CABECALHO> PRE_VENDA_CABECALHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSPORTADORA> TRANSPORTADORA1 { get; set; }
    }
}
