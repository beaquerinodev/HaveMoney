using System;

namespace HaveMoney.Models
{
    public class Sinal
    {
        public Ativo Ativo { get; set; }
        public string TipoSinal { get; set; } // "Compra" ou "Venda"
        public DateTime DataHoraSinal { get; set; }
        public TimeSpan PrazoOperacao { get; set; }
    }
}
