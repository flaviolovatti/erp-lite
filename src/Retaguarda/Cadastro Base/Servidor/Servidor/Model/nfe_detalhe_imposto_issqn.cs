namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_detalhe_imposto_issqn")]
    public partial class nfe_detalhe_imposto_issqn
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public decimal? base_calculo_issqn { get; set; }

        public decimal? aliquota_issqn { get; set; }

        public decimal? valor_issqn { get; set; }

        public int? municipio_issqn { get; set; }

        public int? item_lista_servicos { get; set; }

        public decimal? valor_deducao { get; set; }

        public decimal? valor_outras_retencoes { get; set; }

        public decimal? valor_desconto_incondicionado { get; set; }

        public decimal? valor_desconto_condicionado { get; set; }

        public decimal? valor_retencao_iss { get; set; }

        public int? indicador_exigibilidade_iss { get; set; }

        [StringLength(20)]
        public string codigo_servico { get; set; }

        public int? municipio_incidencia { get; set; }

        public int? pais_sevico_prestado { get; set; }

        [StringLength(30)]
        public string numero_processo { get; set; }

        public int? indicador_incentivo_fiscal { get; set; }

        public virtual nfe_detalhe nfe_detalhe { get; set; }
    }
}
