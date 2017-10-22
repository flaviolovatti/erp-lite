namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.cte_rodoviario_veiculo")]
    public partial class CTe_RodoviarioVeiculo
    {
        public int id { get; set; }

        public int id_cte_rodoviario { get; set; }

        [StringLength(10)]
        public string codigo_interno { get; set; }

        [StringLength(11)]
        public string renavam { get; set; }

        [StringLength(7)]
        public string placa { get; set; }

        public int? tara { get; set; }

        public int? capacidade_kg { get; set; }

        public int? capacidade_m3 { get; set; }

        [StringLength(1)]
        public string tipo_propriedade { get; set; }

        public int? tipo_veiculo { get; set; }

        [StringLength(2)]
        public string tipo_rodado { get; set; }

        [StringLength(2)]
        public string tipo_carroceria { get; set; }

        [StringLength(2)]
        public string uf { get; set; }

        [StringLength(11)]
        public string proprietario_cpf { get; set; }

        [StringLength(14)]
        public string proprietario_cnpj { get; set; }

        [StringLength(8)]
        public string proprietario_rntrc { get; set; }

        [StringLength(60)]
        public string proprietario_nome { get; set; }

        [StringLength(14)]
        public string proprietario_ie { get; set; }

        [StringLength(2)]
        public string proprietario_uf { get; set; }

        public int? proprietario_tipo { get; set; }

        public virtual CTe_Rodoviario cte_rodoviario { get; set; }
    }
}
