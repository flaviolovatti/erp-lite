namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_frete")]
    public partial class venda_frete
    {
        public int id { get; set; }

        public int id_transportadora { get; set; }

        public int id_venda_cabecalho { get; set; }

        public int? conhecimento { get; set; }

        [StringLength(1)]
        public string responsavel { get; set; }

        [StringLength(7)]
        public string placa { get; set; }

        [StringLength(2)]
        public string uf_placa { get; set; }

        public int? selo_fiscal { get; set; }

        public decimal? quantidade_volume { get; set; }

        [StringLength(50)]
        public string marca_volume { get; set; }

        [StringLength(20)]
        public string especie_volume { get; set; }

        public decimal? peso_bruto { get; set; }

        public decimal? peso_liquido { get; set; }

        public virtual transportadora transportadora { get; set; }

        public virtual venda_cabecalho venda_cabecalho { get; set; }
    }
}
