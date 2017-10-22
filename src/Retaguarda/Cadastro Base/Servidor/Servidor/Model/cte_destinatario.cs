namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_destinatario")]
    public partial class cte_destinatario
    {
        public int id { get; set; }

        public int id_cte_cabecalho { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [StringLength(20)]
        public string ie { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

        [StringLength(60)]
        public string fantasia { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        [StringLength(250)]
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

        [StringLength(60)]
        public string email { get; set; }

        public virtual cte_cabecalho cte_cabecalho { get; set; }
    }
}
