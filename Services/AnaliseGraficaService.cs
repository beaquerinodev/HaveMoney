using System;
using System.Collections.Generic;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public class AnaliseGraficaService : IAnaliseGraficaService
    {
        public List<Sinal> GerarSinais(List<Ativo> ativos, TimeSpan prazoOperacao)
        {
            var sinais = new List<Sinal>();

            foreach (var ativo in ativos)
            {
                // Exemplo de lógica de análise gráfica
                var tipoSinal = ativo.Tendencia > 0 ? "Compra" : "Venda";
                sinais.Add(new Sinal
                {
                    Ativo = ativo,
                    TipoSinal = tipoSinal,
                    PrazoOperacao = prazoOperacao
                });
            }

            return sinais;
        }
    }
}
