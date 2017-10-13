namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PESSOA_FISICA
    {
        public int ID { get; set; }

        public int ID_PESSOA { get; set; }

        public int ID_ESTADO_CIVIL { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(20)]
        public string RG { get; set; }

        [StringLength(20)]
        public string ORGAO_RG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_EMISSAO_RG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATA_NASCIMENTO { get; set; }

        [StringLength(1)]
        public string SEXO { get; set; }

        [StringLength(100)]
        public string NATURALIDADE { get; set; }

        [StringLength(100)]
        public string NACIONALIDADE { get; set; }

        [StringLength(1)]
        public string RACA { get; set; }

        [StringLength(3)]
        public string TIPO_SANGUE { get; set; }

        [StringLength(20)]
        public string CNH_NUMERO { get; set; }

        [StringLength(2)]
        public string CNH_CATEGORIA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CNH_VENCIMENTO { get; set; }

        [StringLength(20)]
        public string TITULO_ELEITORAL_NUMERO { get; set; }

        public int? TITULO_ELEITORAL_ZONA { get; set; }

        public int? TITULO_ELEITORAL_SECAO { get; set; }

        [StringLength(20)]
        public string RESERVISTA_NUMERO { get; set; }

        public int? RESERVISTA_CATEGORIA { get; set; }

        [StringLength(100)]
        public string NOME_MAE { get; set; }

        [StringLength(100)]
        public string NOME_PAI { get; set; }

        public virtual ESTADO_CIVIL ESTADO_CIVIL { get; set; }

        public virtual PESSOA PESSOA { get; set; }
    }
}
