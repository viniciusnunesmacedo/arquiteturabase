using ArquiteturaBase.Dominio.Interfaces.Repositorios;
using ArquiteturaBase.Dominio.Modelos;
using ArquiteturaBase.Infraestrutura.Dados.Contextos;
using ArquiteturaBase.Infraestrutura.Dados.Implementacoes;
using ArquiteturaBase.Infraestrutura.Dados.Interfaces;

namespace ArquiteturaBase.Infraestrutura.Dados.Repositorios
{
    public class PedidoRepositorio : Repositorio<Pedido>, IPedidoRepositorio
    {
        private ArquiteturaBaseContexto _contexto;

        private IFabricaBaseDados _fabricaBaseDados { get; }

        public PedidoRepositorio(IFabricaBaseDados fabricaBaseDados)
        : base(fabricaBaseDados)
        {
            _fabricaBaseDados = fabricaBaseDados;
        }

        protected ArquiteturaBaseContexto Contexto => _contexto ?? (_contexto = _fabricaBaseDados.BuscarContexto());
    }
}
