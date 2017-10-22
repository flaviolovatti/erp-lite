namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_destinatario")]
    public partial class nfe_destinatario
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(14)]
        public string cpf_cnpj { get; set; }

        [StringLength(20)]
        public string estrangeiro_identificacao { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

        [StringLength(60)]
        public string logradouro { get; set; }

        [StringLength(60)]
        public string numero { get; set; }

        [StringLength(60)]
        public string complemento { get; set; }

        [StringLength(60)]
        public string bairro { get; set; }

        public int? codigo_municipio { get; set; }

        [StringLength(60)]
        public string nome_municipio { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        public int? codigo_pais { get; set; }

        [StringLength(60)]
        public string nome_pais { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        public int? indicador_ie { get; set; }

        [StringLength(14)]
        public string inscricao_estadual { get; set; }

        [StringLength(15)]
        public string inscricao_municipal { get; set; }

        public int? suframa { get; set; }

        [StringLength(60)]
        public string email { get; set; }

        public virtual nfe_cabecalho nfe_cabecalho { get; set; }
    }
}
