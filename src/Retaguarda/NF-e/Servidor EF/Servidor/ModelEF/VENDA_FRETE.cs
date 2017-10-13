namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VENDA_FRETE
    {
        public int ID { get; set; }

        public int ID_TRANSPORTADORA { get; set; }

        public int ID_VENDA_CABECALHO { get; set; }

        public int? CONHECIMENTO { get; set; }

        [StringLength(1)]
        public string RESPONSAVEL { get; set; }

        [StringLength(7)]
        public string PLACA { get; set; }

        [StringLength(2)]
        public string UF_PLACA { get; set; }

        public int? SELO_FISCAL { get; set; }

        public decimal? QUANTIDADE_VOLUME { get; set; }

        [StringLength(50)]
        public string MARCA_VOLUME { get; set; }

        [StringLength(20)]
        public string ESPECIE_VOLUME { get; set; }

        public decimal? PESO_BRUTO { get; set; }

        public decimal? PESO_LIQUIDO { get; set; }

        public virtual TRANSPORTADORA TRANSPORTADORA { get; set; }

        public virtual VENDA_CABECALHO VENDA_CABECALHO { get; set; }
    }
}
