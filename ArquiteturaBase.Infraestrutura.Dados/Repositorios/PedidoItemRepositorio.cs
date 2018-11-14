using ArquiteturaBase.Dominio.Interfaces.Repositorios;
using ArquiteturaBase.Dominio.Modelos;
using ArquiteturaBase.Infraestrutura.Dados.Contextos;
using ArquiteturaBase.Infraestrutura.Dados.Implementacoes;
using ArquiteturaBase.Infraestrutura.Dados.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Dados.Repositorios
{
    public class PedidoItemRepositorio : Repositorio<PedidoItem>, IPedidoItemRepositorio
    {
        private ArquiteturaBaseContexto _contexto;

        private IFabricaBaseDados _fabricaBaseDados { get; }

        public PedidoItemRepositorio(IFabricaBaseDados fabricaBaseDados)
        : base(fabricaBaseDados)
        {
            _fabricaBaseDados = fabricaBaseDados;
        }

        protected ArquiteturaBaseContexto Contexto => _contexto ?? (_contexto = _fabricaBaseDados.BuscarContexto());
    }
}
