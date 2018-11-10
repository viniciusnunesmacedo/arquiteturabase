using ArquiteturaBase.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Modelos
{
    public class Usuario : IUsuario
    {
        private readonly IHttpContextAccessor _accessor;

        public Usuario(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public string Nome => _accessor.HttpContext.User.Identity.Name;

        public bool EstaAutenticado()
        {
            return _accessor.HttpContext.User.Identity.IsAuthenticated;
        }

        public IEnumerable<Claim> BuscarAtributosIdentidade()
        {
            return _accessor.HttpContext.User.Claims;
        }
    }
}
