using ModelEF;
using System;
using System.Data.Entity;
using System.Linq;

namespace Servidor.EntityFramework
{
    public class EntityFrameworkDAL<TEntity> : IDisposable,
       IEFDAL<TEntity> where TEntity : class
    {

        public ContextoT2TiERP ctx = new ContextoT2TiERP();

        public EntityFrameworkDAL()
        {
            ctx.Configuration.ProxyCreationEnabled = false;
            ctx.Configuration.LazyLoadingEnabled = false;
        }

        public IQueryable<TEntity> SelectAll()
        {
            return ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Select(Func<TEntity, bool> predicate)
        {
            return SelectAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }


        public void Inserir(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}