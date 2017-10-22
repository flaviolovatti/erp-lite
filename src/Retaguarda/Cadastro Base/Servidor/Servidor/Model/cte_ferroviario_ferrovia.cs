namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_ferroviario_ferrovia")]
    public partial class cte_ferroviario_ferrovia
    {
        public int id { get; set; }

        public int id_cte_ferroviario { get; set; }

        [StringLength(14)]
        public string cnpj { get; set; }

        [StringLength(10)]
        public string codigo_interno { get; set; }

        [StringLength(20)]
        public string ie { get; set; }

        [StringLength(60)]
        public string nome { get; set; }

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

        public virtual cte_ferroviario cte_ferroviario { get; set; }
    }
}
