using System.Linq;
using System.Collections.Generic;
using FuncionariosAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using FuncionariosAPI.Infra.Data.Context;

namespace FuncionariosAPI.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType>
    {
        protected readonly SqlContext _sqlContext;

        public BaseRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        protected virtual void Insert(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Add(obj);
            _sqlContext.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _sqlContext.Set<TEntity>().Update(obj);
            _sqlContext.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _sqlContext.Set<TEntity>().Remove(Select(id));
            _sqlContext.SaveChanges();
        }

        protected virtual IList<TEntity> Select() =>
            _sqlContext.Set<TEntity>().ToList();

        protected virtual TEntity Select(int id) =>
            _sqlContext.Set<TEntity>().Find(id);
    }
}