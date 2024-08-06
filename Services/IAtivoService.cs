using System.Collections.Generic;
using System.Threading.Tasks;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public interface IAtivoService
    {
        Task<List<Ativo>> ObterTodosAtivos();
        Task<List<Ativo>> ObterAtivosComTendenciaClara();
    }
}
