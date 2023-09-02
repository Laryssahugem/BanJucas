using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Conta
    {
        public int Id { get; set; }
        public int IdCorrentista { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }
        public string StatusConta { get; set; }
        public string TipoConta { get; set; } 
        public string Senha { get; set; }
    }
}
