namespace Servidor.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.adm_parametro")]
    public partial class adm_parametro
    {
        public int id { get; set; }

        public int id_empresa { get; set; }

        public int? fin_parcela_aberto { get; set; }

        public int? fin_parcela_quitado { get; set; }

        public int? fin_parcela_quitado_parcial { get; set; }

        public int? fin_tipo_recebimento_edi { get; set; }

        public int? compra_fin_doc_origem { get; set; }

        public int? compra_conta_caixa { get; set; }

        public virtual Empresa empresa { get; set; }
    }
}
