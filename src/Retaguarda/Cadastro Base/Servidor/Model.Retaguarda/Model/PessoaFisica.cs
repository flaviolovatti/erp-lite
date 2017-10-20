namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.pessoa_fisica")]
    public partial class PessoaFisica
    {
        public int id { get; set; }

        public int id_pessoa { get; set; }

        public int id_estado_civil { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(20)]
        public string rg { get; set; }

        [StringLength(20)]
        public string orgao_rg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_emissao_rg { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_nascimento { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        [StringLength(100)]
        public string naturalidade { get; set; }

        [StringLength(100)]
        public string nacionalidade { get; set; }

        [StringLength(1)]
        public string raca { get; set; }

        [StringLength(3)]
        public string tipo_sangue { get; set; }

        [StringLength(20)]
        public string cnh_numero { get; set; }

        [StringLength(2)]
        public string cnh_categoria { get; set; }

        [Column(TypeName = "date")]
        public DateTime? cnh_vencimento { get; set; }

        [StringLength(20)]
        public string titulo_eleitoral_numero { get; set; }

        public int? titulo_eleitoral_zona { get; set; }

        public int? titulo_eleitoral_secao { get; set; }

        [StringLength(20)]
        public string reservista_numero { get; set; }

        public int? reservista_categoria { get; set; }

        [StringLength(100)]
        public string nome_mae { get; set; }

        [StringLength(100)]
        public string nome_pai { get; set; }

        public virtual EstadoCivil estado_civil { get; set; }

        public virtual Pessoa pessoa { get; set; }
    }
}
