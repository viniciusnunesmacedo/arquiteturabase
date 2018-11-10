using ArquiteturaBase.Dominio.Interfaces;
using ArquiteturaBase.Infraestrutura.Dados.Contextos;
using ArquiteturaBase.Infraestrutura.Dados.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ArquiteturaBase.Infraestrutura.Dados.Implementacoes
{
    public abstract class Repositorio<T> : IRepositorio<T> where T : class
    {
        private ArquiteturaBaseContexto _contexto;
        private readonly DbSet<T> _entidade;

        private IFabricaBaseDados _fabricaBaseDados { get; }
        private ArquiteturaBaseContexto Contexto => _contexto ?? (_contexto = _fabricaBaseDados.BuscarContexto());

        protected Repositorio(IFabricaBaseDados fabricaBaseDados)
        {
            _fabricaBaseDados = fabricaBaseDados;
            _entidade = Contexto.Set<T>();
        }

        #region métodos síncronos

        public virtual void Adicionar(T entidade)
        {
            _entidade.Add(entidade);
        }

        public virtual void Atualizar(T entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;
        }

        public virtual void Excluir(T entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public virtual void Excluir(Expression<Func<T, bool>> onde)
        {
            var objeto = _entidade.Where(onde).AsEnumerable();
            foreach (var obj in objeto)
            {
                _contexto.Entry(obj).State = EntityState.Deleted;
            }

            _contexto.SaveChanges();
        }

        public virtual T BuscarPorCodigo(long id)
        {
            return _entidade.Find(id);
        }

        public virtual T BuscarPorCodigo(string id)
        {
            return _entidade.Find(id);
        }

        public virtual IEnumerable<T> BuscarTodos()
        {
            return _entidade.ToList();
        }

        public virtual IEnumerable<T> BuscarPorCriterio(Expression<Func<T, bool>> onde)
        {
            return _entidade.Where(onde).ToList();
        }

        public T Buscar(Expression<Func<T, bool>> onde)
        {
            return _entidade.Where(onde).FirstOrDefault();
        }

        #endregion
        #region métodos assíncronos

        public virtual async void AdicionarAsync(T entidade)
        {
            using (_contexto = new ArquiteturaBaseContexto())
            {
                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                _contexto.Set<T>().Add(entidade);

                await _contexto.SaveChangesAsync();
                _contexto.Dispose();
            }
        }

        public virtual async void AtualizarAsync(T entidade)
        {
            using (_contexto = new ArquiteturaBaseContexto())
            {

                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                _contexto.Entry(entidade).State = EntityState.Modified;

                await _contexto.SaveChangesAsync();
                _contexto.Dispose();
            }
        }

        public virtual async void ExcluirAsync(T entidade)
        {
            using (_contexto = new ArquiteturaBaseContexto())
            {
                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                _contexto.Entry(entidade).State = EntityState.Deleted;

                await _contexto.SaveChangesAsync();
                _contexto.Dispose();
            }
        }

        public virtual async void ExcluirAsync(Expression<Func<T, bool>> where)
        {
            using (_contexto = new ArquiteturaBaseContexto())
            {
                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                var objetos = _entidade.Where(where).AsEnumerable();
                foreach (var obj in objetos)
                {
                    _contexto.Entry(obj).State = EntityState.Deleted;
                    await _contexto.SaveChangesAsync();
                }
                _contexto.Dispose();
            }
        }

        public virtual async Task<T> BuscarPorCodigoAsync(long id)
        {
            using (_contexto = new ArquiteturaBaseContexto())
            {
                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                DbSet<T> dbset = _contexto.Set<T>();
                var obj = dbset.Find(id);

                _contexto.Dispose();

                return obj;
            }
        }

        public virtual async Task<IEnumerable<T>> BuscarTodosAsync()
        {
            List<T> list;

            using (_contexto = new ArquiteturaBaseContexto())
            {
                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                DbSet<T> dbset = _contexto.Set<T>();
                list = dbset.ToListAsync().Result.ToList();

                _contexto.Dispose();
            }
            return list;
        }

        public virtual async Task<IEnumerable<T>> BuscarPorCriterioAsync(Expression<Func<T, bool>> where)
        {
            List<T> list;

            using (_contexto = new ArquiteturaBaseContexto())
            {
                if (_contexto.Database.GetDbConnection().State != ConnectionState.Open)
                    await _contexto.Database.GetDbConnection().OpenAsync();

                DbSet<T> dbset = _contexto.Set<T>();
                list = dbset.Where(where).ToListAsync().Result.ToList();

                _contexto.Dispose();
            }
            return list;
        }

        #endregion
    }
}
