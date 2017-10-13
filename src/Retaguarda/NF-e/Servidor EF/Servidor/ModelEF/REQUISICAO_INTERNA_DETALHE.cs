namespace ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class REQUISICAO_INTERNA_DETALHE
    {
        public int ID { get; set; }

        public int ID_REQ_INTERNA_CABECALHO { get; set; }

        public int ID_PRODUTO { get; set; }

        public decimal QUANTIDADE { get; set; }

        public virtual PRODUTO PRODUTO { get; set; }

        public virtual REQUISICAO_INTERNA_CABECALHO REQUISICAO_INTERNA_CABECALHO { get; set; }
    }
}
