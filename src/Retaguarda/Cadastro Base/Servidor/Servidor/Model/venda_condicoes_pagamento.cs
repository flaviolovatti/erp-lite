namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.venda_condicoes_pagamento")]
    public partial class venda_condicoes_pagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public venda_condicoes_pagamento()
        {
            venda_cabecalho = new HashSet<venda_cabecalho>();
            venda_condicoes_parcelas = new HashSet<venda_condicoes_parcelas>();
            venda_orcamento_cabecalho = new HashSet<venda_orcamento_cabecalho>();
        }

        public int id { get; set; }

        public int id_fin_tipo_recebimento { get; set; }

        public int id_empresa { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        public string descricao { get; set; }

        public decimal? faturamento_minimo { get; set; }

        public decimal? faturamento_maximo { get; set; }

        public decimal? indice_correcao { get; set; }

        public int? dias_tolerancia { get; set; }

        public decimal? valor_tolerancia { get; set; }

        public int? prazo_medio { get; set; }

        [StringLength(1)]
        public string vista_prazo { get; set; }

        public virtual Empresa empresa { get; set; }

        public virtual fin_tipo_recebimento fin_tipo_recebimento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_cabecalho> venda_cabecalho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_condicoes_parcelas> venda_condicoes_parcelas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venda_orcamento_cabecalho> venda_orcamento_cabecalho { get; set; }
    }
}
