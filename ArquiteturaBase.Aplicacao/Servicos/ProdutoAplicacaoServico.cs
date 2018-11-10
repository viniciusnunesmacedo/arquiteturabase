using ArquiteturaBase.Aplicacao.Interfaces;
using ArquiteturaBase.Aplicacao.ModelosTela;
using ArquiteturaBase.Dominio.Interfaces.Repositorios;
using ArquiteturaBase.Infraestrutura.Transversal.Assistentes;
using System.Collections.Generic;

namespace ArquiteturaBase.Aplicacao.Servicos
{
    public class ProdutoAplicacaoServico : IProdutoAplicacaoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoAplicacaoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IEnumerable<ProdutoModeloTela> BuscarTodos()
        {
            return _produtoRepositorio.BuscarTodos().MapeamentoParaLista<ProdutoModeloTela>();
        }
    }
}
