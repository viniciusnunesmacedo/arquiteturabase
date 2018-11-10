using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Autorizacao
{
    public class RequerimentoAtributoEvento : AuthorizationHandler<RequerimentoAtributo>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext contexto, RequerimentoAtributo requerimentoAtributo)
        {

            var claim = contexto.User.Claims.FirstOrDefault(c => c.Type == requerimentoAtributo.Nome);
            if (claim != null && claim.Value.Contains(requerimentoAtributo.Valor))
            {
                contexto.Succeed(requerimentoAtributo);
            }

            return Task.CompletedTask;
        }
    }
}
