namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.colaborador_relacionamento")]
    public partial class ColaboradorRelacionamento
    {
        public int id { get; set; }

        public int id_colaborador { get; set; }

        public int id_tipo_relacionamento { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_nascimento { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(50)]
        public string registro_matricula { get; set; }

        [StringLength(50)]
        public string registro_cartorio { get; set; }

        [StringLength(50)]
        public string registro_cartorio_numero { get; set; }

        [StringLength(10)]
        public string registro_numero_livro { get; set; }

        [StringLength(10)]
        public string registro_numero_folha { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_entrega_documento { get; set; }

        [StringLength(1)]
        public string salario_familia { get; set; }

        public int? salario_familia_idade_limite { get; set; }

        [Column(TypeName = "date")]
        public DateTime? salario_familia_data_fim { get; set; }

        public int? imposto_renda_idade_limite { get; set; }

        public int? imposto_renda_data_fim { get; set; }

        public virtual Colaborador colaborador { get; set; }

        public virtual TipoRelacionamento tipo_relacionamento { get; set; }
    }
}
