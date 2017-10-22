namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.agencia_banco")]
    public partial class agencia_banco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public agencia_banco()
        {
            conta_caixa = new HashSet<conta_caixa>();
        }

        public int id { get; set; }

        public int id_banco { get; set; }

        [StringLength(10)]
        public string codigo { get; set; }

        [StringLength(1)]
        public string digito { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string logradouro { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        [StringLength(60)]
        public string bairro { get; set; }

        [StringLength(60)]
        public string municipio { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        [StringLength(30)]
        public string gerente { get; set; }

        [StringLength(30)]
        public string contato { get; set; }

        public string observacao { get; set; }

        public virtual Banco banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<conta_caixa> conta_caixa { get; set; }
    }
}
