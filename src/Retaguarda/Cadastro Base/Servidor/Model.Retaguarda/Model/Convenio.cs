namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.convenio")]
    public partial class Convenio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Convenio()
        {
            clientes = new HashSet<Cliente>();
        }

        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(150)]
        public string nome { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(250)]
        public string site { get; set; }

        public decimal? desconto { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_vencimento { get; set; }

        [StringLength(100)]
        public string logradouro { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(60)]
        public string bairro { get; set; }

        [StringLength(60)]
        public string cidade { get; set; }

        public int? municipio_ibge { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_cadastro { get; set; }

        public string descricao { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        [StringLength(30)]
        public string classificacao_contabil_conta { get; set; }

        [StringLength(100)]
        public string contato { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> clientes { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
