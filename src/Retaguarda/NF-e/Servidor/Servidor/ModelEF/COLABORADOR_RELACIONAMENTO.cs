namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COLABORADOR_RELACIONAMENTO
    {
        public int ID { get; set; }

        public int ID_COLABORADOR { get; set; }

        public int ID_TIPO_RELACIONAMENTO { get; set; }

        [StringLength(100)]
        public string NOME { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_NASCIMENTO { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(50)]
        public string REGISTRO_MATRICULA { get; set; }

        [StringLength(50)]
        public string REGISTRO_CARTORIO { get; set; }

        [StringLength(50)]
        public string REGISTRO_CARTORIO_NUMERO { get; set; }

        [StringLength(10)]
        public string REGISTRO_NUMERO_LIVRO { get; set; }

        [StringLength(10)]
        public string REGISTRO_NUMERO_FOLHA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_ENTREGA_DOCUMENTO { get; set; }

        [StringLength(1)]
        public string SALARIO_FAMILIA { get; set; }

        public int? SALARIO_FAMILIA_IDADE_LIMITE { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SALARIO_FAMILIA_DATA_FIM { get; set; }

        public int? IMPOSTO_RENDA_IDADE_LIMITE { get; set; }

        public int? IMPOSTO_RENDA_DATA_FIM { get; set; }

        public virtual COLABORADOR COLABORADOR { get; set; }

        public virtual TIPO_RELACIONAMENTO TIPO_RELACIONAMENTO { get; set; }
    }
}
