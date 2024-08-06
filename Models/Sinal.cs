namespace HaveMoney.Models
{
    public class Sinal
    {
        public string AtivoCodigo { get; set; } // Altere para o nome correto se necessário
        public string TipoSinal { get; set; }
        public int PrazoOperacao { get; set; } // Adicione esta linha se precisar de um prazo de operação
    }
}
