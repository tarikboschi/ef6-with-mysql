using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class TipoDeDados
    {
        public int Id { get; set; }
        public string TipoString { get; set; }
        public DateTime TipoData { get; set; }
        public bool TipoBool { get; set; }
        public decimal TipoDecimal { get; set; }
        public double TipoDouble { get; set; }
        public DateTime? TipoDataNulo { get; set; }
        public float TipoFLoat { get; set; }
        public byte TipoByte { get; set; }
        public byte[] TipoArrayByte { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
