using System.Collections.Generic;
using System.Linq;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public class AnaliseGraficaService
    {
        public List<Sinal> AplicarAnaliseGrafica(List<Ativo> ativos, int prazo)
        {
            var sinais = new List<Sinal>();

            foreach (var ativo in ativos)
            {
                // Exemplo de lógica para gerar sinais com base na tendência e prazo
                if (ativo.Tendencia == "Alta" || ativo.Tendencia == "Baixa") // Certifique-se de usar a propriedade correta
                {
                    sinais.Add(new Sinal
                    {
                        AtivoCodigo = ativo.Codigo,
                        TipoSinal = ativo.Tendencia,
                        PrazoOperacao = prazo // Adicione o prazo de operação
                    });
                }
            }

            return sinais;
        }
    }
}
