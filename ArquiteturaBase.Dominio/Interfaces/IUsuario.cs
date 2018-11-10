using System.Collections.Generic;
using System.Security.Claims;

namespace ArquiteturaBase.Dominio.Interfaces
{
    public interface IUsuario
    {
        string Nome { get; }
        bool EstaAutenticado();
        IEnumerable<Claim> BuscarAtributosIdentidade();
    }
}
