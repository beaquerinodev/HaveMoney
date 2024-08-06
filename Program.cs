using System;
using System.Collections.Generic;
using System.Linq;
using HaveMoney.Models;
using HaveMoney.Services;

namespace HaveMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            IAtivoService ativoService = new AtivoService();
            IAnaliseGraficaService analiseGraficaService = new AnaliseGraficaService();

            // Passo 1: Obter todos os ativos
            List<Ativo> todosAtivos = ativoService.ObterTodosAtivos();
            Console.WriteLine("Ativos disponíveis:");
            for (int i = 0; i < todosAtivos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todosAtivos[i].Nome} - Preço: {todosAtivos[i].PrecoAtual}, Tendência: {todosAtivos[i].Tendencia}");
            }

            // Passo 2: Permitir ao usuário selecionar os ativos
            Console.WriteLine("\nSelecione o número dos ativos que deseja analisar (separados por vírgula):");
            string entrada = Console.ReadLine();
            var indicesSelecionados = entrada.Split(',').Select(i => int.Parse(i.Trim()) - 1).ToList();
            List<Ativo> ativosSelecionados = indicesSelecionados.Select(i => todosAtivos[i]).ToList();

            // Passo 3: Aplicar análise gráfica e gerar sinais
            TimeSpan prazoOperacao = TimeSpan.FromHours(1); // Exemplo: operação de 1 hora
            List<Sinal> sinais = analiseGraficaService.GerarSinais(ativosSelecionados, prazoOperacao);
            Console.WriteLine("\nSinais gerados:");
            foreach (var sinal in sinais)
            {
                Console.WriteLine($"{sinal.Ativo.Nome} - Tipo de Sinal: {sinal.TipoSinal} - Prazo: {sinal.PrazoOperacao}");
            }
        }
    }
}
