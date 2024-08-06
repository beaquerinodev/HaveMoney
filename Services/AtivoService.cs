using System.Collections.Generic;
using System.Threading.Tasks;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public class AtivoService : IAtivoService
    {
        public Task<List<Ativo>> ObterTodosAtivos()
        {
            // Implementar a lógica para obter todos os ativos
            var ativos = new List<Ativo>
            {
                new Ativo { Codigo = "AAPL", Nome = "Apple Inc." },
                new Ativo { Codigo = "MSFT", Nome = "Microsoft Corp." },
                // Adicionar mais ativos conforme necessário
            };

            return Task.FromResult(ativos);
        }

        public Task<List<Ativo>> ObterAtivosComTendenciaClara()
        {
            // Implementar a lógica para obter ativos com tendência clara
            var ativos = new List<Ativo>
            {
                new Ativo { Codigo = "AAPL", Nome = "Apple Inc." },
                new Ativo { Codigo = "MSFT", Nome = "Microsoft Corp." },
                // Adicionar mais ativos conforme necessário
            };

            return Task.FromResult(ativos);
        }
    }
}
