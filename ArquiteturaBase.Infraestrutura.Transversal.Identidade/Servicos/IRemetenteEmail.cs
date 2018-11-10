using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Servicos
{
    public interface IRemetenteEmail
    {
        Task ConfirmacaoRemetenteEmailAsync(string remetente, string email, string link);
    }
}
