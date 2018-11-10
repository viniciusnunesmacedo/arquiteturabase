using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArquiteturaBase.Dominio.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        #region métodos síncronos
        void Adicionar(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
        void Excluir(Expression<Func<T, bool>> onde);
        T Buscar(Expression<Func<T, bool>> where);
        T BuscarPorCodigo(long id);
        T BuscarPorCodigo(string id);
        IEnumerable<T> BuscarTodos();
        IEnumerable<T> BuscarPorCriterio(Expression<Func<T, bool>> onde);
        #endregion
        #region métodos assíncronos
        void AdicionarAsync(T entidade);
        void AtualizarAsync(T entidade);
        void ExcluirAsync(T entidade);
        void ExcluirAsync(Expression<Func<T, bool>> onde);
        Task<T> BuscarPorCodigoAsync(long id);
        Task<IEnumerable<T>> BuscarTodosAsync();
        Task<IEnumerable<T>> BuscarPorCriterioAsync(Expression<Func<T, bool>> onde);
        #endregion
    }
}
