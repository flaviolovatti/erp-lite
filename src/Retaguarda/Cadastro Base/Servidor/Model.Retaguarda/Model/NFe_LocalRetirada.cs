namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_local_retirada")]
    public partial class NFe_LocalRetirada
    {
        public int id { get; set; }

        public int id_nfe_cabecalho { get; set; }

        [StringLength(14)]
        public string cpf_cnpj { get; set; }

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

        public virtual NFe_Cabecalho nfe_cabecalho { get; set; }
    }
}
