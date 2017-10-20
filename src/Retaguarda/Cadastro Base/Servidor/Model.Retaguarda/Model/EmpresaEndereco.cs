namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.empresa_endereco")]
    public partial class EmpresaEndereco
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

        [StringLength(60)]
        public string logradouro { get; set; }

        [StringLength(10)]
        public string numero { get; set; }

        [StringLength(60)]
        public string complemento { get; set; }

        [StringLength(60)]
        public string bairro { get; set; }

        [StringLength(60)]
        public string cidade { get; set; }

        [StringLength(8)]
        public string cep { get; set; }

        [StringLength(14)]
        public string fone { get; set; }

        public int? municipio_ibge { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(1)]
        public string principal { get; set; }

        [StringLength(1)]
        public string entrega { get; set; }

        [StringLength(1)]
        public string cobranca { get; set; }

        [StringLength(1)]
        public string correspondencia { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
