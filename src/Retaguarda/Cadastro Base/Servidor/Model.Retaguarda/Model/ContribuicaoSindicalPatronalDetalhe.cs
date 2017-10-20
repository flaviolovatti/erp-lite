namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.contrib_sind_patronal_det")]
    public partial class ContribuicaoSindicalPatronalDetalhe
    {
        public int id { get; set; }

        public int id_contrib_sind_patronal_cab { get; set; }

        public decimal? de { get; set; }

        public decimal? ate { get; set; }

        public decimal? percentual { get; set; }

        public decimal? valor_adicionar { get; set; }

        public virtual ContribuicaoSindicalPatronalCabecalho contrib_sind_patronal_cab { get; set; }
    }
}
