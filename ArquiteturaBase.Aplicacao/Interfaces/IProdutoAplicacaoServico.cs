using ArquiteturaBase.Aplicacao.ModelosTela;
using System.Collections.Generic;

namespace ArquiteturaBase.Aplicacao.Interfaces
{
    public interface IProdutoAplicacaoServico
    {
        IEnumerable<ProdutoModeloTela> BuscarTodos();
    }
}
