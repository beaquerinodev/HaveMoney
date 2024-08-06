using System.Collections.Generic;
using HaveMoney.Models;

namespace HaveMoney.Services
{
    public interface IAtivoService
    {
        List<Ativo> ObterTodosAtivos();  // Adicione esta linha
        List<Ativo> ObterAtivosComTendencia();
    }
}
