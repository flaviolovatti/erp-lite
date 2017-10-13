using System;
using System.Text;
using System.Collections.Generic;


namespace Servidor.Model {
    
    public class NfeDetEspecificoMedicamentoDTO {
        public NfeDetEspecificoMedicamentoDTO() { }
        public int Id { get; set; }
        public int IdNfeDetalhe { get; set; }
        public System.Nullable<decimal> PrecoMaximoConsumidor { get; set; }
    }
}
