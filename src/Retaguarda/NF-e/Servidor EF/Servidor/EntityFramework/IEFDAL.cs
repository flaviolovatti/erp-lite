using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.EntityFramework
{
    interface IEFDAL<TEntity> where TEntity : class
    {
        IQueryable<TEntity> SelectAll();
        IQueryable<TEntity> Select(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);

        void Inserir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);

        void SalvarTodos();
    }
}
