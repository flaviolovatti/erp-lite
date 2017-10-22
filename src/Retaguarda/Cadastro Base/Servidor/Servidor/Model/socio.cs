namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.socio")]
    public partial class socio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public socio()
        {
            socio_dependente = new HashSet<socio_dependente>();
            socio_participacao_societaria = new HashSet<socio_participacao_societaria>();
        }

        public int id { get; set; }

        public int id_quadro_societario { get; set; }

        [StringLength(100)]
        public string logradouro { get; set; }

        public int? numero { get; set; }

        [StringLength(100)]
        public string complemento { get; set; }

        [StringLength(100)]
        public string bairro { get; set; }

        [StringLength(100)]
        public string municipio { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        [StringLength(10)]
        public string fone { get; set; }

        [StringLength(10)]
        public string celular { get; set; }

        [StringLength(250)]
        public string email { get; set; }

        public decimal? participacao { get; set; }

        public int? quotas { get; set; }

        public decimal? integralizar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_ingresso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_saida { get; set; }

        public virtual quadro_societario quadro_societario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<socio_dependente> socio_dependente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<socio_participacao_societaria> socio_participacao_societaria { get; set; }
    }
}
