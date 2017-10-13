namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CONVENIO")]
    public partial class CONVENIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONVENIO()
        {
            CLIENTE = new HashSet<CLIENTE>();
        }

        public int ID { get; set; }

        public int ID_EMPRESA { get; set; }

        [StringLength(150)]
        public string NOME { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(250)]
        public string EMAIL { get; set; }

        [StringLength(250)]
        public string SITE { get; set; }

        public decimal? DESCONTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_VENCIMENTO { get; set; }

        [StringLength(100)]
        public string LOGRADOURO { get; set; }

        [StringLength(10)]
        public string NUMERO { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }

        [StringLength(60)]
        public string CIDADE { get; set; }

        public int? MUNICIPIO_IBGE { get; set; }

        [StringLength(2)]
        public string UF { get; set; }

        [StringLength(14)]
        public string TELEFONE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_CADASTRO { get; set; }

        [Column(TypeName = "text")]
        public string DESCRICAO { get; set; }

        [StringLength(8)]
        public string CEP { get; set; }

        [StringLength(30)]
        public string CLASSIFICACAO_CONTABIL_CONTA { get; set; }

        [StringLength(100)]
        public string CONTATO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTE> CLIENTE { get; set; }

        public virtual EMPRESA EMPRESA { get; set; }
    }
}
