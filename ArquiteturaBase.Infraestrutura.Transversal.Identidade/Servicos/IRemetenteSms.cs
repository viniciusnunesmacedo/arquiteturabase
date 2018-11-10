using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Servicos
{
    public interface IRemetenteSms
    {
        Task EnviaSmsAsync(string numero, string mensagem);
    }
}
