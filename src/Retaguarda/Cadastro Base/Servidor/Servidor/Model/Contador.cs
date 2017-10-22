namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.contador")]
    public partial class Contador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contador()
        {
            empresas = new HashSet<Empresa>();
        }

        public int id { get; set; }

        [StringLength(150)]
        public string nome { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(15)]
        public string inscricao_crc { get; set; }

        [StringLength(2)]
        public string uf_crc { get; set; }

        [StringLength(14)]
        public string fone { get; set; }

        [StringLength(14)]
        public string fax { get; set; }

        [StringLength(100)]
        public string logradouro { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(100)]
        public string complemento { get; set; }

        [StringLength(60)]
        public string bairro { get; set; }

        [StringLength(60)]
        public string cidade { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        public int? municipio_ibge { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        [StringLength(250)]
        public string site { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresa> empresas { get; set; }
    }
}
