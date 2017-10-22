namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.nfe_det_especifico_armamento")]
    public partial class NFe_DetalheEspecificoArmamento
    {
        public int id { get; set; }

        public int id_nfe_detalhe { get; set; }

        public int? tipo_arma { get; set; }

        [StringLength(15)]
        public string numero_serie_arma { get; set; }

        [StringLength(15)]
        public string numero_serie_cano { get; set; }

        [StringLength(250)]
        public string descricao { get; set; }

        public virtual NFe_Detalhe nfe_detalhe { get; set; }
    }
}
