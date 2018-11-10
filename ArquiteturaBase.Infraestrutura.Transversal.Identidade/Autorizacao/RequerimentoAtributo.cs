using Microsoft.AspNetCore.Authorization;

namespace ArquiteturaBase.Infraestrutura.Transversal.Identidade.Autorizacao
{
    public class RequerimentoAtributo : IAuthorizationRequirement
    {
        public string Nome { get; set; }
        public string Valor { get; set; }

        public RequerimentoAtributo(string nome, string valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
