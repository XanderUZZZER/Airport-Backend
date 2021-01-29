using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.DB.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Create(TEntity entity);
        void Edit(TEntity entity);
        void Delete(int id);
    }
}
