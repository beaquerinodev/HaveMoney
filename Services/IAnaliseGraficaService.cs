using System;
using System.Collections.Generic;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public interface IAnaliseGraficaService
    {
        List<Sinal> GerarSinais(List<Ativo> ativos, TimeSpan prazoOperacao);
    }
}
