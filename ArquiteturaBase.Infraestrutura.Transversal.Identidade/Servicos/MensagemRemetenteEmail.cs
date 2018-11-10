using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Servicos
{
    public class MensagemRemetenteEmail : IRemetenteEmail
    {
        public Task ConfirmacaoRemetenteEmailAsync(string email, string subject, string message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }
}
