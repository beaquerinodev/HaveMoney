using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HaveMoney.Models;
using HaveMoney.Services;

namespace HaveMoney
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IAtivoService ativoService = new AtivoService(); // Instanciar o serviço de ativos

            // Passo 1: Selecionar ativos
            Console.WriteLine("Selecionando ativos com tendência clara...");
            var ativos = await ativoService.ObterAtivosComTendenciaClara();
            ExibirAtivos(ativos);

            // Solicitar ao usuário para escolher ativos
            Console.WriteLine("Digite o código dos ativos que deseja analisar, separados por vírgula (ex: AAPL,MSFT):");
            var codigosSelecionados = Console.ReadLine()?.Split(',').Select(c => c.Trim()).ToList();

            if (codigosSelecionados != null)
            {
                var ativosSelecionados = ativos.Where(a => codigosSelecionados.Contains(a.Codigo)).ToList();

                // Passo 2: Aplicar análise gráfica
                Console.WriteLine("Digite o prazo da operação (em dias):");
                var prazo = int.Parse(Console.ReadLine());

                var sinaisGerados = AplicarAnaliseGrafica(ativosSelecionados, prazo);

                // Passo 3: Informar sinais ao usuário
                Console.WriteLine("Sinais gerados:");
                ExibirSinais(sinaisGerados);
            }
        }

        static void ExibirAtivos(List<Ativo> ativos)
        {
            foreach (var ativo in ativos)
            {
                Console.WriteLine($"Código: {ativo.Codigo}, Nome: {ativo.Nome}");
            }
        }

        static List<Sinal> AplicarAnaliseGrafica(List<Ativo> ativos, int prazo)
        {
            // Implementar a lógica de análise gráfica aqui
            // Para fins de exemplo, retornando uma lista vazia
            return new List<Sinal>();
        }

        static void ExibirSinais(List<Sinal> sinais)
        {
            foreach (var sinal in sinais)
            {
                Console.WriteLine($"Ativo: {sinal.AtivoCodigo}, Sinal: {sinal.TipoSinal}");
            }
        }
    }
}
