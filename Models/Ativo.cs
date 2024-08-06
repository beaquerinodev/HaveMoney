using System;

namespace HaveMoney.Models
{
    public class Ativo
    {
        public string Nome { get; set; }
        public double PrecoAtual { get; set; }
        public double Tendencia { get; set; } // Valor indicando a tendência do ativo
    }
}
