namespace Entity.Retaguarda.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.fin_pagamento_fixo")]
    public partial class FIN_PagamentoFixo
    {
        public int id { get; set; }

        public int id_fornecedor { get; set; }

        public int id_fin_documento_origem { get; set; }

        [StringLength(1)]
        public string pagamento_compartilhado { get; set; }

        public int? quantidade_parcela { get; set; }

        public decimal? valor_total { get; set; }

        public decimal? valor_a_pagar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data_lancamento { get; set; }

        [StringLength(50)]
        public string numero_documento { get; set; }

        public string imagem_documento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? primeiro_vencimento { get; set; }

        public int? intervalo_entre_parcelas { get; set; }

        public virtual FIN_DocumentoOrigem fin_documento_origem { get; set; }

        public virtual Fornecedor fornecedor { get; set; }
    }
}
