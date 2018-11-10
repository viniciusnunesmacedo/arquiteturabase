using ArquiteturaBase.Infraestrutura.Transversal.Identidade.Servicos;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Extensoes
{
    public static class RemetenteEmailExtensoes
    {
        public static Task ConfirmacaoRemetenteEmailAsync(this IRemetenteEmail remetente, string email, string link)
        {
            return remetente.ConfirmacaoRemetenteEmailAsync(email, "Confirme seu e-mail",
                $"Por favor confirme seu cadastro clicando <a href='{HtmlEncoder.Default.Encode(link)}'>aqui</a>");
        }
    }
}
