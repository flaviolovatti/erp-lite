namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pessoa")]
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            clientes = new HashSet<Cliente>();
            colaboradors = new HashSet<Colaborador>();
            dav_cabecalho = new HashSet<dav_cabecalho>();
            empresa_pessoa = new HashSet<EmpresaPessoa>();
            fin_cheque_recebido = new HashSet<fin_cheque_recebido>();
            fornecedors = new HashSet<fornecedor>();
            pessoa_alteracao = new HashSet<PessoaAlteracao>();
            pessoa_contato = new HashSet<PessoaContato>();
            pessoa_endereco = new HashSet<PessoaEndereco>();
            pessoa_fisica = new HashSet<PessoaFisica>();
            pessoa_juridica = new HashSet<PessoaJuridica>();
            pessoa_telefone = new HashSet<PessoaTelefone>();
            pre_venda_cabecalho = new HashSet<pre_venda_cabecalho>();
            transportadoras = new HashSet<transportadora>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(150)]
        public string nome { get; set; }

        [Required]
        [StringLength(1)]
        public string tipo { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(250)]
        public string site { get; set; }

        [StringLength(1)]
        public string cliente { get; set; }

        [StringLength(1)]
        public string fornecedor { get; set; }

        [StringLength(1)]
        public string colaborador { get; set; }

        [StringLength(1)]
        public string transportadora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaborador> colaboradors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dav_cabecalho> dav_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaPessoa> empresa_pessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fin_cheque_recebido> fin_cheque_recebido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<fornecedor> fornecedors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaAlteracao> pessoa_alteracao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaContato> pessoa_contato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaEndereco> pessoa_endereco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaFisica> pessoa_fisica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaJuridica> pessoa_juridica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaTelefone> pessoa_telefone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pre_venda_cabecalho> pre_venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transportadora> transportadoras { get; set; }
    }
}
