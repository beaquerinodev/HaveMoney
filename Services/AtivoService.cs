using System.Collections.Generic;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public class AtivoService : IAtivoService
    {
        public List<Ativo> ObterTodosAtivos()
        {
            return new List<Ativo>
            {
                new Ativo { Nome = "Ativo1", PrecoAtual = 100.0, Tendencia = 0.8 },
                new Ativo { Nome = "Ativo2", PrecoAtual = 50.0, Tendencia = -0.5 },
                new Ativo { Nome = "Ativo3", PrecoAtual = 75.0, Tendencia = 0.1 }
            };
        }

        public List<Ativo> ObterAtivosComTendencia()
        {
            return ObterTodosAtivos(); // Simplesmente retorna todos os ativos neste exemplo
        }
    }
}
