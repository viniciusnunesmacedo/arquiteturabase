using ArquiteturaBase.Dominio.Interfaces;
using ArquiteturaBase.Infraestrutura.Dados.Contextos;
using ArquiteturaBase.Infraestrutura.Dados.Interfaces;

namespace ArquiteturaBase.Infraestrutura.Dados.Implementacoes
{
    public class UnidateTrabalho : IUnidadeTrabalho
    {
        private IFabricaBaseDados _fabricaBaseDados { get; }
        private ArquiteturaBaseContexto _contexto;
        private ArquiteturaBaseContexto Contexto => _contexto ?? (_contexto = _fabricaBaseDados.BuscarContexto());

        public UnidateTrabalho(IFabricaBaseDados fabricaBaseDados)
        {
            _fabricaBaseDados = fabricaBaseDados;
        }

        /// <summary>
        /// Commit();
        /// </summary>
        public void SubmeterBancoDados()
        {
            Contexto.SaveChanges();
        }
    }
}
